using Microsoft.Extensions.DependencyInjection;
using Peepy.Ims.Domain.IService;
using Peepy.Ims.Domain.Service;
using System.Windows;

namespace Peepy.Ims
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var main = _serviceProvider.GetRequiredService<MainWindow>();
            main.Show();
        }

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUserService>(provider => new UserService());
            services.AddSingleton<MainWindow>();
        }
    }
}
