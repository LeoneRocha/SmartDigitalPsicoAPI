using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;


namespace SmartDigitalPsico.WebAPI.Controllers.v1.Patient
{ 
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/patient/v1/[controller]")]

    public class PatientHospitalizationInformationController : ApiBaseController
    {
        private readonly IPatientHospitalizationInformationService _entityService;
        public PatientHospitalizationInformationController(IPatientHospitalizationInformationService entityService, IOptions<AuthConfigurationVO> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        } 
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<List<GetPatientHospitalizationInformationVO>>>> FindAll(int patientId)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAllByPatient(patientId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationVO>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationVO>>> Create(AddPatientHospitalizationInformationVO newEntity)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.Create(newEntity));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationVO>>> Update(UpdatePatientHospitalizationInformationVO updateEntity)
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent();
            var response = await _entityService.Delete(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

    }
}