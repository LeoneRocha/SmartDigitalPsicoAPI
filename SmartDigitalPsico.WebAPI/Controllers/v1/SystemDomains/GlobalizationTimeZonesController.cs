using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.DTO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    public class GlobalizationTimeZonesController : ControllerBase
    {
        public GlobalizationTimeZonesController()
        {
        } 
        [HttpGet("GetTimeZones")]
        public async Task<ActionResult<List<TimeZoneDisplayDto>>> Get()
        {
            await Task.FromResult(0);
            return Ok(CultureDateTimeHelper.GetTimeZonesIds());
        }
    }
}