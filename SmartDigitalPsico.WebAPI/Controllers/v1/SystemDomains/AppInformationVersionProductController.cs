using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.DTO;
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
        public async Task<ActionResult<List<AppInformationVersionProductDto>>> Get()
        {
            await Task.FromResult(0);
            var responseVO = LogAppHelper.GetInformationVersionProduct();
            if (responseVO != null)
            {
                List<AppInformationVersionProductDto> response = new List<AppInformationVersionProductDto> { responseVO };
                return Ok(response);
            }
            return NotFound(responseVO);
        }
    }
}