using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]  
    [Route("api/[controller]/v1")]
    public class AppInformationVersionProductController : ControllerBase
    {
        public AppInformationVersionProductController()
        {
        } 
        [HttpGet("GetAppInformationVersionProduct")]
        public async Task<ActionResult<string>> Get()
        {
            await Task.FromResult(0);
            return Ok(LogAppHelper.ShowInformationVersionProduct());
        }
    }
}