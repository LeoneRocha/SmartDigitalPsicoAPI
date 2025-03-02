
namespace SmartDigitalPsico.Service.Bussines.Notification
{
    public interface INotificationDispatchJobService
    {
        Task ProcessPendingNotificationsAsync();
    }
}