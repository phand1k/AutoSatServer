using AvtoMigBussines.Data;
using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.DTOModels;
using AvtoMigBussines.Models;
using AvtoMigBussines.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AvtoMigBussines.Repositories.Implementations
{
    public class MarketingRepository : IMarketingRepository
    {
        private readonly ApplicationDbContext context;
        public MarketingRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MostPopularCarsDTO>> MostPopularCars(int? organizationId)
        {
            // Получаем список заказов для организации
            var orders = await context.DetailingOrders
                .Include(x => x.ModelCar.Car)
                .Where(x => x.IsDeleted == false && x.OrganizationId == organizationId)
                .ToListAsync();

            // Группируем заказы по машине (CarId + ModelCarId)
            var carGroups = orders
                .GroupBy(x => new { x.CarId, x.ModelCarId })
                .Select(g => new
                {
                    CarId = g.Key.CarId,
                    ModelCarId = g.Key.ModelCarId,
                    Count = g.Count(), // Количество заказов для этой машины
                    CarName = g.First().ModelCar.Car.Name + " " + g.First().ModelCar.Name
                })
                .ToList();

            // Общее количество заказов (для расчёта процента)
            var totalUsageCount = carGroups.Sum(x => x.Count);

            // Формируем результат
            var popularCars = carGroups.Select(car => new MostPopularCarsDTO
            {
                CarName = car.CarName,
                Count = car.Count,
                UsagePercent = totalUsageCount > 0
                    ? (double)car.Count / totalUsageCount * 100
                    : 0
            }).OrderByDescending(x=>x.Count).ToList();

            return popularCars;
        }



        public async Task<double?> GetRevenue(int? organizationId)
        {
            var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30); // или DateTime.Now, если без UTC

            var transactions = await context.DetailingOrderTransactions
                .Where(x => x.DateOfCreated >= thirtyDaysAgo) // Фильтрация по дате
                .Where(x => x.IsDeleted == false && x.OrganizationId == organizationId)
                .ToListAsync();

            var revenue = transactions.Sum(x => x.Summ);
            return revenue;
        }

        public async Task<Dictionary<DayOfWeek, int>> GetBusiestDays(int? organizationId)
        {
            // Получаем заказы за последний месяц
            var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30); // или DateTime.Now, если без UTC

            var orders = await context.DetailingOrders
                .Where(x => x.IsDeleted == false && x.OrganizationId == organizationId && x.DateOfCreated >= thirtyDaysAgo)
                .ToListAsync();

            // Группируем заказы по дням недели
            var ordersByDayOfWeek = orders
                .GroupBy(x => x.DateOfCreated.Value.DayOfWeek) // Группировка по дню недели
                .Select(g => new
                {
                    DayOfWeek = g.Key,
                    Count = g.Count() // Количество заказов в этот день недели
                })
                .ToDictionary(x => x.DayOfWeek, x => x.Count);

            // Заполняем дни недели, если они отсутствуют (например, если в какой-то день не было заказов)
            var allDaysOfWeek = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
            foreach (var day in allDaysOfWeek)
            {
                if (!ordersByDayOfWeek.ContainsKey(day))
                {
                    ordersByDayOfWeek[day] = 0;
                }
            }

            return ordersByDayOfWeek;
        }


        public async Task<ClientStatisticsDto> GetClientStatistics(int? organizationId)
        {
            var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30); // Период: последние 30 дней

            // Получаем все заказы за последний месяц для организации
            var orders = await context.DetailingOrders
                .Where(x => x.IsDeleted == false && x.OrganizationId == organizationId && x.DateOfCreated >= thirtyDaysAgo)
                .ToListAsync();


            var transcations = await context.DetailingOrderTransactions.
                Where(x => x.IsDeleted == false && x.OrganizationId == organizationId && x.DateOfCreated >= thirtyDaysAgo)
                .ToListAsync();

            // Уникальные клиенты (по AspNetUserId)
            var uniqueClients = orders
                .GroupBy(x => x.PhoneNumber)
                .Select(g => g.First())
                .ToList();

            // Количество новых клиентов за месяц
            var newClientsCount = uniqueClients.Count;

            // Активные клиенты (те, кто совершил хотя бы один заказ)
            var activeClientsCount = uniqueClients.Count;

            // Общая выручка за месяц
            var totalRevenue = transcations.Sum(x => x.Summ);

            // Средний чек клиента
            var averageCheck = activeClientsCount > 0
                ? totalRevenue / activeClientsCount
                : 0;

            // Частота посещений (среднее количество заказов на одного клиента)
            var visitFrequency = activeClientsCount > 0
                ? (double)orders.Count / activeClientsCount
                : 0;

            return new ClientStatisticsDto
            {
                NewClientsCount = newClientsCount,
                ActiveClientsCount = activeClientsCount,
                AverageCheck = averageCheck,
                VisitFrequency = visitFrequency
            };
        }

        public async Task<IEnumerable<ServiceUsageDto>> MostPopularServices(int? organizationId)
        {
            var services = await context.Services
                .Where(x => x.OrganizationId == organizationId && x.IsDeleted == false)
                .ToListAsync();

            var serviceIds = services.Select(s => s.Id).ToList();

            var totalUsageCount = await context.DetailingServices.
                Where(x=>x.IsDeleted == false && x.OrganizationId == organizationId)
                .CountAsync(x => serviceIds.Contains((int)x.ServiceId));

            var servicesWithUsage = services.Select(service =>
            {
                var usageCount = context.DetailingServices.Where(x=>x.IsDeleted == false && x.OrganizationId == organizationId)
                    .Count(x => x.ServiceId == service.Id);

                var usagePercent = totalUsageCount > 0
                    ? (double)usageCount / totalUsageCount * 100
                    : 0;

                return new ServiceUsageDto
                {
                    Name = service.Name,
                    Price = service.Price,
                    UsagePercent = usagePercent,
                    Count = usageCount
                };
            }).OrderByDescending(x=>x.Count).ToList();

            return servicesWithUsage;
        }

    }
}
