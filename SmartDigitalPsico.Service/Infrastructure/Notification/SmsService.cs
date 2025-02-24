using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class SmsService : INotificationService, ISmsService
    {
        public async Task SendAsync(NotificationTemplate template, Dictionary<string, string> tokens)
        { 
            await Task.CompletedTask;
        }
    }
}
