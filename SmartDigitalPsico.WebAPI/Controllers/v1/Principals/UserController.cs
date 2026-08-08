using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;
namespace SmartDigitalPsico.WebAPI.Controllers.v1.Principals
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por UserController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class UserController : SmartDigitalPsicoAPI.Core.SDK.API.ApiBaseController
    {
        private readonly IUserService _entityService;

        /// <summary>
        /// Método UserController: executa a operação UserController.
        /// </summary>
        public UserController(IUserService entityService
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
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<List<GetUserDto>>>> FindAll()
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.FindAll();
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response); 
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.FindByID(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> Create(UserRegisterDto newEntity)
        {
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
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> Update(UpdateUserDto updateEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Update(updateEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPatch]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método UpdateProfile: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> UpdateProfile(UpdateUserProfileDto updateEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.UpdateProfile(updateEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Delete(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
