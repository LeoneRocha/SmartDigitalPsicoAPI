using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.VO;
namespace SmartDigitalPsico.WebAPI.Controllers.v1.Principals
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    public class UserController : ApiBaseController
    {
        private readonly IUserService _entityService;

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
        public async Task<ActionResult<ServiceResponse<List<GetUserDto>>>> FindAll()
        {
            this.setUserIdCurrent();
            var response = await _entityService.FindAll();
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response); 
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.FindByID(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
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
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> Update(UpdateUserDto updateEntity)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Update(updateEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPatch]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> UpdateProfile(UpdateUserProfileDto updateEntity)
        {
            this.setUserIdCurrent();
            var response = await _entityService.UpdateProfile(updateEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Delete(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}