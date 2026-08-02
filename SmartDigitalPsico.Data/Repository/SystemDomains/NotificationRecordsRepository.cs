using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class NotificationRecordsRepository : GenericRepositoryEntityBase<NotificationRecord>, INotificationRecordsRepository
    {
        public NotificationRecordsRepository(IEntityDataContext context) : base(context) { }

        public override async Task<NotificationRecord> Update(NotificationRecord item)
        {
            var existingEntity = await _dataset.SingleAsync(p => p.Id == item.Id);
            _context.Entry(existingEntity).State = EntityState.Detached;
            _context.Entry(item).State = EntityState.Modified;

            _context.Entry(item).Property(i => i.NotificationRules).IsModified = true;

            _context.Entry(item).CurrentValues.SetValues(item);

            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<NotificationRecord[]> GetPendingNotificationsAsync()
        {
            var currentDateUtc = DateHelper.GetDateTimeNowFromUtc().Date;
            var currentDateUtcDay1Plus = DateHelper.GetDateTimeNowFromUtc().Date.AddDays(1);

            return await _dataset
                .Where(nr => !nr.IsCompleted
                             && nr.NextScheduledSendTime.HasValue
                             && nr.NextScheduledSendTime.Value >= currentDateUtc
                             && nr.NextScheduledSendTime.Value < currentDateUtcDay1Plus
                             && nr.EventDate > currentDateUtc)
                .ToArrayAsync();
        }

        public async Task<bool> DeleteAllByTokenAsync(Guid tokenId)
        {
            var result = await _dataset.Where(p => p.TokenId == tokenId).ToArrayAsync();
            foreach (var item in result)
                _dataset.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
         
        public async Task<bool> DeleteAllByTokenAsync(Guid[] tokenIds)
        {
            var result = await _dataset.Where(p => tokenIds.Contains(p.TokenId)).ToArrayAsync();
            foreach (var item in result)
                _dataset.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteByTokenAndEventAsync(Guid tokenId, DateTime eventDate)
        {
            var result = await _dataset
                .Where(p => p.TokenId == tokenId && p.EventDate == eventDate)
                .ToArrayAsync();
            foreach (var item in result)
                _dataset.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
