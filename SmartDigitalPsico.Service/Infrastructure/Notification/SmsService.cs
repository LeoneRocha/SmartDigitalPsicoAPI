using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class SmsService : ISmsService
    {
        public async Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens)
        {
            await Task.CompletedTask;
        }
    }
}
