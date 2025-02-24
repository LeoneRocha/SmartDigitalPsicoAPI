using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationService
    {
        Task SendAsync(NotificationTemplate template, Dictionary<string, string> tokens); 
    }
}