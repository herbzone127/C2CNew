using C2CClient.MMViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using C2CClient.CHS_WeatherPortTypeService;
namespace C2CClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static IServiceProvider ServiceProvider { get; set; }
        void SetupServices()
        {
            var services = new ServiceCollection();
            //addPlatformServices?.Invoke(services);
            // TODO: Add core services here
            services.AddSingleton<MainWindow>();
            /*---------------------------------------------------------------*/
            //ViewModels 
            /*---------------------------------------------------------------*/
            services.AddTransient<MotorwayMainViewModel>();
            services.AddTransient<MMWeatherViewModel>();

            /*---------------------------------------------------------------*/
            //ViewModels 
            /*---------------------------------------------------------------*/

            /*---------------------------------------------------------------*/
            //Api Services 
            /*---------------------------------------------------------------*/

            services.AddScoped<WeatherPortType_v0p1, WeatherPortType_v0p1Client>();

            /*---------------------------------------------------------------*/
            //Api Services 
            /*---------------------------------------------------------------*/
            //services.AddTransient<SecondPageVM>();
            //        services.AddSingleton<INetworkStore>(x =>
            //ActivatorUtilities.CreateInstance<Database>(x, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "networkstore.db3")));
            ServiceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            SetupServices();
            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
