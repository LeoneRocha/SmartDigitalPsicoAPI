using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalCalendarRepository : GenericRepositoryEntityBase<MedicalCalendar>, IMedicalCalendarRepository
    {
        public MedicalCalendarRepository(IEntityDataContext context) : base(context) { }

        public async Task<IEnumerable<MedicalCalendar>> GetByMedicalCalendarAsync(MedicalCalendar medicalCalendar)
        {
            return await _context.MedicalCalendars
                .Where(e =>
                e.MedicalId == medicalCalendar.MedicalId 
                && e.PatientId == medicalCalendar.PatientId 
                && e.Title == medicalCalendar.Title 
                && e.StartDateTime >= medicalCalendar.StartDateTime)
                .ToListAsync();
        }

        public async Task AddRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars)
        {
            await _context.MedicalCalendars.AddRangeAsync(medicalCalendars);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<MedicalCalendar> medicalCalendars)
        {
            _context.MedicalCalendars.RemoveRange(medicalCalendars);
            await _context.SaveChangesAsync();
        }
    }
}
