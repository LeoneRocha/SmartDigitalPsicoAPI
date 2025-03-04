using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.WindowsService
{
    public class Worker : BackgroundService
    {
        private const string SystemName = "SmartDigitalPsico.WindowsService";
        private readonly Serilog.ILogger _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        public Worker(Serilog.ILogger logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            // Caso o logger seja nulo, crie um novo a partir da configuração
            _logger = logger ?? LogAppHelper.CreateLogger(configuration);
            _configuration = configuration;
            _serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "Service [START] -> {SystemName} - StartAsync", SystemName);
            LogAppHelper.PrintLogInformationVersionProduct(_logger);
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            LogAppHelper.LogInfo(_logger, "Service [STOP] -> {SystemName} - StopAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Utiliza o método GetValue para obter o delay configurado com um valor default de 1 minuto
            int minutesDelay = _configuration.GetValue("TaskDelayMinutes", 1);
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
                // Aguarda o intervalo configurado (em minutos)
                await Task.Delay(TimeSpan.FromMinutes(minutesDelay), stoppingToken);
            }
        }
    }
}