using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WindowsService.Configure;

namespace SmartDigitalPsico.WindowsService
{
    public static class Program
    {
        // Nome do servi�o sem espa�os extras
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

                    // Seta o ambiente para o LogAppHelper, se necess�rio (implementa��o customizada)
                    LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(hostingContext.Configuration);

                    // Carrega o arquivo de configura��o conforme o Ambiente
                    string configFile = env.IsProduction() ? "appsettings.json" : $"appsettings.{env.EnvironmentName}.json";
                    config.AddJsonFile(configFile, optional: !env.IsProduction(), reloadOnChange: true)
                          .AddEnvironmentVariables();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    // Cria a inst�ncia do logger a partir da configura��o e registra no container
                    var logger = LogAppHelper.CreateLogger(hostContext.Configuration);
                    services.AddLogging();
                    logger.Information("Config Environment: {EnvironmentName}", hostContext.HostingEnvironment.EnvironmentName);

                    // Configura o servi�o do Windows
                    services.AddWindowsService(options => options.ServiceName = AppServiceName);

                    // Registra o Worker como HostedService
                    services.AddHostedService<Worker>();

                    // Registra os servi�os espec�ficos do dom�nio e do background job
                    WindowsServiceConfigureServiceCollections.Configure(services, hostContext.Configuration, logger);
                })
                .UseWindowsService()
                .UseSerilog();
        }
    }
}