using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service
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

        /// <summary>
        /// Método MedicalScheduleCalendarHost: executa a operação MedicalScheduleCalendarHost.
        /// </summary>
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

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id)
            => _find.FindByID(id);

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
            => _create.Create(item);

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
            => _update.Update(item);

        /// <summary>
        /// Método DeleteOneOrRecurrence: remove ou cancela um registro/recurso.
        /// </summary>
        public Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
            => _delete.DeleteOneOrRecurrence(request);

        /// <summary>
        /// Método GetMonthlyCalendar: consulta e retorna dados.
        /// </summary>
        public Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
            => _grade.GetMonthlyCalendar(criteria);

        /// <summary>
        /// Método GetAvailableMedicalCalendar: consulta e retorna dados.
        /// </summary>
        public Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria)
            => _grade.GetAvailableMedicalCalendar(criteria);

        /// <summary>
        /// Método RequestAppointment: operação de agendamento.
        /// </summary>
        public Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria)
            => _appointment.RequestAppointment(criteria);

        /// <summary>
        /// Método GetAppointments: consulta e retorna dados.
        /// </summary>
        public Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria)
            => _appointment.GetAppointments(criteria);
    }
}
