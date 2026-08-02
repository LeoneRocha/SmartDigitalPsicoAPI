using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationRecordsRepository : IEntityBaseRepository<NotificationRecord>
    {
        Task<bool> DeleteAllByTokenAsync(Guid tokenId);
        Task<bool> DeleteAllByTokenAsync(Guid[] tokenIds);
        Task<bool> DeleteByTokenAndEventAsync(Guid tokenId, DateTime eventDate);
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
    }
}
