using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO.User;
using SmartDigitalPsico.Domain.VO.Utils;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Auth
{
    [ApiController]    
    [Route("api/[controller]/v1")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<GetUserVO>>> Register(UserRegisterVO newEntity)
        {
            var response = await _userService.Register(newEntity);

            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Authenticate")]
        public async Task<ActionResult<ServiceResponse<GetUserAuthenticatedVO>>> Authenticate(UserLoginVO request)
        {
            var response = await _userService.Login(request.Login, request.Password);             
            if (!response.Success)
            {
                return Unauthorized(response);
            }
            return Ok(response);
        }

        [HttpGet("Logout")]
        public async Task<ActionResult<ServiceResponse<string>>> Logout(UserLoginVO request)
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
        public IActionResult Refresh([FromBody] TokenVO tokenVo)
        { 
            return NoContent();
        } 
        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        { 
            return NoContent();
        }

    }
}