using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarFindService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarFindService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id);
    }

    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarCreateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarCreateService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item);
    }

    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarUpdateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarUpdateService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item);
    }

    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarDeleteService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarDeleteService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método DeleteOneOrRecurrence: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request);
    }

    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarGradeService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarGradeService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método GetMonthlyCalendar: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.CalendarDto>> GetMonthlyCalendar(Domain.DTO.Medical.Calendar.CalendarCriteriaDto criteria);
        /// <summary>
        /// Método GetAvailableMedicalCalendar: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.CalendarDto>> GetAvailableMedicalCalendar(Domain.DTO.Medical.Calendar.CalendarCriteriaDto criteria);
    }

    /// <summary>
    /// Interface (contrato) responsável por IScheduleCalendarAppointmentService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCalendarAppointmentService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long userId);
        /// <summary>
        /// Método RequestAppointment: executa a operação RequestAppointment.
        /// </summary>
        Task<ServiceResponse<bool>> RequestAppointment(Domain.DTO.Medical.Calendar.ScheduleCriteriaDto criteria);
        /// <summary>
        /// Método GetAppointments: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<Domain.DTO.Medical.Calendar.AppointmentDto[]>> GetAppointments(Domain.DTO.Medical.Calendar.AppointmentCriteriaDto criteria);
    }
}
