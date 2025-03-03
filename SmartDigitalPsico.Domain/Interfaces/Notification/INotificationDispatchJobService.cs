namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationDispatchJobService
    {
        Task ProcessPendingNotificationsAsync();
    }
}
