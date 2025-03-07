using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.DTO.Notification;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface INotificationRecordsService : IEntityBaseService<NotificationRecord, AddNotificationRecordsDto, UpdateNotificationRecordsDto, GetNotificationRecordsDto>
    {
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
        Task CreateOrUpdateNotificationRecordsAsync(GenerateNotificationRecordsDto dto);
    }
}
