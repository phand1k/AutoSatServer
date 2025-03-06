using AvtoMigBussines.Detailing.Models;

namespace AvtoMigBussines.Services.Interfaces
{
    public interface ILoyaltyService
    {
        public Task SendMessage(int? organizationId, List<DetailingOrder> clients);
        public Task MarketingSendMessage(int? organizationId, List<DetailingOrder> clients, string? message);
        public Task Test(string? phoneNumber, string? message);
    }
}
