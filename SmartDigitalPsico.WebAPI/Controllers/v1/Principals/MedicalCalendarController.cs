using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Principals
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/medical/v1/[controller]")]
    public class MedicalCalendarController : ApiBaseController
    {
        private readonly IMedicalCalendarService _entityService;
        public MedicalCalendarController(IMedicalCalendarService entityService
            , IOptions<AuthConfigurationDto> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        }
        [HttpGet("schedule/{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetMedicalCalendarDto>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.FindByID(id);
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
            this.setUserIdCurrent();
            var response = await _entityService.Create(newEntity);
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
            this.setUserIdCurrent();
            var response = await _entityService.Update(updateEntity);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("schedule")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete([FromBody] DeleteMedicalCalendarDto request)
        {
            this.setUserIdCurrent();
            var response = await _entityService.DeleteOneOrRecurrence(request);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost("calendar")]
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetMonthlyCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent();
            var schedule = await _entityService.GetMonthlyCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("available")]
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> GetAvailableMedicalCalendar([FromBody] CalendarCriteriaDto criteria)
        {
            this.setUserIdCurrent();
            var schedule = await _entityService.GetAvailableMedicalCalendar(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/send")]
        public async Task<ActionResult<ServiceResponse<CalendarDto>>> SendAppointments([FromBody] ScheduleCriteriaDto criteria)
        {
            this.setUserIdCurrent();
            var schedule = await _entityService.RequestAppointment(criteria);
            return Ok(schedule);
        }

        [HttpPost("appointment/get")]
        public async Task<ActionResult<ServiceResponse<AppointmentDto[]>>> GetAppointments([FromBody] AppointmentCriteriaDto criteria)
        {
            this.setUserIdCurrent();
            var schedule = await _entityService.GetAppointments(criteria);
            return Ok(schedule);
        }
    }
}