using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class NotificationRulesRepository : GenericRepositoryEntityBase<NotificationRule>, INotificationRulesRepository
    {
        public NotificationRulesRepository(IEntityDataContext context) : base(context) { }

        public async Task<NotificationRule[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId)
        {
            return await _dataset
                .Where(nr => nr.NotificationType == notificationType
                && nr.IsEnabled == isEnabled
                && nr.MedicalId == medicalId)
                .ToArrayAsync();
        }
    }
}