using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController] 
    [Route("api/[controller]/v1")]
    public class GlobalizationCulturesController : ControllerBase
    {
        public GlobalizationCulturesController()
        {
        }

        [HttpGet("GetCultures")] 
        public async Task<ActionResult<List<CultureDisplayVO>>> Get()
        { 
            await Task.FromResult(0);
            var response = CultureDateTimeHelper.GetCultures();
            if (response.Count <= 0)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}