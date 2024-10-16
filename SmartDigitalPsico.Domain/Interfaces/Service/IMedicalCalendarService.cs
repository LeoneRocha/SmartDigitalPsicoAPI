using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalCalendarService : IEntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto>
    {
        Task<ServiceResponse<bool>> DeleteOneOrRecurrenceAsync(DeleteMedicalCalendarDto request);
        Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria);
    }
}