using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Service.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_CRYPTO")]
    public class CryptoService : SmartDigitalPsico.Core.SDK.Domain.Security.CryptoService
    {
        public CryptoService(IConfiguration configuration, ICryptoAdapterFactory cryptoAdapterFactory)
            : base(configuration, cryptoAdapterFactory)
        {
        }
    }
}
