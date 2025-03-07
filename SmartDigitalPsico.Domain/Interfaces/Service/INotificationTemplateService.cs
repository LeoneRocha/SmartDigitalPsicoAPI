using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface INotificationTemplateService : IEntityBaseService<ModelEntity.NotificationTemplate, AddNotificationTemplateDto, UpdateNotificationTemplateDto, GetNotificationTemplateDto>
    {
        Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string tagApi);
    }
}
