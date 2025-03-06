using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Detailing.Services.Interfaces;
using AvtoMigBussines.Models;
using System.Net;
using System.Text;
using System.Text.Json;
using Telegram.Bot.Types;

namespace AvtoMigBussines.Detailing.Services.Implementations
{
    public class WhatsappSenderService : IWhatsappSender
    {

        private readonly HttpClient _httpClient;

        public WhatsappSenderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SendTestMessage(string? phoneNumber, string? message)
        {
            WhatsappSender whatsappSender = new WhatsappSender();
            whatsappSender.session = "default";
            whatsappSender.text = message;
            whatsappSender.linkPreview = true;
            whatsappSender.chatId = phoneNumber + "@c.us";
            string url = "http://172.22.0.3:3000/api/sendText"; // Используем имя контейнера
            var httpClientHandler = new HttpClientHandler
            {
                UseProxy = true,
                Proxy = new WebProxy("http://172.22.0.3:3000")
            };

            var httpClient = new HttpClient(httpClientHandler);
            var json = JsonSerializer.Serialize(whatsappSender, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            Console.WriteLine($"Отправляемый JSON: {json}");  // ✅ Выводит JSON в консоль

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Ответ от WAHA: {responseString}");  // ✅ Вывод ответа
            Console.WriteLine($"Статус код: {(int)response.StatusCode} {response.ReasonPhrase}");
            Console.WriteLine($"Ответ от WAHA: {responseString}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Ошибка при отправке WhatsApp-сообщения: {response.StatusCode}, {responseString}");
            }
        }

        public async Task MarketingSendMessagesToClients(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber, string? message)
        {
            whatsappSender.session = "default";
            whatsappSender.text = message;
            whatsappSender.linkPreview = true;
            whatsappSender.chatId = phoneNumber + "@c.us";
            string url = "http://172.22.0.3:3000/api/sendText";
            var httpClientHandler = new HttpClientHandler
            {
                UseProxy = true,
                Proxy = new WebProxy("http://172.22.0.3:3000")
            };
            var httpClient = new HttpClient(httpClientHandler);
            var json = JsonSerializer.Serialize(whatsappSender, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            Console.WriteLine($"Отправляемый JSON: {json}");  // ✅ Выводит JSON в консоль

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Ответ от WAHA: {responseString}");  // ✅ Вывод ответа
            Console.WriteLine($"Статус код: {(int)response.StatusCode} {response.ReasonPhrase}");
            Console.WriteLine($"Ответ от WAHA: {responseString}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Ошибка при отправке WhatsApp-сообщения: {response.StatusCode}, {responseString}");
            }
        }

        public async Task SendReadyWhatsapp(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber)
        {
            whatsappSender.session = "default";
            whatsappSender.text = $"Здравствуйте👋, ваша машина с гос. номером {carNumber} готова. Ответьте 1, чтобы получать сообщения. \n\nСәлеметсіз бе👋, сіздің көлігіңіз {carNumber} нөмірімен дайын. Хабарламаларды алу үшін 1 деп жауап беріңіз.";
            whatsappSender.linkPreview = true;
            whatsappSender.chatId = phoneNumber + "@c.us";
            string url = "http://172.22.0.3:3000/api/sendText";

            var json = JsonSerializer.Serialize(whatsappSender, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            Console.WriteLine($"Отправляемый JSON: {json}");  // ✅ Выводит JSON в консоль

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Ответ от WAHA: {responseString}");  // ✅ Вывод ответа

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Ошибка при отправке WhatsApp-сообщения: {response.StatusCode}, {responseString}");
            }
        }
        public async Task SendCreateWhatsapp(WhatsappSender whatsappSender, string? phoneNumber, string? carNumber)
        {
            whatsappSender.session = "default";
            whatsappSender.text = $"Здравствуйте👋, ваша машина с гос. номером {carNumber} принята на детейлинг. Будем держать вас в курсе работы. Ответьте 1, чтобы получать сообщения. \n\nСәлеметсіз бе👋, сіздің көлігіңіз {carNumber} нөмірімен детейлингке қабылданды. Жұмыс барысын хабарлап отырамыз. Хабарламаларды алу үшін 1 деп жауап беріңіз.";
            whatsappSender.linkPreview = true;
            whatsappSender.chatId = phoneNumber + "@c.us";
            string url = "http://172.22.0.3:3000/api/sendText";

            var json = JsonSerializer.Serialize(whatsappSender, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            Console.WriteLine($"Отправляемый JSON: {json}");  // ✅ Выводит JSON в консоль

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Статус код: {(int)response.StatusCode} {response.ReasonPhrase}");
            Console.WriteLine($"Ответ от WAHA: {responseString}");

            Console.WriteLine($"Ответ от WAHA: {responseString}");  // ✅ Вывод ответа

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Ошибка при отправке WhatsApp-сообщения: {response.StatusCode}, {responseString}");
            }
        }

    }
}
