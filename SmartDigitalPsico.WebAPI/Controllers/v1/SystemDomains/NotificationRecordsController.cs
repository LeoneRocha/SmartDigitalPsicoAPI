using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por NotificationRecordsController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class NotificationRecordsController : SmartDigitalPsico.Domain.API.ApiBaseController
    {
        private readonly INotificationRecordsService _entityService;
        private readonly INotificationDispatchJobService _notificationDispatchJobService;
        /// <summary>
        /// Método NotificationRecordsController: executa a operação NotificationRecordsController.
        /// </summary>
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
        /// <summary>
        /// Método Get: consulta e retorna dados.
        /// </summary>
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
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
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
        /// <summary>
        /// Método NotificationDispatch: executa a operação NotificationDispatch.
        /// </summary>
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
