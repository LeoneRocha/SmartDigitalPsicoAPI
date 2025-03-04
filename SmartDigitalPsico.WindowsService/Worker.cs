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
            _logger.Information("Service [START] -> {SystemName} - StartAsync", SystemName);
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Service [STOP] -> {SystemName} - StopAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Utiliza o método GetValue para obter o delay configurado com um valor default de 1 minuto
            int minutesDelay = _configuration.GetValue("TaskDelayMinutes", 1);
            LogAppHelper.PrintLogInformationVersionProduct(_logger);

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.Information("Worker running at: {Time}", DateHelper.GetDateTimeNowToLog());
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
                    _logger.Error(ex, "ExecuteAsync Error: {Message} at: {Time}", ex.Message, DateHelper.GetDateTimeNowToLog());
                }
                // Aguarda o intervalo configurado (em minutos)
                await Task.Delay(TimeSpan.FromMinutes(minutesDelay), stoppingToken);
            }
        }
    }
}