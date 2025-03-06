using AvtoMigBussines.Data;
using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Models;
using AvtoMigBussines.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AvtoMigBussines.Repositories.Implementations
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext context;
        public ReportRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<int> GetAllNotReadyDetailingOrdersAsync(int? organizationId)
        {
            int countNotReadyDetailingOrders = await context.DetailingOrders.Where(x=>x.IsDeleted == false && x.IsOvered == false).Where(x => x.IsReturn == false && x.OrganizationId == organizationId).CountAsync();
            return countNotReadyDetailingOrders;
        }

        public async Task<int> GetAllServicesForNotReadyDetailingOrdersAsync(int? organizationId)
        {
            int countServicesForNotReadyDetailingOrders = await context.DetailingServices.Include(x=>x.DetailingOrder).Where(x=>x.DetailingOrder.IsOvered == false).Where(x=>x.IsDeleted == false && x.OrganizationId == organizationId).CountAsync();
            return countServicesForNotReadyDetailingOrders;
        }

        public async Task<double?> GetSumAllServices(int? organizationId)
        {
            double? sum = await context.DetailingServices.Include(x => x.DetailingOrder).
                Where(x => x.DetailingOrder.IsOvered == false).
                Where(x => x.IsDeleted == false && x.OrganizationId == organizationId).Select(x=>x.Price).SumAsync();
            return sum;
        }

        public async Task<IEnumerable<ClientOrganization>> GetAllClients(int? organizationId)
        {
            var clients = await context.ClientOrganizations.Where(x=>x.OrganizationId == organizationId).ToListAsync();
            return clients;
        }
        public async Task CreateClient(ClientOrganization client)
        {
            var checkClient = await context.ClientOrganizations.FirstOrDefaultAsync(x=>x.PhoneNumber == client.PhoneNumber);
            if (checkClient == null)
            {
                await context.ClientOrganizations.AddAsync(client);
                await context.SaveChangesAsync();
            }
        }

    }
}
