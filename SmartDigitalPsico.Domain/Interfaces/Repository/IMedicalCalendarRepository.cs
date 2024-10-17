using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMedicalCalendarRepository : IEntityBaseRepository<MedicalCalendar>
    {
        Task<MedicalCalendar[]> GetByMedicalCalendarAsync(MedicalCalendar medicalCalendar);
        Task AddRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars);
        Task DeleteRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars);

        Task<MedicalCalendar[]> GetConflictingEventsAsync(long medicalId, DateTime startDateTime, DateTime endDateTime);

        Task<MedicalCalendar[]> GetMedicalCalendarsForMedicalAsync(long medicalId, DateTime startDate, DateTime endDate);
        Task<MedicalCalendar[]> GetByTokenAsync(string token, long medicalId, long patientId);
    }
}
