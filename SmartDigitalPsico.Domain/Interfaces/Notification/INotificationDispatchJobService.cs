using SmartDigitalPsico.Domain.Events;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface INotificationDispatchJobService
    {
        Task ProcessPendingNotificationsAsync();
        event EventHandler<NotificationProgressEventArgs>? ProgressChanged;
    }
}
