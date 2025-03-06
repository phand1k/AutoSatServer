using AvtoMigBussines.DTOModels;

namespace AvtoMigBussines.Services.Interfaces
{
    public interface IMarketingService
    {
        public Task<IEnumerable<MostPopularCarsDTO>> MostPopularCars(int? organizationId);
        public Task<IEnumerable<ServiceUsageDto>> MostPopularServices(int? organizationId);
        public Task<double?> GetRevenue(int? organizationId);
        public Task<Dictionary<DayOfWeek, int>> GetBusiestDays(int? organizationId);
        public Task<ClientStatisticsDto> GetClientStatistics(int? organizationId); // Новый метод

    }
}
