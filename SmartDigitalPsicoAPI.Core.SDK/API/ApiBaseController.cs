using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.Security;
using System.Globalization;
using System.Security.Claims;

namespace SmartDigitalPsicoAPI.Core.SDK.API
{
    /// <summary>
    /// Classe responsável por ApiBaseController.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class ApiBaseController : ControllerBase
    {
        protected AuthConfigurationDto _configurationAuth;

        /// <summary>
        /// Método ApiBaseController: executa a operação ApiBaseController.
        /// </summary>
        protected ApiBaseController(IOptions<AuthConfigurationDto> configurationAuth)
        {
            _configurationAuth = configurationAuth.Value;
        }

        /// <summary>
        /// Método SetCurrentCulture: configura estado ou dependencias.
        /// </summary>
        protected async Task SetCurrentCulture()
        {
            long userId = GetUserIdCurrent();
            // User culture logic decoupled from ApiBaseController in SDK.
            // Should be handled by RequestCultureMiddleware or a specific ICultureProvider.
            await Task.CompletedTask;
        }

        /// <summary>
        /// Aplica a cultura corrente da requisição. Extensível para testes (AsyncLocal não flui ao caller).
        /// </summary>
        protected virtual void ApplyCulture(CultureInfo cultureInfo)
        {
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }

        protected long GetUserIdCurrent()
        {
            long idUserResult = 0;
            if (User != null && _configurationAuth.TypeApiCredential == SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt && long.TryParse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier), out var idUser))
            {
                idUserResult = idUser;
            }
            return idUserResult;
        }
    }
}
