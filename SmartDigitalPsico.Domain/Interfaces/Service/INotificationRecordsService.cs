using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Notification;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
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
