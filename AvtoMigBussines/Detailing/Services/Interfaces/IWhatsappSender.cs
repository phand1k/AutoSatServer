using AvtoMigBussines.Models;

namespace AvtoMigBussines.Detailing.Services.Interfaces
{
    public interface IWhatsappSender
    {
        public Task SendReadyWhatsapp(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber);
        public Task SendCreateWhatsapp(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber);

        public Task MarketingSendMessagesToClients(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber, string? message);
        public Task SendTestMessage(string? phoneNumber, string? message);
    }
}
