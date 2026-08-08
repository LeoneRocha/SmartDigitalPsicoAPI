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
    /// Classe responsável por GlobalizationTimeZonesController.
    /// Responsabilidade: controller HTTP da WebAPI.
    /// Relação: expõe endpoints REST e delega para Services/Facades.
    /// </summary>
    public class GlobalizationTimeZonesController : ControllerBase
    {
        /// <summary>
        /// Método GlobalizationTimeZonesController: executa a operação GlobalizationTimeZonesController.
        /// </summary>
        public GlobalizationTimeZonesController()
        {
        } 
        [HttpGet("GetTimeZones")]
        /// <summary>
        /// Método Get: consulta e retorna dados.
        /// </summary>
        public async Task<ActionResult<List<SmartDigitalPsico.Core.SDK.Domain.DTO.TimeZoneDisplayDto>>> Get()
        {
            await Task.FromResult(0);
            return Ok(SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZonesIds());
        }
    }
}
