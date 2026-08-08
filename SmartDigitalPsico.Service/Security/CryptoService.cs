using Microsoft.Extensions.Configuration;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Service.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_CRYPTO")]
    public class CryptoService : SmartDigitalPsicoAPI.Core.SDK.Domain.Security.CryptoService
    {
        public CryptoService(IConfiguration configuration, ICryptoAdapterFactory cryptoAdapterFactory)
            : base(configuration, cryptoAdapterFactory)
        {
        }
    }
}
