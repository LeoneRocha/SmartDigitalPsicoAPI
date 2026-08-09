using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.WebAPI.Controllers.v1
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/patient/v1/[controller]")]

    /// <summary>
    /// Classe responsável por PatientFileController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class PatientFileController : Domain.API.ApiBaseController
    {
        private readonly IPatientFileService _entityService;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Método PatientFileController: executa a operação PatientFileController.
        /// </summary>
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
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<List<GetPatientFileDto>>>> FindAll(long patientId)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindAllByPatient(patientId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetPatientFileDto>>> FindByID(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindByID(id));
        }

        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<bool>>> Delete(int id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var response = await _entityService.Delete(id);
            if (response.Data)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("Download/{id}")]
        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        public async Task<ActionResult> DownloadFileById(long id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            var result = await _entityService.DownloadFileById(id);
            var response = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_configuration), result.FileName);
            return response;
        }

        [HttpPost("Upload")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ActionResult<GetPatientFileDto>> Create([FromForm] AddPatientFileDtoservice newEntity)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
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
