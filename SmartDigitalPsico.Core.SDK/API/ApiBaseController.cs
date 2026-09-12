using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

namespace SmartDigitalPsico.Core.SDK.API
{
    /// <summary>
    /// Classe responsável por ApiBaseController.
    /// KeepBoth vs SCH <c>BaseApiController</c>: SDP usa <see cref="AuthConfigurationDto"/> +
    /// <c>ETypeApiCredential</c> (Enuns) e cultura JWT; SCH usa claims de aplicação / UserContext.
    /// Não herda SCH (AuthConfigurationDto e propósito divergem).
    /// </summary>
    [SdkWrappedSource(
        targetType: "SmartCoreHub.Core.SDK.Service.API.Generic.BaseApiController",
        targetPackage: "SmartCoreHub.Core.SDK",
        description: "KeepBoth: casca SDP com AuthConfigurationDto/enum Enuns + cultura JWT; SCH BaseApiController é claims/app context.")]
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
