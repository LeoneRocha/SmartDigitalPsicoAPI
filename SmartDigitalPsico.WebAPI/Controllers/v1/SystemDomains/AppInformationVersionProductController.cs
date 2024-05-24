using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.VO;
using System.Collections.Generic;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Route("api/[controller]/v1")]
    public class AppInformationVersionProductController : ControllerBase
    {
        public AppInformationVersionProductController()
        {
        }
        [HttpGet("GetAppInformationVersionProductString")]
        public async Task<ActionResult<string>> GetString()
        {
            await Task.FromResult(0);
            return Ok(LogAppHelper.ShowInformationVersionProductString());
        }

        [HttpGet("GetAppInformationVersionProduct")]
        public async Task<ActionResult<List<AppInformationVersionProductVO>>> Get()
        {
            await Task.FromResult(0);
            var responseVO = LogAppHelper.GetInformationVersionProduct();
            List<AppInformationVersionProductVO> response = new List<AppInformationVersionProductVO> { responseVO };
            if (response.Count <= 0)
            {
                return NotFound(response);
            }
            return Ok(response);
        } 
    }
}