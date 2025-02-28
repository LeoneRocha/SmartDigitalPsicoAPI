using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class NotificationServiceFactory : INotificationServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public INotificationService GetService(ENotificationServiceType serviceType)
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
