using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.Common;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET;
using SmartDigitalPsico.Domain.Interfaces.Medical;
namespace SmartDigitalPsico.WebAPI.Controllers.v1
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/medical/v1/[controller]")]

    /// <summary>
    /// Classe responsável por MedicalFileController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class MedicalFileController : Domain.API.ApiBaseController
    {
        private readonly IMedicalFileService _entityService;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Método MedicalFileController: executa a operação MedicalFileController.
        /// </summary>
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
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<List<GetMedicalFileDto>>>> FindAll(long medicalId)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            return Ok(await _entityService.FindAllByMedical(medicalId));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilterrAttribute))]
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<GetMedicalFileDto>>> FindByID(long id)
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
            if (!response.Success)
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
