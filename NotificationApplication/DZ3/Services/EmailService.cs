using NotificationApplication.Interfaces;
using NLog;

namespace NotificationApplication.Services
{
    public class EmailService : INotificationService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Send(string message)
        {
            MessageBox.Show($"Email уведомление: {message}");
            logger.Debug($"Вывод Email уведомления: {message}");
        }
    }
}
