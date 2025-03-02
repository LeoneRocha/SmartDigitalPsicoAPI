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
            var currentDateUtc = DateHelper.GetDateTimeNowFromUtc().Date;
          
            return await _dataset
                .Include(x=> x.MedicalCalendar)
                .ThenInclude(x => x!.Patient)
                .ThenInclude(x => x!.Medical)
                .Where(nr => !nr.IsCompleted
                             && nr.NextScheduledSendTime.HasValue
                             && nr.NextScheduledSendTime.Value >= currentDateUtc
                             && nr.EventDate > currentDateUtc)
                .ToArrayAsync();
        }

    }
}