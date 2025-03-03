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

        public override async Task<NotificationRecords> Update(NotificationRecords item)
        {
            var existingEntity = await _dataset.SingleAsync(p => p.Id == item.Id);
            // Marca a entidade como modificada e anexa-a ao contexto
            _context.Entry(existingEntity).State = EntityState.Detached;
            _context.Entry(item).State = EntityState.Modified;

            // Marca a propriedade NotificationRules como modificada
            _context.Entry(item).Property(i => i.NotificationRules).IsModified = true;

            // Atualiza o restante das propriedades da entidade
            _context.Entry(item).CurrentValues.SetValues(item);

            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<NotificationRecords[]> GetPendingNotificationsAsync()
        {
            var currentDateUtc = DateHelper.GetDateTimeNowFromUtc().Date;
            var currentDateUtcDay1Plus = DateHelper.GetDateTimeNowFromUtc().Date.AddDays(1);

            return await _dataset
                .Include(x => x.MedicalCalendar)
                .ThenInclude(x => x!.Patient)
                .ThenInclude(x => x!.Medical)
                .Where(nr => !nr.IsCompleted
                             && nr.NextScheduledSendTime.HasValue
                             && nr.NextScheduledSendTime.Value >= currentDateUtc
                             && nr.NextScheduledSendTime.Value < currentDateUtcDay1Plus
                             && nr.EventDate > currentDateUtc)
                .ToArrayAsync();
        }

    }
}