using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.WebJob.Configure; // Supondo que IBackgroundJobService esteja aqui.

namespace SmartDigitalPsico.WebJob
{
    static class Program
    {
        private static Serilog.Core.Logger? _logger;

        static async Task Main()
        {
            // Cria o HostBuilder com a configuração do WebJob
            var builder = new HostBuilder()
                .ConfigureWebJobs(webJobsBuilder =>
                {
                    // Adiciona extensões específicas para WebJobs, por exemplo, leitura de arquivos ou integrações
                    webJobsBuilder.AddFiles();
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    // Define o arquivo de configuração conforme o ambiente atual
                    string configFile = env.IsProduction() ? "appsettings.json" : $"appsettings.{env.EnvironmentName}.json";
                    config.AddJsonFile(configFile, optional: !env.IsProduction(), reloadOnChange: true)
                          .AddEnvironmentVariables();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    // Cria e registra o logger personalizado
                    _logger = LogAppHelper.CreateLogger(hostContext.Configuration);
                    services.AddLogging(loggingBuilder =>
                    {
                        loggingBuilder.AddSerilog(_logger, dispose: true);
                    });
                    // Registre as dependências essenciais para o WebJob. Registra os serviços específicos do domínio e do background job
                    WebJobConfigureServiceCollections.Configure(services, hostContext.Configuration, _logger);

                })
                .ConfigureLogging((context, logging) =>
                {
                    logging.AddConsole();
                });

            // Utiliza o Serilog para o host e constrói o Host
            var host = builder
                .UseSerilog()
                .Build();

            using (host)
            {
                // Recupera a instância do serviço de background a ser executado
                var jobService = host.Services.GetRequiredService<IBackgroundJobService>();

                if (jobService != null)
                {
                    _logger?.Information("WebJob iniciado. Chamando ExecuteNotificationProcessAsync...");
                    await jobService.ExecuteNotificationProcessAsync();
                    _logger?.Information("WebJob concluído com sucesso.");
                }
                else
                {
                    throw new InvalidOperationException("Erro na configuração: IBackgroundJobService não foi registrado.");
                }
            }
        }
    }
}
