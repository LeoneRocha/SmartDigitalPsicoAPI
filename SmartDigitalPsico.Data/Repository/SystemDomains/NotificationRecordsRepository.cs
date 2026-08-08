using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationRecordsRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class NotificationRecordsRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<NotificationRecord>, INotificationRecordsRepository
    {
        /// <summary>
        /// Método NotificationRecordsRepository: executa a operação NotificationRecordsRepository.
        /// </summary>
        public NotificationRecordsRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
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

        /// <summary>
        /// Método GetPendingNotificationsAsync: consulta e retorna dados.
        /// </summary>
        public async Task<NotificationRecord[]> GetPendingNotificationsAsync()
        {
            var currentDateUtc = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().Date;
            var currentDateUtcDay1Plus = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().Date.AddDays(1);

            return await _dataset
                .Where(nr => !nr.IsCompleted
                             && nr.NextScheduledSendTime.HasValue
                             && nr.NextScheduledSendTime.Value >= currentDateUtc
                             && nr.NextScheduledSendTime.Value < currentDateUtcDay1Plus
                             && nr.EventDate > currentDateUtc)
                .ToArrayAsync();
        }

        /// <summary>
        /// Método DeleteAllByTokenAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<bool> DeleteAllByTokenAsync(Guid tokenId)
        {
            var result = await _dataset.Where(p => p.TokenId == tokenId).ToArrayAsync();
            foreach (var item in result)
                _dataset.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
         
        /// <summary>
        /// Método DeleteAllByTokenAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<bool> DeleteAllByTokenAsync(Guid[] tokenIds)
        {
            var result = await _dataset.Where(p => tokenIds.Contains(p.TokenId)).ToArrayAsync();
            foreach (var item in result)
                _dataset.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Método DeleteByTokenAndEventAsync: remove ou cancela um registro/recurso.
        /// </summary>
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
