using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Generic schedule persistence (SoT). Replaces MedicalCalendarRepository for schedule queries.
    /// </summary>
    public interface IScheduleCalendarRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<ScheduleCalendar>
    {
        /// <summary>
        /// Método GetByUniqueTokenAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendar?> GetByUniqueTokenAsync(string uniqueToken);

        /// <summary>Packages whose period overlaps the window for an owner.</summary>
        /// <summary>
        /// Método GetOverlappingByOwnerAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendar[]> GetOverlappingByOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);

        /// <summary>
        /// Método AddRangeAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task AddRangeAsync(IEnumerable<ScheduleCalendar> schedules);
        /// <summary>
        /// Método DeleteRangeAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task DeleteRangeAsync(IEnumerable<ScheduleCalendar> schedules);

        /// <summary>Equivalent to MedicalCalendarRepository.GetByMedicalCalendarAsync (token + owner + subject from start).</summary>
        /// <summary>
        /// Método GetByTokenFromStartAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendar[]> GetByTokenFromStartAsync(string uniqueToken, string ownerKey, string? subjectKey, DateTime startDateTime);

        /// <summary>Equivalent to GetByTokenAsync.</summary>
        /// <summary>
        /// Método GetByTokenAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendar[]> GetByTokenAsync(string uniqueToken, string ownerKey, string? subjectKey);

        /// <summary>Equivalent to GetConflictingEventsAsync — expands JSON items with real overlap.</summary>
        /// <summary>
        /// Método GetConflictingItemsAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendarItem[]> GetConflictingItemsAsync(string tenantKey, string ownerKey, DateTime startDateTime, DateTime endDateTime);

        /// <summary>Equivalent to GetMedicalCalendarsForMedicalAsync — items overlapping the window.</summary>
        /// <summary>
        /// Método GetItemsForOwnerAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendarItem[]> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime startDate, DateTime endDate);

        /// <summary>Equivalent to HasConflictAsync.</summary>
        /// <summary>
        /// Método HasConflictAsync: executa a operação HasConflictAsync.
        /// </summary>
        Task<bool> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime);

        /// <summary>Equivalent to GetAppointmentAsync.</summary>
        /// <summary>
        /// Método GetItemAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendarItem?> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime);

        /// <summary>Equivalent to GetAppointmentsForMonthAsync.</summary>
        /// <summary>
        /// Método GetItemsForOwnerSubjectAsync: consulta e retorna dados.
        /// </summary>
        Task<ScheduleCalendarItem[]> GetItemsForOwnerSubjectAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime startDate, DateTime endDate);
    }
}
