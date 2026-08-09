using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Notification.Common;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationRecordsService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface INotificationRecordsService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<NotificationRecord, GetNotificationRecordsDto>
    {
        /// <summary>
        /// Método GetPendingNotificationsAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
        /// <summary>
        /// Método CreateOrUpdateNotificationRecordsAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task CreateOrUpdateNotificationRecordsAsync(GenerateNotificationRecordsDto dto);
    }
}
