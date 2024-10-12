using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMedicalCalendarRepository : IEntityBaseRepository<MedicalCalendar>
    {
        Task<IEnumerable<MedicalCalendar>> GetByMedicalCalendarAsync(MedicalCalendar medicalCalendar);
        Task AddRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars);
        Task DeleteRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars);
    }
}
