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
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;

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
            , IOptions<AuthConfigurationVO> configurationAuth,
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
        public async Task<ActionResult<ServiceResponse<List<GetMedicalFileVO>>>> FindAll(long medicalId)
        {
            this.setUserIdCurrent();
            return Ok(await _entityService.FindAllByMedical(medicalId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        public async Task<ActionResult<ServiceResponse<GetMedicalFileVO>>> FindByID(long id)
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
            if (!response.Success)
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
        public async Task<ActionResult<ServiceResponse<GetMedicalFileVO>>> Create([FromForm] AddMedicalFileVOService newEntity)
        {
            this.setUserIdCurrent();
            ServiceResponse<GetMedicalFileVO> response = new ServiceResponse<GetMedicalFileVO>();

            try
            {
                var addEntity = new AddMedicalFileVO() { MedicalId = newEntity.MedicalId, FileDetails = newEntity.FileDetails, Description = newEntity.Description };
                response = await _entityService.PostFileAsync(addEntity);
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
                response.Message = $"Upload fail";
                return BadRequest(response);
            }
        }
    }
}