using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{ 
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    public class RoleGroupController : ApiBaseController
    {
        private readonly IRoleGroupService _entityService;

        public RoleGroupController(IRoleGroupService entityService
             , IOptions<AuthConfigurationVO> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        } 
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetRoleGroupVO>>>> Get()
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetRoleGroupVO>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetRoleGroupVO>>> Create(AddRoleGroupVO newEntity)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Create(newEntity);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);  
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetRoleGroupVO>>> Update(UpdateRoleGroupVO updateEntity)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Update(updateEntity);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        } 

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Delete(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}