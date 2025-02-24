using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class EmailTemplateRepository : GenericRepositoryEntityBase<EmailTemplate>, IEmailTemplateRepository
    {
        public EmailTemplateRepository(IEntityDataContext context) : base(context) { }

        public async Task<EmailTemplate> GetEmailTemplateAsync(string tagApi, string language)
        {
            var template = await _context.EmailTemplates
                .AsNoTracking()
                .SingleAsync(t => t.TagApi == tagApi && t.Language == language && t.Enable);

            return template;
        }
    }
}