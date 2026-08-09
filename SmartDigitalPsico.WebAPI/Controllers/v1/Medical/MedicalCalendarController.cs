using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.WebAPI.Controllers.v1
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/medical/v1/[controller]")]
    /// <summary>
    /// Classe responsável por MedicalCalendarController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class MedicalCalendarController : Domain.API.ApiBaseController
    {
        private readonly IScheduleCalendarFacade _scheduleAdapter;

        /// <summary>
        /// Método MedicalCalendarController: executa a operação MedicalCalendarController.
        /// </summary>
        public MedicalCalendarController(
            IScheduleCalendarFacade scheduleAdapter,
            IOptions<AuthConfigurationDto> configurationAuth) : base(configurationAuth)
        {
            _scheduleAdapter = scheduleAdapter;
        }

        private void setUserIdCurrent()
        {
            _scheduleAdapter.SetUserId(base.GetUserIdCurrent());
        }

        [HttpGet("schedule/{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetMedicalCalendarDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();

            var response = await _scheduleAdapter.FindByID(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("schedule")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetMedicalCalendarDto>>> Create([FromBody] AddMedicalCalendarDto newEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _scheduleAdapter.Create(newEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut("schedule")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetMedicalCalendarDto>>> Update([FromBody] UpdateMedicalCalendarDto updateEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _scheduleAdapter.Update(updateEntity);
            if (response.Data == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete("schedule")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<bool>>> Delete([FromBody] DeleteMedicalCalendarDto request)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _scheduleAdapter.DeleteOneOrRecurrence(request);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("calendar")]
        /// <summary>
        /// Método GetMonthlyCalendar: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetMonthlyCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetMonthlyCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("available")]
        /// <summary>
        /// Método GetAvailableMedicalCalendar: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetAvailableMedicalCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetAvailableMedicalCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/send")]
        /// <summary>
        /// Método SendAppointments: dispara notificação ou comunicação.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> SendAppointments([FromBody] ScheduleCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.RequestAppointment(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/get")]
        /// <summary>
        /// Método GetAppointments: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<AppointmentDto[]>>> GetAppointments([FromBody] AppointmentCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetAppointments(criteria);
            return Ok(schedule);
        }
    }
}
