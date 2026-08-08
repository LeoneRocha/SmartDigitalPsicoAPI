using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Service.Infrastructure.Notification
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
    /// Classe responsável por SendNotificationService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class SendNotificationService : ISendNotificationService
    {
        private readonly INotificationPlatformServiceFactory _notificationServiceFactory;

        /// <summary>
        /// Método SendNotificationService: dispara notificação ou comunicação.
        /// </summary>
        public SendNotificationService(INotificationPlatformServiceFactory notificationServiceFactory)
        {
            _notificationServiceFactory = notificationServiceFactory;
        }

        /// <summary>
        /// Método SendNotificationAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendNotificationAsync(DataNotificationTemplateVO template, ENotificationServiceType serviceType, Dictionary<string, string> tokens)
        {
            var service = _notificationServiceFactory.GetService(serviceType);
            await service.SendAsync(template, tokens);
        }
    }
}
