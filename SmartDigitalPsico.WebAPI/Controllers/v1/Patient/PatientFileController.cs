using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;


namespace SmartDigitalPsico.WebAPI.Controllers.v1.Patient
{
    [ApiController] 
    [Authorize("Bearer")]
    [Route("api/patient/v1/[controller]")]

    public class PatientFileController : ApiBaseController
    {
        private readonly IPatientFileService _entityService; 
        public PatientFileController(IPatientFileService entityService, IOptions<AuthConfigurationVO> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        } 
        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<List<GetPatientFileVO>>>> Get()
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<ServiceResponse<GetPatientFileVO>>> FindByID(int id)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
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
            var response = FileHelper.ProccessDownloadToBrowser(FolderConstants.ConstResourcesTemp, result.FileName);
            return response;
        }

        [HttpPost("Upload")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<ActionResult<GetPatientFileVO>> Create([FromForm] AddPatientFileVOService newEntity)
        {
            this.setUserIdCurrent();
            ServiceResponse<GetPatientFileVO> response = new ServiceResponse<GetPatientFileVO>();

            try
            { 
                var addEntity = new AddPatientFileVO() { PatientId = newEntity.PatientId, FileDetails = newEntity.FileDetails, Description = newEntity.Description };
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