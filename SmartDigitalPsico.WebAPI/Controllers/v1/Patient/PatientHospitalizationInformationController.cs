using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.VO;


namespace SmartDigitalPsico.WebAPI.Controllers.v1.Patient
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/patient/v1/[controller]")]

    public class PatientHospitalizationInformationController : ApiBaseController
    {
        private readonly IPatientHospitalizationInformationService _entityService;
        public PatientHospitalizationInformationController(IPatientHospitalizationInformationService entityService, IOptions<AuthConfigurationDto> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        } 
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetPatientHospitalizationInformationDto>>>> FindAll(int patientId)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAllByPatient(patientId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationDto>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationDto>>> Create(AddPatientHospitalizationInformationDto newEntity)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.Create(newEntity));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetPatientHospitalizationInformationDto>>> Update(UpdatePatientHospitalizationInformationDto updateEntity)
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
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
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