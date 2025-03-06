using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationPlatformService
    {
        Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens); 
    }
}