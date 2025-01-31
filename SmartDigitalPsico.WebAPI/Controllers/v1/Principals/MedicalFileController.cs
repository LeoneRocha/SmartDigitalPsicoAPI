using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Principals
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/medical/v1/[controller]")]

    public class MedicalFileController : ApiBaseController
    {
        private readonly IMedicalFileService _entityService;
        private readonly IConfiguration _configuration;

        public MedicalFileController(IMedicalFileService entitytService
            , IOptions<AuthConfigurationDto> configurationAuth,
            IConfiguration configuration)
            : base(configurationAuth)
        {
            _entityService = entitytService;
            _configuration = configuration;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(base.GetUserIdCurrent());
        }

        [HttpGet("FindAll")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<List<GetMedicalFileDto>>>> FindAll(long medicalId)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindAllByMedical(medicalId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetMedicalFileDto>>> FindByID(long id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Delete(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("Download/{id}")]
        public async Task<ActionResult> DownloadFileById(long id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var result = await _entityService.DownloadFileById(id);
            var response = FileHelper.ProccessDownloadToBrowser(DirectoryHelper.GetDiretoryTemp(_configuration), result.FileName);
            return response;
        }

        [HttpPost("Upload")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetMedicalFileDto>>> Create([FromForm] AddMedicalFileDtoService newEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            try
            {
                var addEntity = new AddMedicalFileDto() { MedicalId = newEntity.MedicalId, FileDetails = newEntity.FileDetails, Description = newEntity.Description };
                var response = await _entityService.PostFileAsync(addEntity);
                response.Data = null;
                if (!response.Success)
                {
                    response.Message = $"Upload fail";
                    return BadRequest(response);
                }
                response.Message = $"Upload success!";
                return Ok(response);
            }
            catch (Exception)
            {
                var response = new ServiceResponse<GetMedicalFileDto>
                {
                    Message = $"Upload fail"
                };
                return BadRequest(response);
            }
        }
    }
}