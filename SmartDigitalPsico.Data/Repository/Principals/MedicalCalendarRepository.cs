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

        public async Task<MedicalCalendar[]> GetByMedicalCalendarAsync(MedicalCalendar medicalCalendar)
        {
            return await _context.MedicalCalendars 
                .Where(e =>
                e.MedicalId == medicalCalendar.MedicalId
                && e.PatientId == medicalCalendar.PatientId
                && e.TokenRecurrence == medicalCalendar.TokenRecurrence
                && e.StartDateTime >= medicalCalendar.StartDateTime)
                .ToArrayAsync();
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

        public async Task<MedicalCalendar[]> GetConflictingEventsAsync(long medicalId, DateTime startDateTime, DateTime endDateTime)
        {
            return await _context.MedicalCalendars
                .AsNoTracking()
                .Where(mc => mc.MedicalId == medicalId &&
                             mc.StartDateTime <= startDateTime &&
                             mc.EndDateTime >= endDateTime)
                .ToArrayAsync();
        }


        public async Task<MedicalCalendar[]> GetMedicalCalendarsForMedicalAsync(long medicalId, DateTime startDate, DateTime endDate)
        {
            return await _context.MedicalCalendars
                .AsNoTracking()
                .Where(mc => mc.Enable && mc.MedicalId == medicalId && mc.StartDateTime >= startDate && mc.EndDateTime <= endDate)
                .Include(x => x.Patient)
                .ToArrayAsync();
        }

        public async Task<MedicalCalendar[]> GetByTokenAsync(string token, long medicalId, long patientId)
        {
            return await _context.MedicalCalendars 
                .Where(mc => mc.TokenRecurrence == token && mc.MedicalId == medicalId && mc.PatientId == patientId)
                .ToArrayAsync();
        }
        public async Task<bool> HasConflictAsync(long medicalId, DateTime appointmentDateTime)
        {
            return await _context.MedicalCalendars.AnyAsync(mc => mc.MedicalId == medicalId && mc.StartDateTime <= appointmentDateTime && mc.EndDateTime >= appointmentDateTime);
        }

        public async Task<MedicalCalendar?> GetAppointmentAsync(long medicalId, DateTime appointmentDateTime, long patientId)
        {
            return await _context.MedicalCalendars 
                .FirstOrDefaultAsync(mc => mc.MedicalId == medicalId && mc.StartDateTime == appointmentDateTime && mc.PatientId == patientId);
        }

        public async Task<MedicalCalendar[]> GetAppointmentsForMonthAsync(long medicalId, long patientId, DateTime startDate, DateTime endDate)
        {
            return await _context.MedicalCalendars
                .AsNoTracking()
                .Include(mc => mc.Medical)
                .Include(mc => mc.Patient)
                .Where(mc => mc.MedicalId == medicalId && mc.PatientId == patientId && mc.StartDateTime >= startDate && mc.EndDateTime <= endDate)
                .ToArrayAsync();
        }
    }
}