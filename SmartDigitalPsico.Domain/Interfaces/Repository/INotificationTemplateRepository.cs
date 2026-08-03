using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationTemplateRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface INotificationTemplateRepository : IEntityBaseRepository<NotificationTemplate>
    {
        /// <summary>
        /// Método GetNotificationTemplateAsync: consulta e retorna dados.
        /// </summary>
        Task<NotificationTemplate?> GetNotificationTemplateAsync(string templateKey, string language);
    }
} 
