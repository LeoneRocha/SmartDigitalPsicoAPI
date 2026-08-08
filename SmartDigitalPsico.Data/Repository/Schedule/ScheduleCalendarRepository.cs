using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Data.Repository.Schedule
{
    /// <summary>
    /// Classe responsável por ScheduleCalendarRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class ScheduleCalendarRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ScheduleCalendar>, IScheduleCalendarRepository
    {
        /// <summary>
        /// Método ScheduleCalendarRepository: operação de agendamento.
        /// </summary>
        public ScheduleCalendarRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método AddRangeAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task AddRangeAsync(IEnumerable<ScheduleCalendar> schedules)
        {
            await _dataset.AddRangeAsync(schedules);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Método DeleteRangeAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task DeleteRangeAsync(IEnumerable<ScheduleCalendar> schedules)
        {
            _dataset.RemoveRange(schedules);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Método GetByUniqueTokenAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendar?> GetByUniqueTokenAsync(string uniqueToken)
        {
            return await _dataset
                .Where(x => x.UniqueToken == uniqueToken)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Método GetOverlappingByOwnerAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendar[]> GetOverlappingByOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            return await _dataset
                .Where(x => x.Enable
                    && x.TenantKey == tenantKey
                    && x.OwnerKey == ownerKey
                    && x.StartPeriod < end
                    && x.EndPeriod > start)
                .ToArrayAsync();
        }

        /// <summary>
        /// Método GetByTokenFromStartAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendar[]> GetByTokenFromStartAsync(string uniqueToken, string ownerKey, string? subjectKey, DateTime startDateTime)
        {
            var query = _dataset.Where(x =>
                x.UniqueToken == uniqueToken
                && x.OwnerKey == ownerKey
                && x.StartPeriod >= startDateTime);

            if (!string.IsNullOrWhiteSpace(subjectKey))
                query = query.Where(x => x.SubjectKey == subjectKey);

            return await query.ToArrayAsync();
        }

        /// <summary>
        /// Método GetByTokenAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendar[]> GetByTokenAsync(string uniqueToken, string ownerKey, string? subjectKey)
        {
            var query = _dataset.Where(x =>
                x.UniqueToken == uniqueToken
                && x.OwnerKey == ownerKey);

            if (!string.IsNullOrWhiteSpace(subjectKey))
                query = query.Where(x => x.SubjectKey == subjectKey);

            return await query.ToArrayAsync();
        }

        /// <summary>
        /// Método GetConflictingItemsAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendarItem[]> GetConflictingItemsAsync(string tenantKey, string ownerKey, DateTime startDateTime, DateTime endDateTime)
        {
            var packages = await GetOverlappingByOwnerAsync(tenantKey, ownerKey, startDateTime, endDateTime);
            return ExpandOverlappingItems(packages, startDateTime, endDateTime);
        }

        /// <summary>
        /// Método GetItemsForOwnerAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendarItem[]> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime startDate, DateTime endDate)
        {
            var packages = await GetOverlappingByOwnerAsync(tenantKey, ownerKey, startDate, endDate);
            return ExpandOverlappingItems(packages, startDate, endDate);
        }

        /// <summary>
        /// Método HasConflictAsync: executa a operação HasConflictAsync.
        /// </summary>
        public async Task<bool> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime)
        {
            var packages = await GetOverlappingByOwnerAsync(tenantKey, ownerKey, appointmentDateTime, appointmentDateTime.AddTicks(1));
            return packages
                .SelectMany(p => p.ScheduleData ?? [])
                .Any(i => i.StartDateTime <= appointmentDateTime
                          && (i.EndDateTime ?? i.StartDateTime) >= appointmentDateTime);
        }

        /// <summary>
        /// Método GetItemAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendarItem?> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime)
        {
            var packages = await GetOverlappingByOwnerAsync(tenantKey, ownerKey, appointmentDateTime, appointmentDateTime.AddTicks(1));
            return packages
                .Where(p => string.IsNullOrWhiteSpace(subjectKey) || p.SubjectKey == subjectKey)
                .SelectMany(p => (p.ScheduleData ?? []).Select(i => StampPackageMetadata(i, p)))
                .FirstOrDefault(i => i.StartDateTime == appointmentDateTime);
        }

        /// <summary>
        /// Método GetItemsForOwnerSubjectAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ScheduleCalendarItem[]> GetItemsForOwnerSubjectAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime startDate, DateTime endDate)
        {
            var packages = await GetOverlappingByOwnerAsync(tenantKey, ownerKey, startDate, endDate);
            return packages
                .Where(p => string.IsNullOrWhiteSpace(subjectKey) || p.SubjectKey == subjectKey)
                .SelectMany(p => (p.ScheduleData ?? []).Select(i => StampPackageMetadata(i, p)))
                .Where(i => i.StartDateTime >= startDate
                            && (i.EndDateTime ?? i.StartDateTime) <= endDate)
                .ToArray();
        }

        private static ScheduleCalendarItem[] ExpandOverlappingItems(IEnumerable<ScheduleCalendar> packages, DateTime start, DateTime end)
        {
            return packages
                .SelectMany(p => (p.ScheduleData ?? []).Select(i => StampPackageMetadata(i, p)))
                .Where(i => ScheduleOverlapHelper.Overlaps(i.StartDateTime, i.EndDateTime, start, end))
                .ToArray();
        }

        private static ScheduleCalendarItem StampPackageMetadata(ScheduleCalendarItem item, ScheduleCalendar package)
        {
            return new ScheduleCalendarItem
            {
                Title = item.Title,
                StartDateTime = item.StartDateTime,
                EndDateTime = item.EndDateTime,
                IsAllDay = item.IsAllDay,
                Status = item.Status,
                ColorCategoryHexa = item.ColorCategoryHexa,
                IsPushedCalendar = item.IsPushedCalendar,
                TimeZone = item.TimeZone,
                Location = item.Location,
                Description = item.Description,
                RecurrenceDays = item.RecurrenceDays ?? [],
                RecurrenceType = item.RecurrenceType,
                RecurrenceEndDate = item.RecurrenceEndDate,
                RecurrenceCount = item.RecurrenceCount,
                ReasonCancellation = item.ReasonCancellation,
                TokenRecurrence = string.IsNullOrWhiteSpace(item.TokenRecurrence) ? package.UniqueToken : item.TokenRecurrence,
                PackageId = package.Id,
                OwnerKey = package.OwnerKey,
                SubjectKey = package.SubjectKey
            };
        }
    }
}
