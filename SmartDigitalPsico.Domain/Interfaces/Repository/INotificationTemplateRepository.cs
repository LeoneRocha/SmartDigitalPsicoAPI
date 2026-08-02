using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationTemplateRepository : IEntityBaseRepository<NotificationTemplate>
    {
        Task<NotificationTemplate?> GetNotificationTemplateAsync(string templateKey, string language);
    }
} 