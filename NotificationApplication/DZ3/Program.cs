using NotificationApplication.Config;
using Ninject;

namespace NotificationApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            IKernel kernel = new StandardKernel(new NinjectConfigModule());
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain(kernel));
        }
    }
}