using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Patient.PatientFile;
using SmartDigitalPsico.Domain.VO;


namespace SmartDigitalPsico.WebAPI.Controllers.v1.Patient
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/patient/v1/[controller]")]

    public class PatientFileController : ApiBaseController
    {
        private readonly IPatientFileService _entityService;
        private readonly IConfiguration _configuration;

        public PatientFileController(IPatientFileService entityService
            , IOptions<AuthConfigurationDto> configurationAuth
            , IConfiguration configuration) 
            : base(configurationAuth)
        {
            _entityService = entityService;
            _configuration = configuration;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        }
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetPatientFileDto>>>> FindAll(long patientId)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAllByPatient(patientId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetPatientFileDto>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
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


        [HttpGet("Download/{id}")]        
        public async Task<ActionResult> DownloadFileById(long id)
        {
            this.setUserIdCurrent();
            var result = await _entityService.DownloadFileById(id);
            var response = FileHelper.ProccessDownloadToBrowser(DirectoryHelper.GetDiretoryTemp(_configuration), result.FileName);
            return response;
        }

        [HttpPost("Upload")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<GetPatientFileDto>> Create([FromForm] AddPatientFileDtoservice newEntity)
        {
            this.setUserIdCurrent();
            ServiceResponse<GetPatientFileDto> response = new ServiceResponse<GetPatientFileDto>();

            try
            { 
                var addEntity = new AddPatientFileDto() { PatientId = newEntity.PatientId, FileDetails = newEntity.FileDetails, Description = newEntity.Description };
                response.Data = null;
                response.Success = await _entityService.PostFileAsync(addEntity);
                response.Message = $"Upload success!";
                if (!response.Success)
                {
                    response.Message = $"Upload fail";
                    return BadRequest(response);
                }
                return Ok(response);
            }
            catch (Exception)
            {
                response.Message = $"Upload fail";
                return BadRequest(response);
            } 
        } 
    }
}