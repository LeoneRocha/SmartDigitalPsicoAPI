using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface INotificationRecordsService : IEntityBaseService<NotificationRecords, AddNotificationRecordsDto, UpdateNotificationRecordsDto, GetNotificationRecordsDto>
    { 
    }
}
