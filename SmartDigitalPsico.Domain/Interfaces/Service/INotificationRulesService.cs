using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationRulesService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface INotificationRulesService : IEntityBaseService<NotificationRule, GetNotificationRulesDto>
    {
        /// <summary>
        /// Método GetNotificationRulesAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationRule[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId);
    }
}
