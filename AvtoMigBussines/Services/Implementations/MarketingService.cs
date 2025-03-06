using AvtoMigBussines.DTOModels;
using AvtoMigBussines.Repositories.Interfaces;
using AvtoMigBussines.Services.Interfaces;

namespace AvtoMigBussines.Services.Implementations
{
    public class MarketingService : IMarketingService
    {
        private readonly IMarketingRepository marketingRepostiory;

        public MarketingService(IMarketingRepository marketingRepostiory)
        {
            this.marketingRepostiory = marketingRepostiory;
        }
        public async Task<Dictionary<DayOfWeek, int>> GetBusiestDays(int? organizationId)
        {
            return await marketingRepostiory.GetBusiestDays(organizationId);
        }

        public Task<ClientStatisticsDto> GetClientStatistics(int? organizationId)
        {
            return marketingRepostiory.GetClientStatistics(organizationId);
        }

        public async Task<double?> GetRevenue(int? organizationId)
        {
            return await marketingRepostiory.GetRevenue(organizationId);
        }
        public async Task<IEnumerable<MostPopularCarsDTO>> MostPopularCars(int? organizatonId)
        {
            return await marketingRepostiory.MostPopularCars(organizatonId);
        }

        public async Task<IEnumerable<ServiceUsageDto>> MostPopularServices(int? organizatonId)
        {
            return await marketingRepostiory.MostPopularServices(organizatonId);
        }
    }
}
