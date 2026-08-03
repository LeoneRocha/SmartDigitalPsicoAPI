using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
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
        public INotificationPlatformService GetService(ENotificationServiceType serviceType)
        {
            return serviceType switch
            {
                ENotificationServiceType.Email => _serviceProvider.GetRequiredService<IEmailService>(),
                ENotificationServiceType.Sms => _serviceProvider.GetRequiredService<ISmsService>(),
                ENotificationServiceType.WhatsApp => _serviceProvider.GetRequiredService<IWhatsAppService>(),
                _ => throw new ArgumentException("Invalid service type", nameof(serviceType))
            };
        }
    }
}
