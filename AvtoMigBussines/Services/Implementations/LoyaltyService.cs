using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Detailing.Repositories.Interfaces;
using AvtoMigBussines.Detailing.Services.Interfaces;
using AvtoMigBussines.Models;
using AvtoMigBussines.Services.Interfaces;

namespace AvtoMigBussines.Services.Implementations
{
    public class LoyaltyService : ILoyaltyService
    {
        private readonly IWhatsappSender whatsapp;
        private readonly IClientRepository clientRepository;
        public LoyaltyService(IClientRepository clientRepository, IWhatsappSender whatsapp)
        {
            this.clientRepository = clientRepository;
            this.whatsapp = whatsapp;
        }

        public async Task Test(string? phoneNumber, string? message)
        {
            await whatsapp.SendTestMessage(phoneNumber, message);
        }   

        public async Task MarketingSendMessage(int? organizationId, List<DetailingOrder> clients, string? message)
        {
            var needNumbers = await clientRepository.GetAllClients(organizationId);

            WhatsappSender whatsappSender = new WhatsappSender();
            foreach (var item in clients)
            {
                await whatsapp.MarketingSendMessagesToClients(whatsappSender, item.PhoneNumber, item.CarNumber, message);
            }

        }

        public async Task SendMessage(int? organizationId, List<DetailingOrder> clients)
        {
            var needNumbers = await clientRepository.GetAllClients(organizationId);

            WhatsappSender whatsappSender = new WhatsappSender();
            foreach (var item in clients)
            {
                await whatsapp.SendCreateWhatsapp(whatsappSender, item.PhoneNumber, item.CarNumber);
            }
        }
    }
}
