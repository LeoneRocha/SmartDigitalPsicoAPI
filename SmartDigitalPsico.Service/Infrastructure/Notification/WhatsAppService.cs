using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class WhatsAppService : INotificationService, IWhatsAppService
    {
        public async Task SendAsync(NotificationTemplate template, Dictionary<string, string> tokens)
        {
            await Task.CompletedTask;
        }
    }
}
