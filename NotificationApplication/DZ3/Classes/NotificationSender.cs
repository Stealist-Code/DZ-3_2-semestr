using NotificationApplication.Interfaces;
using NLog;

namespace NotificationApplication.Classes
{
    public class NotificationSender
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private INotificationService notificationService {  get; set; }

        public NotificationSender(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void Send(string message)
        {
            notificationService.Send(message);
        }
    }
}
