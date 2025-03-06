using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.DTOModels;
using AvtoMigBussines.Models;

namespace AvtoMigBussines.Repositories.Interfaces
{
    public interface IMarketingRepository
    {
        public Task<double?> GetRevenue(int? organizationId);
        public Task<IEnumerable<ServiceUsageDto>> MostPopularServices(int? organizationId);
        public Task<IEnumerable<MostPopularCarsDTO>> MostPopularCars(int? organizationId);
        Task<Dictionary<DayOfWeek, int>> GetBusiestDays(int? organizationId);
        Task<ClientStatisticsDto> GetClientStatistics(int? organizationId); // Новый метод
    }
}
