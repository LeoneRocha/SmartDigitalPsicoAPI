using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.Helpers;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.WebJob
{
    /// <summary>
    /// Classe responsável por ContinuousJobHostedService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ContinuousJobHostedService : BackgroundService
    {
        private readonly IAppLogger _logger;
        private readonly IBackgroundJobService _jobService;
        private readonly IConfiguration _configuration;
        private const string SystemName = "SmartDigitalPsico.WebJob";

        /// <summary>
        /// Método ContinuousJobHostedService: executa a operação ContinuousJobHostedService.
        /// </summary>
        public ContinuousJobHostedService(IBackgroundJobService jobService, IAppLogger logger, IConfiguration configuration)
        {
            _jobService = jobService;
            _logger = logger;
            _configuration = configuration;
        }

        /// <summary>
        /// Método StartAsync: executa a operação StartAsync.
        /// </summary>
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "WebJob [START] -> {SystemName} - StartAsync", SystemName);
            LogAppHelper.PrintLogInformationVersionProduct(_logger);
            return base.StartAsync(cancellationToken);
        }

        /// <summary>
        /// Método StopAsync: executa a operação StopAsync.
        /// </summary>
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "WebJob [STOP] -> {SystemName} - StopAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        /// <summary>
        /// Método ExecuteAsync: executa a operação ExecuteAsync.
        /// </summary>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int delayMinutes = _configuration.GetValue("JobSettings:TaskDelayMinutes", 1);
            LogAppHelper.LogInfo(_logger, "ContinuousJobHostedService iniciado às: {time} / started at: {time}", SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    LogAppHelper.LogInfo(_logger, "Iniciando execução do trabalho em: {time} / Starting job execution at: {time}", SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
                    await _jobService.ExecuteNotificationProcessAsync();
                    LogAppHelper.LogInfo(_logger, "Trabalho concluído em: {time} / Job execution completed at: {time}", SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
                }
                catch (Exception ex)
                {
                    LogAppHelper.LogError(_logger, ex, "Erro ao executar o trabalho em: {time} / Error executing job at: {time}", SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
                }
                await DelayAsync(TimeSpan.FromMinutes(delayMinutes), stoppingToken);
            }

            LogAppHelper.LogInfo(_logger, "ContinuousJobHostedService finalizado às: {time} / Stopping at: {time}", SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
        }

        protected virtual Task DelayAsync(TimeSpan delay, CancellationToken stoppingToken)
        {
            return Task.Delay(delay, stoppingToken);
        }
    }
}
