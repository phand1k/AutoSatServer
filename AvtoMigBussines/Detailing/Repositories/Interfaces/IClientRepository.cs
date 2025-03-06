using AvtoMigBussines.Detailing.Models;

namespace AvtoMigBussines.Detailing.Repositories.Interfaces
{
    public interface IClientRepository
    {
        public Task<List<DetailingOrder>> GetAllClients(int? organizationId);
    }
}
