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
    public class ApplicationConfigSettingController : ApiBaseController
    {
        private readonly IApplicationConfigSettingService _entityService; 
        public ApplicationConfigSettingController(IApplicationConfigSettingService entityService
            , IOptions<AuthConfigurationVO> configurationAuth) :base (configurationAuth)
        {
            _entityService = entityService; 
        }
        private void setUserIdCurrent()
        { 
            _entityService.SetUserId(base.GetUserIdCurrent());
        }

        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetApplicationConfigSettingVO>>>> Get()
        {
            this.setUserIdCurrent();
            var result = _entityService.FindAll();
            return Ok(await result);
        }
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetApplicationConfigSettingVO>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetApplicationConfigSettingVO>>> Create(AddApplicationConfigSettingVO newEntity)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.Create(newEntity));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetApplicationConfigSettingVO>>> Update(UpdateApplicationConfigSettingVO updateEntity)
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
            if (response.Data)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}