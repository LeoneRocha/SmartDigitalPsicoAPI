using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationTemplateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface INotificationTemplateService : IEntityBaseService<ModelEntity.NotificationTemplate, AddNotificationTemplateDto, UpdateNotificationTemplateDto, GetNotificationTemplateDto>
    {
        /// <summary>
        /// Método GetNotificationTemplatesAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string templateKey);
    }
}
