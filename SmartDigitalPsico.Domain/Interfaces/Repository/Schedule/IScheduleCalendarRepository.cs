using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Repository.Schedule
{
    /// <summary>
    /// Generic schedule persistence (SoT). Replaces MedicalCalendarRepository for schedule queries.
    /// </summary>
    public interface IScheduleCalendarRepository : IEntityBaseRepository<ScheduleCalendar>
    {
        Task<ScheduleCalendar?> GetByUniqueTokenAsync(string uniqueToken);

        /// <summary>Packages whose period overlaps the window for an owner.</summary>
        Task<ScheduleCalendar[]> GetOverlappingByOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);

        Task AddRangeAsync(IEnumerable<ScheduleCalendar> schedules);
        Task DeleteRangeAsync(IEnumerable<ScheduleCalendar> schedules);

        /// <summary>Equivalent to MedicalCalendarRepository.GetByMedicalCalendarAsync (token + owner + subject from start).</summary>
        Task<ScheduleCalendar[]> GetByTokenFromStartAsync(string uniqueToken, string ownerKey, string? subjectKey, DateTime startDateTime);

        /// <summary>Equivalent to GetByTokenAsync.</summary>
        Task<ScheduleCalendar[]> GetByTokenAsync(string uniqueToken, string ownerKey, string? subjectKey);

        /// <summary>Equivalent to GetConflictingEventsAsync — expands JSON items with real overlap.</summary>
        Task<ScheduleCalendarItem[]> GetConflictingItemsAsync(string tenantKey, string ownerKey, DateTime startDateTime, DateTime endDateTime);

        /// <summary>Equivalent to GetMedicalCalendarsForMedicalAsync — items overlapping the window.</summary>
        Task<ScheduleCalendarItem[]> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime startDate, DateTime endDate);

        /// <summary>Equivalent to HasConflictAsync.</summary>
        Task<bool> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime);

        /// <summary>Equivalent to GetAppointmentAsync.</summary>
        Task<ScheduleCalendarItem?> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime);

        /// <summary>Equivalent to GetAppointmentsForMonthAsync.</summary>
        Task<ScheduleCalendarItem[]> GetItemsForOwnerSubjectAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime startDate, DateTime endDate);
    }
}
