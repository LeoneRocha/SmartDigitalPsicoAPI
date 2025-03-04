using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WindowsService.Configure;

namespace SmartDigitalPsico.WindowsService
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args).Build().Run();
    //    }

    //    public static IHostBuilder CreateHostBuilder(string[] args) =>
    //        Host.CreateDefaultBuilder(args)
    //            .ConfigureServices((hostContext, services) =>
    //            {
    //                services.AddHostedService<Worker>();
    //            })
    //            .UseWindowsService(); // Adiciona o serviço ao Windows Service
    //} 
    public static class Program
    {
        private const string AppServiceName = "My Service  ";
        private static Serilog.Core.Logger? _logger;
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(hostingContext.Configuration);
                var env = hostingContext.HostingEnvironment;
                
                if (env.IsProduction())
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                }
                else
                {
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                }
                config.AddEnvironmentVariables();
            })
            .ConfigureServices((hostContext, services) =>
            {
                _logger = LogAppHelper.CreateLogger(hostContext.Configuration);                 
                services.AddLogging(); 
                _logger?.Information($"Config Environment: {hostContext.HostingEnvironment.EnvironmentName} ");                  
                services.AddWindowsService(options => { options.ServiceName = AppServiceName; });
                services.AddSingleton<IHostedService, Worker>();
                //services.AddScoped<IMyProjectServiceUpload, MyProjectServiceUpload>();
                 
                //Service Collections.
                WindowsServiceConfigureServiceCollections.Configure(services, hostContext.Configuration, _logger!);               
            })
            .UseWindowsService()
            .UseSerilog();
        }
    }
} 