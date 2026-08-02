using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

#pragma warning disable CS0618 // Controller keeps IMedicalCalendarService for SetUserId/history; runtime uses IScheduleCalendarFacade

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Principals
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/medical/v1/[controller]")]
    public class MedicalCalendarController : ApiBaseController
    {
        private readonly IMedicalCalendarService _entityService;
        private readonly IScheduleCalendarFacade _scheduleAdapter;

        public MedicalCalendarController(
            IMedicalCalendarService entityService,
            IScheduleCalendarFacade scheduleAdapter,
            IOptions<AuthConfigurationDto> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
            _scheduleAdapter = scheduleAdapter;
        }

        private void setUserIdCurrent()
        {
            var userId = base.GetUserIdCurrent();
            _entityService.SetUserId(userId);
            _scheduleAdapter.SetUserId(userId);
        }

        [HttpGet("schedule/{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
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
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetMonthlyCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetMonthlyCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("available")]
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetAvailableMedicalCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetAvailableMedicalCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/send")]
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> SendAppointments([FromBody] ScheduleCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.RequestAppointment(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/get")]
        public async Task<ActionResult<ServiceResponse<AppointmentDto[]>>> GetAppointments([FromBody] AppointmentCriteriaDto criteria)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var schedule = await _scheduleAdapter.GetAppointments(criteria);
            return Ok(schedule);
        }
    }
}
