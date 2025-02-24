using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationServiceFactory
    {
        INotificationService GetService(NotificationServiceType serviceType);
    }
}
