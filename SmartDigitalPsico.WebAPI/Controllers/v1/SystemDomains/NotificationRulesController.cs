using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por NotificationRulesController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class NotificationRulesController : SmartDigitalPsico.Domain.API.ApiBaseController
    {
        private readonly INotificationRulesService _entityService;

        /// <summary>
        /// Método NotificationRulesController: executa a operação NotificationRulesController.
        /// </summary>
        public NotificationRulesController(INotificationRulesService entityService
             , IOptions<AuthConfigurationDto> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
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
        public async Task<ActionResult<ServiceResponse<List<GetNotificationRulesDto>>>> Get()
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
        public async Task<ActionResult<ServiceResponse<GetNotificationRulesDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.FindByID(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetNotificationRulesDto>>> Create(AddNotificationRulesDto newEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Create(newEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetNotificationRulesDto>>> Update(UpdateNotificationRulesDto updateEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Update(updateEntity);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Delete(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
