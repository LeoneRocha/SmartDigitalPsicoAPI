using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface INotificationRulesService : IEntityBaseService<NotificationRules, AddNotificationRulesDto, UpdateNotificationRulesDto, GetNotificationRulesDto>
    {
        Task<NotificationRules[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId);
    }
}
