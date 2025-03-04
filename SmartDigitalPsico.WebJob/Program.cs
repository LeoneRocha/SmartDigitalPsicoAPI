using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.WebJob.Configure;

namespace SmartDigitalPsico.WebJob
{
    static class Program
    {
        private static Serilog.Core.Logger? _logger;

        static async Task Main()
        {
            var builder = new HostBuilder()
                .ConfigureWebJobs(webJobsBuilder =>
                {
                    // Adiciona extensoes especificas para WebJobs, se necessario
                    webJobsBuilder.AddFiles();
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    // Define o arquivo de configuracao conforme o ambiente
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

            var host = builder.UseSerilog().Build();

            using (host)
            {
                var configuration = host.Services.GetRequiredService<IConfiguration>();
                var executionMode = configuration.GetValue<string>("JobSettings:ExecutionMode", "OneTime");

                if (executionMode.Equals("Continuous", StringComparison.OrdinalIgnoreCase))
                {
                    // Modo contínuo: o host manterá os serviços rodando.
                    LogAppHelper.LogInfo(_logger!, "Modo contínuo ativado. / Continuous mode activated. Host será mantido em execução.");
                    await host.RunAsync();
                }
                else
                {
                    // Modo de execução única: executa o job e finaliza.
                    LogAppHelper.PrintLogInformationVersionProduct(_logger!);
                    var jobService = host.Services.GetRequiredService<IBackgroundJobService>();
                    if (jobService != null)
                    {
                        LogAppHelper.LogInfo(_logger!, "Execução única iniciada. / Single execution started. Chamando ExecuteNotificationProcessAsync...");
                        await jobService.ExecuteNotificationProcessAsync();
                        LogAppHelper.LogInfo(_logger!, "Execução única concluída. / Single execution completed.");
                    }
                    else
                    {
                        throw new InvalidOperationException("Erro na configuração: IBackgroundJobService não foi registrado. / Configuration error: IBackgroundJobService was not registered.");
                    }
                }
            }
        }
    }
}