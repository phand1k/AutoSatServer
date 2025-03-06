using AvtoMigBussines.Models;

namespace AvtoMigBussines.Services.Interfaces
{
    public interface IReportService
    {
        Task<int> GetAllNotReadyDetailingOrdersAsync(int? organizationId);
        Task<int> GetAllServicesForNotReadyDetailingOrdersAsync(int? organizationId);
        Task<double?> GetSum(int? organizationId);
        Task<bool> CreateClient(string? phoneNumber, int? organizationId);
    }
}
