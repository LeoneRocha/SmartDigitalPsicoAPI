using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Auth
{
    [ApiController]    
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por AuthController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        /// <summary>
        /// Método AuthController: executa a operação AuthController.
        /// </summary>
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        /// <summary>
        /// Método Register: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> Register(UserRegisterDto newEntity)
        {
            var response = await _userService.Register(newEntity);

            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Authenticate")]
        /// <summary>
        /// Método Authenticate: executa a operação Authenticate.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetUserAuthenticatedDto>>> Authenticate(UserLoginDto request)
        {
            var response = await _userService.Login(request.Login, request.Password);             
            if (!response.Success)
            {
                return Unauthorized(response);
            }
            return Ok(response);
        }

        [HttpGet("Logout")]
        /// <summary>
        /// Método Logout: executa a operação Logout.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<string>>> Logout(UserLoginDto request)
        {
            var response = await _userService.Logout(request.Login);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        [HttpPost]
        [Route("refresh")]
        /// <summary>
        /// Método Refresh: executa a operação Refresh.
        /// </summary>
        public IActionResult Refresh([FromBody] SmartDigitalPsico.Domain.VO.TokenVO tokenVo)
        { 
            return NoContent();
        } 
        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        /// <summary>
        /// Método Revoke: executa a operação Revoke.
        /// </summary>
        public IActionResult Revoke()
        { 
            return NoContent();
        }

    }
}
