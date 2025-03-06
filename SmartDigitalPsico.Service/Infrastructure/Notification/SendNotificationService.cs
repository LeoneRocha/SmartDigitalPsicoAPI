using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class SendNotificationService : ISendNotificationService
    {
        private readonly INotificationPlatformServiceFactory _notificationServiceFactory;

        public SendNotificationService(INotificationPlatformServiceFactory notificationServiceFactory)
        {
            _notificationServiceFactory = notificationServiceFactory;
        }

        public async Task SendNotificationAsync(DataNotificationTemplateVO template, ENotificationServiceType serviceType, Dictionary<string, string> tokens)
        {
            var service = _notificationServiceFactory.GetService(serviceType);
            await service.SendAsync(template, tokens);
        }
    }
}
