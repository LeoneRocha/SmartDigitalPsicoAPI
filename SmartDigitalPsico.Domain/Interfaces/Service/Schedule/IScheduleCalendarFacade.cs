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
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id);
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item);
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item);
        /// <summary>
        /// Método DeleteOneOrRecurrence: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request);
        /// <summary>
        /// Método GetMonthlyCalendar: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria);
        /// <summary>
        /// Método GetAvailableMedicalCalendar: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria);
        /// <summary>
        /// Método RequestAppointment: executa a operação RequestAppointment.
        /// </summary>
        Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria);
        /// <summary>
        /// Método GetAppointments: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria);
    }
}
