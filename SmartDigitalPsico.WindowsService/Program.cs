using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WindowsService.Configure;

namespace SmartDigitalPsico.WindowsService
{
    /// <summary>
    /// Classe responsável por Program.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class Program
    {
        // Nome do serviço sem espaços extras
        private const string AppServiceName = "SmartDigitalPsicoWindowsService";
        /// <summary>
        /// Método Main: executa a operação Main.
        /// </summary>
        public static void Main(string[] args)
        {
            Run(args);
        }

        public static void Run(string[] args, Action<IHost>? hostRunner = null)
        {
            var host = CreateHostBuilder().Build();
            if (args.Contains("--validate-startup", StringComparer.OrdinalIgnoreCase))
            {
                host.Dispose();
                return;
            }

            (hostRunner ?? (currentHost => currentHost.Run()))(host);
        }
        /// <summary>
        /// Optional test hook applied after DI registration so default Run can stop without hanging.
        /// </summary>
        internal static Action<IServiceCollection, HostBuilderContext>? ConfigureServicesForTests { get; set; }

        /// <summary>
        /// Método CreateHostBuilder: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static IHostBuilder CreateHostBuilder(string? environmentName = null)
        {
            var builder = Host.CreateDefaultBuilder();
            if (!string.IsNullOrWhiteSpace(environmentName))
            {
                builder.UseEnvironment(environmentName);
            }

            return builder
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

                    ConfigureServicesForTests?.Invoke(services, hostContext);
                })
                .UseWindowsService()
                .UseSerilog();
        }
    }
}
