using AvtoMigBussines.Detailing.Repositories.Interfaces;
using AvtoMigBussines.Detailing.Services.Interfaces;

namespace AvtoMigBussines.Detailing.Services.Implementations
{
    public class DetailingLiveDashboardService : IDetailingLiveDashboardService
    {
        private readonly IDetailingLiveDashboardRepository detailingLiveDashboardRepository;
        public DetailingLiveDashboardService(IDetailingLiveDashboardRepository detailingLiveDashboardRepository)
        {
            this.detailingLiveDashboardRepository = detailingLiveDashboardRepository;
        }

        public async Task<int> GetCountOfCarsInWork(int? organizationId)
        {
            return await detailingLiveDashboardRepository.GetCountOfCarsInWork(organizationId);
        }

        public async Task<int> GetCountOfServices(int? organizationId)
        {
            return await detailingLiveDashboardRepository.GetCountOfServices(organizationId);
        }

        public async Task<double?> GetSummOfCarsInWork(int? organizationId)
        {
            return await detailingLiveDashboardRepository.GetSummOfCarsInWork(organizationId);
        }

        public async Task<int> GetCountOfReadyCars(int? organizationId)
        {
            return await detailingLiveDashboardRepository.GetCountOfReadyCars(organizationId);
        }
        public async Task<int> GetCountOfNotReadyCars(int? organizationId)
        {
            return await detailingLiveDashboardRepository.GetCountOfNotReadyCars(organizationId);
        }
    }
}
