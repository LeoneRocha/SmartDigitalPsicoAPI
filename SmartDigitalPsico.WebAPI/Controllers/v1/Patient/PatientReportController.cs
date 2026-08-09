using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Report.Entity;
using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.WebAPI.Controllers.v1
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/report/patient/v1/[controller]")]

    /// <summary>
    /// Classe responsável por PatientReportController.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientReportController : Domain.API.ApiBaseController
    {
        private readonly IPatientReportService _entityService;

        /// <summary>
        /// Método PatientReportController: executa a operação PatientReportController.
        /// </summary>
        public PatientReportController(IPatientReportService entityService
            , IOptions<AuthConfigurationDto> configurationAuth
            ) : base(configurationAuth)
        {
            _entityService = entityService;

        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(GetUserIdCurrent());
        }

        [HttpGet("{id}")]
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<ServiceResponse<PatientDetailReportDto>>> GetPatientDetailsByIdAsync(long id)
        {
            setUserIdCurrent();
            return Ok(await _entityService.GetPatientDetailsByIdAsync(id));
        }

        [HttpGet("Download/{id}")]
        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        public async Task<ActionResult> DownloadFileById(long id)
        {
            this.setUserIdCurrent(); await base.SetCurrentCulture();
            FileContentResult response = await _entityService.DownloadReportPatientDetailsById(id, EReportOutputType.Pdf);
            return response;
        }
    }
}
