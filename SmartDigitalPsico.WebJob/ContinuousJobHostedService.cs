using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.WebJob
{
    public class ContinuousJobHostedService : BackgroundService
    {
        private readonly Serilog.ILogger _logger;
        private readonly IBackgroundJobService _jobService;
        private readonly IConfiguration _configuration;
        private const string SystemName = "SmartDigitalPsico.WebJob";

        public ContinuousJobHostedService(IBackgroundJobService jobService, Serilog.ILogger logger, IConfiguration configuration)
        {
            _jobService = jobService;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "WebJob [START] -> {SystemName} - StartAsync", SystemName);
            LogAppHelper.PrintLogInformationVersionProduct(_logger);
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "WebJob [STOP] -> {SystemName} - StopAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int delayMinutes = _configuration.GetValue("JobSettings:TaskDelayMinutes", 1);
            LogAppHelper.LogInfo(_logger, "ContinuousJobHostedService iniciado às: {time} / started at: {time}", DateHelper.GetDateTimeNowToLog());

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    LogAppHelper.LogInfo(_logger, "Iniciando execução do trabalho em: {time} / Starting job execution at: {time}", DateHelper.GetDateTimeNowToLog());
                    await _jobService.ExecuteNotificationProcessAsync();
                    LogAppHelper.LogInfo(_logger, "Trabalho concluído em: {time} / Job execution completed at: {time}", DateHelper.GetDateTimeNowToLog());
                }
                catch (Exception ex)
                {
                    LogAppHelper.LogError(_logger, ex, "Erro ao executar o trabalho em: {time} / Error executing job at: {time}", DateHelper.GetDateTimeNowToLog());
                }
                await Task.Delay(TimeSpan.FromMinutes(delayMinutes), stoppingToken);
            }

            LogAppHelper.LogInfo(_logger, "ContinuousJobHostedService finalizado às: {time} / Stopping at: {time}", DateHelper.GetDateTimeNowToLog());
        }
    }
}