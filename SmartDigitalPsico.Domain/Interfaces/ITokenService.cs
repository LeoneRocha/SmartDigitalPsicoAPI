using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Shim Obsolete — contrato canônico em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ITokenService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.ITokenService
    {
    }
}
