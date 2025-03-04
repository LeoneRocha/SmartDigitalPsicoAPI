using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WindowsService.Configure;

namespace SmartDigitalPsico.WindowsService
{
    public static class Program
    {
        // Nome do serviço sem espaços extras
        private const string AppServiceName = "SmartDigitalPsicoWindowsService";
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;

                    // Seta o ambiente para o LogAppHelper, se necessário (implementação customizada)
                    LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(hostingContext.Configuration);

                    // Carrega o arquivo de configuração conforme o Ambiente
                    string configFile = env.IsProduction() ? "appsettings.json" : $"appsettings.{env.EnvironmentName}.json";
                    config.AddJsonFile(configFile, optional: !env.IsProduction(), reloadOnChange: true)
                          .AddEnvironmentVariables();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    // Cria a instância do logger a partir da configuração e registra no container
                    var logger = LogAppHelper.CreateLogger(hostContext.Configuration);
                    services.AddLogging();
                    logger.Information("Config Environment: {EnvironmentName}", hostContext.HostingEnvironment.EnvironmentName);

                    // Configura o serviço do Windows
                    services.AddWindowsService(options => options.ServiceName = AppServiceName);

                    // Registra o Worker como HostedService
                    services.AddHostedService<Worker>();

                    // Registra os serviços específicos do domínio e do background job
                    WindowsServiceConfigureServiceCollections.Configure(services, hostContext.Configuration, logger);
                })
                .UseWindowsService()
                .UseSerilog();
        }
    }
}