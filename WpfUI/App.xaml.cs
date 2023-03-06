using Serilog;
using Microsoft.Extensions.Hosting;
using Application;
using Infrastructure;
using Microsoft.Extensions.Logging;
using Presentation;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder()
                //Adding registered dependencies from all layers
                .ConfigureServices(serviceCollection =>
                {
                    serviceCollection.AddApplication();
                    serviceCollection.AddInfrastructure();
                    serviceCollection.AddPresentation();
                })
                //Logging confuguration
                .ConfigureLogging(logging =>
                {
                    logging.AddSerilog();
                    logging.SetMinimumLevel(LogLevel.Information);
                })
                .UseSerilog()
                .Build();
        }
    }
}