using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationTemplateRepository : IEntityBaseRepository<NotificationTemplate>
    {
        Task<NotificationTemplate> GetNotificationTemplateAsync(string tagApi, string language);
    }
} 