using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationRecordsRepository : IEntityBaseRepository<NotificationRecord>
    {
        Task<bool> DeleteAll(long medicalCalendarId);
        Task<bool> DeleteAll(long[] medicalCalendarId);
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
    }
}