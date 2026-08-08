using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

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
    /// Classe responsável por NotificationPlatformServiceFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class NotificationPlatformServiceFactory : INotificationPlatformServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Método NotificationPlatformServiceFactory: executa a operação NotificationPlatformServiceFactory.
        /// </summary>
        public NotificationPlatformServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Método GetService: consulta e retorna dados.
        /// </summary>
        public SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification.INotificationPlatformService GetService(SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType serviceType)
        {
            return serviceType switch
            {
                SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType.Email => _serviceProvider.GetRequiredService<IEmailService>(),
                SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType.Sms => _serviceProvider.GetRequiredService<ISmsService>(),
                SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType.WhatsApp => _serviceProvider.GetRequiredService<IWhatsAppService>(),
                _ => throw new ArgumentException("Invalid service type", nameof(serviceType))
            };
        }
    }
}
