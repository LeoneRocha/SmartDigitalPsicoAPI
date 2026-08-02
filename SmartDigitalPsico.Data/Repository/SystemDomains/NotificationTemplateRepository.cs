using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class NotificationTemplateRepository : GenericRepositoryEntityBase<NotificationTemplate>, INotificationTemplateRepository
    {
        public NotificationTemplateRepository(IEntityDataContext context) : base(context) { }

        public async Task<NotificationTemplate?> GetNotificationTemplateAsync(string templateKey, string language)
        {
            var templates = _context.NotificationTemplates.AsNoTracking()
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