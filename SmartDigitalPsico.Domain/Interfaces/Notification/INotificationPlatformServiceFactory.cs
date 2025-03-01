using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationPlatformServiceFactory
    {
        INotificationPlatformService GetService(ENotificationServiceType serviceType);
    }
}
