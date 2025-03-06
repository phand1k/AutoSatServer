namespace AvtoMigBussines.Detailing.Services.Interfaces
{
    public interface IDetailingLiveDashboardService
    {
        public Task<int> GetCountOfCarsInWork(int? organizationId);
        public Task<int> GetCountOfServices(int? organizationId);
        public Task<double?> GetSummOfCarsInWork(int? organizationId);
        public Task<int> GetCountOfReadyCars(int? organizationId);
        public Task<int> GetCountOfNotReadyCars(int? organizationId);
    }
}
