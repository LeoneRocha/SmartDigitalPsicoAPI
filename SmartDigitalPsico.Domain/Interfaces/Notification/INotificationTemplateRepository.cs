using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationTemplateRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface INotificationTemplateRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<NotificationTemplate>
    {
        /// <summary>
        /// Método GetNotificationTemplateAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationTemplate?> GetNotificationTemplateAsync(string templateKey, string language);
    }
}
