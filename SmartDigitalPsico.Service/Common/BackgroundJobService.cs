using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Service.Common
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Classe responsável por BackgroundJobService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class BackgroundJobService : IBackgroundJobService
    {
        private readonly INotificationDispatchJobService _notificationDispatchJobService;
        private readonly IAppLogger _logger;
        private const string NotificationDispatchJobService_Name = "NotificationDispatchJobService";

        /// <summary>
        /// Método BackgroundJobService: executa a operação BackgroundJobService.
        /// </summary>
        public BackgroundJobService(INotificationDispatchJobService notificationDispatchJobService, IAppLogger logger)
        {
            _notificationDispatchJobService = notificationDispatchJobService;
            _logger = logger;
        }

        /// <summary>
        /// Método ExecuteNotificationProcessAsync: executa a operação ExecuteNotificationProcessAsync.
        /// </summary>
        public async Task ExecuteNotificationProcessAsync()
        {
            _logger.Information("### {NameProcess} ### - Starting notification processing job...", NotificationDispatchJobService_Name, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            await _notificationDispatchJobService.ProcessPendingNotificationsAsync();
            _logger.Information("### {NameProcess} ### - Notification processing job completed.", NotificationDispatchJobService_Name, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
        }
    }
}
