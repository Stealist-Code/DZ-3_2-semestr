using NotificationApplication.Interfaces;
using NotificationApplication.Services;
using Ninject.Modules;

namespace NotificationApplication.Config
{
    public class NinjectConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<INotificationService>().To<EmailService>().Named("Email");
            Bind<INotificationService>().To<SmsService>().Named("SMS");
            Bind<INotificationService>().To<PushNotificationService>().Named("Push");
        }
    }
}
