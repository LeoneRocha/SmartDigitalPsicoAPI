using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using DateHelper = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper;

namespace SmartDigitalPsico.WindowsService
{
    /// <summary>
    /// Classe responsável por Worker.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class Worker : BackgroundService
    {
        private const string SystemName = "SmartDigitalPsico.WindowsService";
        private readonly Serilog.ILogger _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Método Worker: executa a operação Worker.
        /// </summary>
        public Worker(Serilog.ILogger logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            // Caso o logger seja nulo, cria a partir da configuração
            _logger = logger ?? LogAppHelper.CreateLogger(configuration);
            _configuration = configuration;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Método StartAsync: executa a operação StartAsync.
        /// </summary>
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "Service [START] -> {SystemName} - StartAsync", SystemName);
            LogAppHelper.PrintLogInformationVersionProduct(_logger);
            return base.StartAsync(cancellationToken);
        }

        /// <summary>
        /// Método StopAsync: executa a operação StopAsync.
        /// </summary>
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "Service [STOP] -> {SystemName} - StopAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        /// <summary>
        /// Método ExecuteAsync: executa a operação ExecuteAsync.
        /// </summary>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var minutesDelay = _configuration.GetValue("TaskDelayMinutes", 1);
            while (!stoppingToken.IsCancellationRequested)
            {
                LogAppHelper.LogInfo(_logger, "Worker running at: {Time}", DateHelper.GetDateTimeNowToLog());
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var backgroundJobService = scope.ServiceProvider.GetRequiredService<IBackgroundJobService>();
                        await backgroundJobService.ExecuteNotificationProcessAsync();
                    }
                }
                catch (Exception ex)
                {
                    LogAppHelper.LogError(_logger, ex, "ExecuteAsync Error: {Message} at: {Time}", ex.Message, DateHelper.GetDateTimeNowToLog());
                }

                await DelayAsync(TimeSpan.FromMinutes(minutesDelay), stoppingToken);
            }
        }

        protected virtual Task DelayAsync(TimeSpan delay, CancellationToken stoppingToken)
        {
            return Task.Delay(delay, stoppingToken);
        }
    }
}
