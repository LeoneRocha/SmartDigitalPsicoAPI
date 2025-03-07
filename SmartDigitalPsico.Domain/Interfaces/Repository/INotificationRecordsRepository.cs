using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationRecordsRepository : IEntityBaseRepository<NotificationRecord>
    {
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
    }
} 