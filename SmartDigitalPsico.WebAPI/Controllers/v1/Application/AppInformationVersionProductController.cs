using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Controllers.v1
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
        protected virtual AppInformationVersionProductDto? GetInformationVersionProduct()
        {
            return LogAppHelper.GetInformationVersionProduct();
        }

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
            var responseVO = GetInformationVersionProduct();
            if (responseVO != null)
            {
                List<AppInformationVersionProductDto> response = new List<AppInformationVersionProductDto> { responseVO };
                return Ok(response);
            }
            return NotFound(responseVO);
        }
    }
}
