using System.Threading.Channels;

namespace AvtoMigBussines.Services.Implementations
{
    public class NotificationBackgroundService : BackgroundService
    {
        private readonly Channel<(string Token, string Title, string Message, object Data)> _notificationChannel = Channel.CreateUnbounded<(string, string, string, object)>();

        public async Task QueueNotificationAsync(string token, string title, string message, object data)
        {
            await _notificationChannel.Writer.WriteAsync((token, title, message, data));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await foreach (var (token, title, message, data) in _notificationChannel.Reader.ReadAllAsync(stoppingToken))
            {
                try
                {
                    await SendPushNotification(token, title, message, data);
                }
                catch (Exception ex)
                {
                    // Логирование ошибки отправки уведомления
                    Console.WriteLine($"Error sending notification: {ex.Message}");
                }
            }
        }

        private async Task SendPushNotification(string token, string title, string message, object data)
        {
            // Реализация отправки push-уведомления
            await Task.Delay(100); // Симуляция отправки
            Console.WriteLine($"Notification sent to {token}: {title}");
        }
    }

}
