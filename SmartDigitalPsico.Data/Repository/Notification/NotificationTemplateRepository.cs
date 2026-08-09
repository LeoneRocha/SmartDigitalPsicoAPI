using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por NotificationTemplateRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class NotificationTemplateRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<NotificationTemplate>, INotificationTemplateRepository
    {
        /// <summary>
        /// Método NotificationTemplateRepository: executa a operação NotificationTemplateRepository.
        /// </summary>
        public NotificationTemplateRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método GetNotificationTemplateAsync: consulta e retorna dados.
        /// </summary>
        public async Task<NotificationTemplate?> GetNotificationTemplateAsync(string templateKey, string language)
        {
            var templates = ((Context.EntityDataSmartDigitalPsicoContext)_context).NotificationTemplates.AsNoTracking()
                .Where(t => t.TemplateKey == templateKey && t.Enable);

            var template = await templates.FirstOrDefaultAsync(t => t.Language == language);
            if (template != null)
                return template;

            // Fallback when CurrentCulture does not match seed language (pt-BR).
            return await templates.FirstOrDefaultAsync(t => t.Language == "pt-BR")
                ?? await templates.FirstOrDefaultAsync();
        }
    }
}
