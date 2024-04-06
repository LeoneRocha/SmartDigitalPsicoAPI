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
    public class SpecialtyController : ApiBaseController
    {
        private readonly ISpecialtyService _entityService;

        public SpecialtyController(ISpecialtyService entityService
             , IOptions<AuthConfigurationVO> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        }
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<List<GetSpecialtyVO>>>> Get()
        {
                this.setUserIdCurrent();
            var response = await _entityService.FindAll();
            if (response.Data == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetSpecialtyVO>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.FindByID(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetSpecialtyVO>>> Create(AddSpecialtyVO newEntity)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Create(newEntity);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetSpecialtyVO>>> Update(UpdateSpecialtyVO updateEntity)
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
            //TODO: 1) SE TIVER ERROS RESPONDER BAD REQUEST 
            return Ok(response);
        }
    }
}