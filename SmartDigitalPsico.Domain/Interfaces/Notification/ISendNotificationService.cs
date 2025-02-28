using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface ISendNotificationService
    {
        Task SendNotificationAsync(NotificationTemplate template, ENotificationServiceType serviceType, Dictionary<string, string> tokens);

    }
}