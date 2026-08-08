using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por GenderController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class GenderController : SmartDigitalPsicoAPI.Core.SDK.API.ApiBaseController
    {
        private readonly IGenderService _entityService; 
        /// <summary>
        /// Método GenderController: executa a operação GenderController.
        /// </summary>
        public GenderController(IGenderService entityService
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
        public async Task<ActionResult<ServiceResponse<List<GetGenderDto>>>> Get()
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var result = _entityService.FindAll();
            return Ok(await result);
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetGenderDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetGenderDto>>> Create(AddGenderDto newEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.Create(newEntity));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetGenderDto>>> Update(UpdateGenderDto updateEntity)
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
