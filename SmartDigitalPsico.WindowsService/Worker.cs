using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.WindowsService
{  
    public class Worker : BackgroundService
    {
        private const string SystemName = "SmartDigitalPsico.WindowsService";

        private readonly Serilog.ILogger _logger;

        public readonly IServiceProvider _serviceProvider;
        public readonly IConfiguration _configuration;
        public Worker(Serilog.ILogger logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _logger = logger ?? LogAppHelper.CreateLogger(configuration);
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Serviço [START] -> {SystemName}- StartAsync", SystemName);

            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Serviço [STOP] -> {SystemName}- StartAsync", SystemName);
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int minutesDelay;
            LogAppHelper.PrintLogInformationVersionProduct(_logger);
            if (!int.TryParse(_configuration.GetSection("TaskDelayMinutes").Value, out minutesDelay))
            {
                minutesDelay = 1;
            }
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(Serilog.Events.LogEventLevel.Information))
                {
                    _logger.Information("Worker running at: {time}", DateHelper.GetDateTimeNowToLog());
                }
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var backgroundJobService = scope.ServiceProvider.GetRequiredService<IBackgroundJobService>();

                        if (backgroundJobService != null)
                        {
                            await backgroundJobService.ExecuteNotificationProcessAsync();
                        }
                        else
                        {
                            _logger.Error("ExecuteAsync Error: No load IBackgroundJobService  at: {time}", DateHelper.GetDateTimeNowToLog());
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "ExecuteAsync Error: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
                }
                await Task.Delay(minutesDelay * 60000, stoppingToken);
            }
        }
    }
} 