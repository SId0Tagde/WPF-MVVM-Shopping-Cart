using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;


namespace ShoppingCart
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Private Variables.
        private readonly IServiceProvider _serviceProvider;
        #endregion

        #region Constructor.
        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        #endregion

        #region Private Methods.
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<ProductViewModel>();
        }
        #endregion

        #region Public Methods.
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
        #endregion

    }

}
