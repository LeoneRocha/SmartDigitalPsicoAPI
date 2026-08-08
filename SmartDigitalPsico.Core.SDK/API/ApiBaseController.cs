using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using System.Globalization;
using System.Security.Claims;

namespace SmartDigitalPsico.Core.SDK.API
{
    /// <summary>
    /// Classe responsável por ApiBaseController.
    /// </summary>
    public abstract class ApiBaseController : ControllerBase
    {
        protected AuthConfigurationDto _configurationAuth;

        protected ApiBaseController(IOptions<AuthConfigurationDto> configurationAuth)
        {
            _configurationAuth = configurationAuth.Value;
        }

        /// <summary>
        /// Configura cultura. Host de produto pode sobrescrever para aplicar idioma do usuário.
        /// </summary>
        protected virtual async Task SetCurrentCulture()
        {
            _ = GetUserIdCurrent();
            await Task.CompletedTask;
        }

        protected virtual void ApplyCulture(CultureInfo cultureInfo)
        {
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }

        protected virtual long GetUserIdCurrent()
        {
            long idUserResult = 0;
            if (User != null && _configurationAuth.TypeApiCredential == Domain.Enuns.ETypeApiCredential.Jwt
                && long.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var idUser))
            {
                idUserResult = idUser;
            }
            return idUserResult;
        }
    }
}
