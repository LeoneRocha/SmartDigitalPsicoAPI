using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationRulesService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface INotificationRulesService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<NotificationRule, GetNotificationRulesDto>
    {
        /// <summary>
        /// Método GetNotificationRulesAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationRule[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId);
    }
}
