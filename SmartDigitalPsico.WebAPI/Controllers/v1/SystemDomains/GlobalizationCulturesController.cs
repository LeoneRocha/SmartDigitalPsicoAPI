using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.DTO;

namespace SmartDigitalPsico.WebAPI.Controllers.v1.SystemDomains
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v1")]
    /// <summary>
    /// Classe responsável por GlobalizationCulturesController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class GlobalizationCulturesController : ControllerBase
    {
        /// <summary>
        /// Método GlobalizationCulturesController: executa a operação GlobalizationCulturesController.
        /// </summary>
        public GlobalizationCulturesController()
        {
        }

        [HttpGet("GetCultures")] 
        /// <summary>
        /// Método Get: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<List<CultureDisplayDto>>> Get()
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
