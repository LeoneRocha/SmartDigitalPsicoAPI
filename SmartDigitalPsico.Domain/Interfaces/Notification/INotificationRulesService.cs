using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
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
