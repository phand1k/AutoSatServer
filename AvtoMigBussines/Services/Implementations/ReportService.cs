using AvtoMigBussines.Data;
using AvtoMigBussines.Models;
using AvtoMigBussines.Repositories.Interfaces;
using AvtoMigBussines.Services.Interfaces;

namespace AvtoMigBussines.Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository reportRepository;
        public ReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }
        public async Task<int> GetAllNotReadyDetailingOrdersAsync(int? organizationId)
        {
            return await reportRepository.GetAllNotReadyDetailingOrdersAsync(organizationId);
        }

        public async Task<int> GetAllServicesForNotReadyDetailingOrdersAsync(int? organizationId)
        {
            return await reportRepository.GetAllServicesForNotReadyDetailingOrdersAsync(organizationId);
        }

        public async Task<double?> GetSum(int? organizationId)
        {
            return await reportRepository.GetSumAllServices(organizationId);
        }

        public async Task<bool> CreateClient(string? phoneNumber, int? organizationId)
        {
            ClientOrganization clientOrganization = new ClientOrganization();
            clientOrganization.PhoneNumber = phoneNumber;
            clientOrganization.OrganizationId = organizationId;
            await reportRepository.CreateClient(clientOrganization);
            return true;
        }
    }
}
