using AvtoMigBussines.Data;
using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Detailing.Repositories.Interfaces;

namespace AvtoMigBussines.Detailing.Repositories.Implementations
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext context;
        public ClientRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<DetailingOrder>> GetAllClients(int? organizationId)
        {
            return context.DetailingOrders
                .Where(o => o.OrganizationId == organizationId)
                .AsEnumerable()   // Переносим обработку в память
                .DistinctBy(o => o.PhoneNumber) // Убираем дубликаты по номеру телефона
                .ToList();  // Используем ToList() вместо ToListAsync()
        }


    }
}
