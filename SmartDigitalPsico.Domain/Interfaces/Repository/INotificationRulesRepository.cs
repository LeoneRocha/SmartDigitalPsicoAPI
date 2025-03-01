using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface INotificationRulesRepository : IEntityBaseRepository<NotificationRules>
    {
        Task<List<NotificationRules>> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId);
    }
} 