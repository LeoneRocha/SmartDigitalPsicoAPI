using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class NotificationPlatformServiceFactory : INotificationPlatformServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationPlatformServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

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
