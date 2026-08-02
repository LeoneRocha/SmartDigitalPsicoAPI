using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Host facade for schedule actions. Current SDP host maps MedicalCalendar DTOs for FE compatibility.
    /// </summary>
    public interface IScheduleCalendarFacade
    {
        void SetUserId(long userId);

        Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id);
        Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item);
        Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item);
        Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request);
        Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria);
        Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria);
        Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria);
        Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria);
    }
}
