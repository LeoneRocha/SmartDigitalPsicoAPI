using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using Serilog;

namespace SmartDigitalPsico.Service.Bussines
{
    /// <summary>
    /// Classe responsável por BackgroundJobService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class BackgroundJobService : IBackgroundJobService
    {
        private readonly INotificationDispatchJobService _notificationDispatchJobService;
        private readonly ILogger _logger;
        private const string NotificationDispatchJobService_Name = "NotificationDispatchJobService";

        /// <summary>
        /// Método BackgroundJobService: executa a operação BackgroundJobService.
        /// </summary>
        public BackgroundJobService(INotificationDispatchJobService notificationDispatchJobService, ILogger logger)
        {
            _notificationDispatchJobService = notificationDispatchJobService;
            _logger = logger;
        }

        /// <summary>
        /// Método ExecuteNotificationProcessAsync: executa a operação ExecuteNotificationProcessAsync.
        /// </summary>
        public async Task ExecuteNotificationProcessAsync()
        {
            _logger.Information("### {NameProcess} ### - Starting notification processing job...", NotificationDispatchJobService_Name, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            await _notificationDispatchJobService.ProcessPendingNotificationsAsync();
            _logger.Information("### {NameProcess} ### - Notification processing job completed.", NotificationDispatchJobService_Name, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
        }
    }
}
