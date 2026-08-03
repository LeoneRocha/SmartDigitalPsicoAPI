using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.DTO;
using System.Collections.Generic;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por AppInformationVersionProductController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class AppInformationVersionProductController : ControllerBase
    {
        /// <summary>
        /// Método AppInformationVersionProductController: executa a operação AppInformationVersionProductController.
        /// </summary>
        public AppInformationVersionProductController()
        {
        }
        [HttpGet("GetAppInformationVersionProductString")]
        /// <summary>
        /// Método GetString: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<string>> GetString()
        {
            await Task.FromResult(0);
            return Ok(LogAppHelper.ShowInformationVersionProductString());
        }

        [HttpGet("GetAppInformationVersionProduct")]
        /// <summary>
        /// Método Get: consulta e retorna dados.
        /// </summary>
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
