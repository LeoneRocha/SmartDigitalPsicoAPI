using System.Security.Claims;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Helpers.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class SecurityHelperApi
    {
        public static long GetUserIdApi(ClaimsPrincipal user, ETypeApiCredential typeApiCredential)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelperApi.GetUserIdApi(user, typeApiCredential);
    }
}
