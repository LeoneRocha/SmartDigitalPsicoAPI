using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IEmailTemplateRepository : IEntityBaseRepository<EmailTemplate>
    {
        Task<EmailTemplate> GetEmailTemplateAsync(string tagApi, string language);
    }
} 