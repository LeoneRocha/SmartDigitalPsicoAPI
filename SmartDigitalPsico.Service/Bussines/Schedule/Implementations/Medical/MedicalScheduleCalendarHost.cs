using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Thin Medical facade: sets scoped user context and delegates to action services.
    /// </summary>
    public class MedicalScheduleCalendarHost : IScheduleCalendarFacade
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleCalendarFindService _find;
        private readonly IScheduleCalendarCreateService _create;
        private readonly IScheduleCalendarUpdateService _update;
        private readonly IScheduleCalendarDeleteService _delete;
        private readonly IScheduleCalendarGradeService _grade;
        private readonly IScheduleCalendarAppointmentService _appointment;

        public MedicalScheduleCalendarHost(
            MedicalScheduleHostSupport support,
            IScheduleCalendarFindService find,
            IScheduleCalendarCreateService create,
            IScheduleCalendarUpdateService update,
            IScheduleCalendarDeleteService delete,
            IScheduleCalendarGradeService grade,
            IScheduleCalendarAppointmentService appointment)
        {
            _support = support;
            _find = find;
            _create = create;
            _update = update;
            _delete = delete;
            _grade = grade;
            _appointment = appointment;
        }

        public void SetUserId(long userId) => _support.SetUserId(userId);

        public Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id)
            => _find.FindByID(id);

        public Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
            => _create.Create(item);

        public Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
            => _update.Update(item);

        public Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
            => _delete.DeleteOneOrRecurrence(request);

        public Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
            => _grade.GetMonthlyCalendar(criteria);

        public Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria)
            => _grade.GetAvailableMedicalCalendar(criteria);

        public Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria)
            => _appointment.RequestAppointment(criteria);

        public Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria)
            => _appointment.GetAppointments(criteria);
    }
}
