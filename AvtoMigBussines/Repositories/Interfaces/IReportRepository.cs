using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Models;

namespace AvtoMigBussines.Repositories.Interfaces
{
    public interface IReportRepository
    {
        Task<int> GetAllServicesForNotReadyDetailingOrdersAsync(int? organizationId);
        Task<int> GetAllNotReadyDetailingOrdersAsync(int? organizationId);
        Task<double?> GetSumAllServices(int? organizationId);
        Task<IEnumerable<ClientOrganization>> GetAllClients(int? organizationId);
        Task CreateClient(ClientOrganization client);
        
    }
}
