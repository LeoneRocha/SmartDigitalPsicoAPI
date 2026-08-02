using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleCalendarFindService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id);
    }

    public interface IScheduleCalendarCreateService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item);
    }

    public interface IScheduleCalendarUpdateService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item);
    }

    public interface IScheduleCalendarDeleteService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request);
    }

    public interface IScheduleCalendarGradeService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.CalendarDto>> GetMonthlyCalendar(Domain.DTO.Medical.Calendar.CalendarCriteriaDto criteria);
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.CalendarDto>> GetAvailableMedicalCalendar(Domain.DTO.Medical.Calendar.CalendarCriteriaDto criteria);
    }

    public interface IScheduleCalendarAppointmentService
    {
        void SetUserId(long userId);
        Task<ServiceResponse<bool>> RequestAppointment(Domain.DTO.Medical.Calendar.ScheduleCriteriaDto criteria);
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.AppointmentDto[]>> GetAppointments(Domain.DTO.Medical.Calendar.AppointmentCriteriaDto criteria);
    }
}
