using NotificationApplication.Interfaces;
using Ninject;
using NLog;

namespace NotificationApplication.HelperClasses
{
    public class NotificationServiceNamesProvider
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IKernel kernel;

        public NotificationServiceNamesProvider(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public List<string> GetAllNames()
        {
            var bindings = kernel.GetBindings(typeof(INotificationService));
            logger.Debug("Получена связь сервисов");

            var names = bindings
                .Select(x => x.Metadata.Name)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();
            logger.Debug($"Возврат имен сервисов: {names}");
            return names;
        }

        public INotificationService GetServiceByName(string name)
        {
            var service = kernel.Get<INotificationService>(name);
            logger.Debug($"Возврат сервиса с именем {name}");

            return service;
        }
    }
}
