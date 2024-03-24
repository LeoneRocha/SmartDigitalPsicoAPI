using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]  
    [Route("api/[controller]/v{version:apiVersion}")]
    public class GlobalizationTimeZonesController : ControllerBase
    {
        public GlobalizationTimeZonesController()
        {
        } 
        [HttpGet("GetTimeZones")]
        public async Task<ActionResult<List<TimeZoneDisplay>>> Get()
        {
            await Task.FromResult(0);
            return Ok(CultureDateTimeHelper.GetTimeZonesIds());
        }
    }
}