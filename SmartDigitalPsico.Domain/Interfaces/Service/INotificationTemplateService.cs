using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationTemplateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface INotificationTemplateService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<ModelEntity.NotificationTemplate, GetNotificationTemplateDto>
    {
        /// <summary>
        /// Método GetNotificationTemplatesAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string templateKey);
    }
}
