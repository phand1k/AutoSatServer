using AvtoMigBussines.Data;
using AvtoMigBussines.Detailing.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AvtoMigBussines.Detailing.Repositories.Implementations
{
    public class DetailingLiveDashboardRepository : IDetailingLiveDashboardRepository
    {
        private readonly ApplicationDbContext context;
        public DetailingLiveDashboardRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> GetCountOfCarsInWork(int? organizationId)
        {
            return await context.DetailingOrders.
                Where(x=>x.IsOvered == false && x.IsDeleted == false).Where(x=>x.OrganizationId == organizationId).CountAsync();
        }

        public async Task<int> GetCountOfServices(int? organizationId)
        {
            return await context.DetailingServices.
                Include(x=>x.DetailingOrder).Where(x=>x.IsDeleted == false).Where(x=>x.IsOvered == false && x.DetailingOrder.IsDeleted == false).
                Where(x=>x.DetailingOrder.IsOvered == false && x.DetailingOrder.OrganizationId == organizationId).
                CountAsync();
        }

        public async Task<double?> GetSummOfCarsInWork(int? organizationId)
        {
            return await context.DetailingServices.
                Include(x => x.DetailingOrder).Where(x => x.IsDeleted == false).Where(x => x.IsOvered == false && x.DetailingOrder.IsDeleted == false).
                Where(x => x.DetailingOrder.IsOvered == false && x.DetailingOrder.OrganizationId == organizationId).Select(x => x.Price).SumAsync();
        }

        public async Task<int> GetCountOfReadyCars(int? organizationId)
        {
            return await context.DetailingOrders.
                Where(x => x.IsDeleted == false && x.OrganizationId == organizationId).Where(x => x.IsOvered == false && x.IsReady == true).
               CountAsync();
        }

        public async Task<int> GetCountOfNotReadyCars(int? organizationId)
        {
            return await context.DetailingOrders.
                Where(x => x.IsDeleted == false && x.OrganizationId == organizationId).Where(x => x.IsOvered == false && x.IsReady == false).
               CountAsync();
        }
    }
}
