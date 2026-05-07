using NotificationApplication.Interfaces;
using NLog;

namespace NotificationApplication.Services
{
    public class SmsService : INotificationService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Send(string message)
        {
            MessageBox.Show($"SMS уведомление: {message}");
            logger.Debug($"Вывод SMS уведомления: {message}");
        }
    }
}
