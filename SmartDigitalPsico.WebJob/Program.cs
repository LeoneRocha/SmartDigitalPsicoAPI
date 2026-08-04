using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.WebJob.Configure;

namespace SmartDigitalPsico.WebJob
{
    public static class Program
    {
        private static Serilog.Core.Logger? _logger;

        /// <summary>
        /// Optional test hook applied before Build so hosts can relax DI validation.
        /// </summary>
        internal static Action<IHostBuilder>? ConfigureHostForTests { get; set; }

        public static Task Main(string[] args)
        {
            return RunAsync(args);
        }

        public static async Task RunAsync(string[] args, Func<IHost, Task>? hostRunner = null, string? environmentName = null)
        {
            var builder = new HostBuilder()
                .ConfigureHostConfiguration(config =>
                {
                    config.AddEnvironmentVariables();
                })
                .ConfigureWebJobs(webJobsBuilder =>
                {
                    // Adiciona extensoes especificas para WebJobs, se necessario
                    webJobsBuilder.AddFiles();
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    // Define o arquivo de configuração conforme o ambiente
                    string configFile = env.IsProduction() ? "appsettings.json" : $"appsettings.{env.EnvironmentName}.json";
                    config.AddJsonFile(configFile, optional: !env.IsProduction(), reloadOnChange: true)
                          .AddEnvironmentVariables();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    _logger = LogAppHelper.CreateLogger(hostContext.Configuration);
                    services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(_logger, dispose: true));

                    // Registra as dependencias essenciais para o WebJob
                    WebJobConfigureServiceCollections.Configure(services, hostContext.Configuration, _logger);

                    // Registra o ContinuousJobHostedService se o modo for "Continuous"
                    var executionMode = hostContext.Configuration.GetValue<string>("JobSettings:ExecutionMode", "OneTime");
                    if (executionMode.Equals("Continuous", StringComparison.OrdinalIgnoreCase))
                    {
                        services.AddHostedService<ContinuousJobHostedService>();
                    }
                })
                .ConfigureLogging((context, logging) =>
                {
                    logging.AddConsole();
                });

            // Apply after host configuration so env vars cannot override the explicit test/runtime value.
            if (!string.IsNullOrWhiteSpace(environmentName))
            {
                builder.UseEnvironment(environmentName);
            }

            ConfigureHostForTests?.Invoke(builder);
            var host = builder.UseSerilog().Build();

            using (host)
            {
                if (args.Contains("--validate-startup", StringComparer.OrdinalIgnoreCase))
                {
                    return;
                }

                await (hostRunner ?? (currentHost => RunHostAsync(currentHost)))(host);
            }
        }

        public static async Task RunHostAsync(
            IHost host,
            Func<IHost, Task>? continuousHostRunner = null,
            Serilog.Core.Logger? loggerOverride = null)
        {
            var logger = loggerOverride ?? _logger
                ?? throw new InvalidOperationException("WebJob logger was not configured.");
            var configuration = host.Services.GetRequiredService<IConfiguration>();
            var executionMode = configuration.GetValue<string>("JobSettings:ExecutionMode", "OneTime");

            if (executionMode.Equals("Continuous", StringComparison.OrdinalIgnoreCase))
            {
                // Modo contínuo: o host manterá os serviços rodando.
                LogAppHelper.LogInfo(logger, "Modo contínuo ativado. / Continuous mode activated. Host será mantido em execução.");
                await (continuousHostRunner ?? (currentHost => currentHost.RunAsync()))(host);
            }
            else
            {
                // Modo de execução única: executa o job e finaliza.
                LogAppHelper.PrintLogInformationVersionProduct(logger);
                var jobService = host.Services.GetService<IBackgroundJobService>();
                if (jobService != null)
                {
                    LogAppHelper.LogInfo(logger, "Execução única iniciada. / Single execution started. Chamando ExecuteNotificationProcessAsync...");
                    await jobService.ExecuteNotificationProcessAsync();
                    LogAppHelper.LogInfo(logger, "Execução única concluída. / Single execution completed.");
                }
                else
                {
                    throw new InvalidOperationException("Erro na configuração: IBackgroundJobService não foi registrado. / Configuration error: IBackgroundJobService was not registered.");
                }
            }
        }
    }
}
