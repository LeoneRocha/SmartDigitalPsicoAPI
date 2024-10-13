using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalCalendarService : IEntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto>
    {
        Task<ScheduleDto> GetMonthlySchedule(ScheduleCriteriaDto criteria);
    }
}