using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class NotificationRecordsRepository : GenericRepositoryEntityBase<NotificationRecords>, INotificationRecordsRepository
    {
        public NotificationRecordsRepository(IEntityDataContext context) : base(context) { }


        public async Task<NotificationRecords[]> GetPendingNotificationsAsync()
        { 
            var currentTimeUtc = DateHelper.GetDateTimeNowFromUtc();
            // Consulta otimizada usando EF Core
            return await _dataset
                .Where(nr => !nr.IsCompleted
                             && nr.NextScheduledSendTime.HasValue
                             && nr.NextScheduledSendTime >= currentTimeUtc)
                .ToArrayAsync();
        }
    }
}