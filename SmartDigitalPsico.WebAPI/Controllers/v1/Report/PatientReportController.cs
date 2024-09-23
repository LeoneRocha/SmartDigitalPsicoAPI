using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Report.Patient;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.Report
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/report/patient/v1/[controller]")]

    public class PatientReportController : ApiBaseController
    {
        private readonly IPatientReportService _entityService;

        public PatientReportController(IPatientReportService entityService, IOptions<AuthConfigurationVO> configurationAuth) : base(configurationAuth)
        {
            _entityService = entityService;
        }
        private void setUserIdCurrent()
        {
            _entityService.SetUserId(GetUserIdCurrent());
        }
       
        [HttpGet("{id}")] 
        public async Task<ActionResult<ServiceResponse<PatientDetailReportVO>>> GetPatientDetailsByIdAsync(long id)
        {
            setUserIdCurrent();
            return Ok(await _entityService.GetPatientDetailsByIdAsync(id));
        } 
    }
}
