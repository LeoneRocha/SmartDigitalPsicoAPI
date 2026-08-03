using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationRecordsRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface INotificationRecordsRepository : IEntityBaseRepository<NotificationRecord>
    {
        /// <summary>
        /// Método DeleteAllByTokenAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<bool> DeleteAllByTokenAsync(Guid tokenId);
        /// <summary>
        /// Método DeleteAllByTokenAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<bool> DeleteAllByTokenAsync(Guid[] tokenIds);
        /// <summary>
        /// Método DeleteByTokenAndEventAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<bool> DeleteByTokenAndEventAsync(Guid tokenId, DateTime eventDate);
        /// <summary>
        /// Método GetPendingNotificationsAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationRecord[]> GetPendingNotificationsAsync();
    }
}
