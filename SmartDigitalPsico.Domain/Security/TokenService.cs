using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class TokenService : SmartDigitalPsico.Core.SDK.Domain.Security.TokenService, Interfaces.ITokenService
    {
        public TokenService(TokenConfigurationDto configuration) : base(configuration)
        {
        }
    }
}
