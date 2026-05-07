using NotificationApplication.Interfaces;
using NLog;

namespace NotificationApplication.Services
{
    public class PushNotificationService : INotificationService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Send(string message)
        {
            CreatingError();
            MessageBox.Show($"Push уведомление: {message}");
            logger.Debug($"Вывод Push уведомления: {message}");
        }

        private bool CreatingError()
        {
            var random = new Random();

            if (random.Next(4) == 0)
            {
                logger.Fatal("Что-то сломалось (искусственная ошибка)");
                throw new Exception("Искусственная ошибка");
                return true;
            }

            return false;
        }
    }
}
