using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Report.Enitty;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Report
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/report/patient/v1/[controller]")]

    public class PatientReportController : ApiBaseController
    {
        private readonly IPatientReportService _entityService;

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
        public async Task<ActionResult<ServiceResponse<PatientDetailReportDto>>> GetPatientDetailsByIdAsync(long id)
        {
            setUserIdCurrent();
            return Ok(await _entityService.GetPatientDetailsByIdAsync(id));
        }

        [HttpGet("Download/{id}")]
        public async Task<ActionResult> DownloadFileById(long id)
        {
            this.setUserIdCurrent();
            FileContentResult response = await _entityService.DownloadReportPatientDetailsById(id);
            return response;
        }
    }
}
