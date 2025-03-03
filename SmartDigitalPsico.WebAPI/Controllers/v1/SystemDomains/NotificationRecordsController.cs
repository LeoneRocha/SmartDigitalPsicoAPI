using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    public class NotificationRecordsController : ApiBaseController
    {
        private readonly INotificationRecordsService _entityService;
        private readonly INotificationDispatchJobService _notificationDispatchJobService;
        public NotificationRecordsController(
              INotificationRecordsService entityService
             , IOptions<AuthConfigurationDto> configurationAuth
            , INotificationDispatchJobService notificationDispatchJobService
            ) : base(configurationAuth)
        {
            _entityService = entityService;
            _notificationDispatchJobService = notificationDispatchJobService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        }
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetNotificationRecordsDto>>>> Get()
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.FindAll();
            if (response.Data == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetNotificationRecordsDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.FindByID(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }


        [AllowAnonymous] // Permite acesso sem autenticação / Allow access without authentication
        [HttpGet("NotificationDispatch")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult> NotificationDispatch()
        {
            try
            { 
                await _notificationDispatchJobService.ProcessPendingNotificationsAsync();
                return Ok();
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
    }
}