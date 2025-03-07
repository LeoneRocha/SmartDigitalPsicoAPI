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

        public async Task<NotificationTemplate> GetNotificationTemplateAsync(string tagApi, string language)
        {
            var template = await _context.NotificationTemplates
                .AsNoTracking()
                .SingleAsync(t => t.TagApi == tagApi && t.Language == language && t.Enable);

            return template;
        }
    }
}