using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using Serilog;

namespace SmartDigitalPsico.Service.Bussines
{
    public class BackgroundJobService : IBackgroundJobService
    {
        private readonly INotificationDispatchJobService _notificationDispatchJobService;
        private readonly ILogger _logger;
        private const string NotificationDispatchJobService_Name = "NotificationDispatchJobService";

        public BackgroundJobService(INotificationDispatchJobService notificationDispatchJobService, ILogger logger)
        {
            _notificationDispatchJobService = notificationDispatchJobService;
            _logger = logger;
        }

        public async Task ExecuteNotificationProcessAsync()
        {
            _logger.Information("### {NameProcess} ### - Starting notification processing job...", NotificationDispatchJobService_Name, DateHelper.GetDateTimeNowToLog());
            await _notificationDispatchJobService.ProcessPendingNotificationsAsync();
            _logger.Information("### {NameProcess} ### - Notification processing job completed.", NotificationDispatchJobService_Name, DateHelper.GetDateTimeNowToLog());
        }
    }
}
