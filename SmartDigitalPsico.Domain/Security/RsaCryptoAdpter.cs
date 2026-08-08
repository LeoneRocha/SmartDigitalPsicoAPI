using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class RsaCryptoAdpter : SmartDigitalPsico.Core.SDK.Domain.Security.RsaCryptoAdpter, Interfaces.Security.ICryptoAdpter
    {
        public RsaCryptoAdpter(RSAParameters publicKey, RSAParameters privateKey) : base(publicKey, privateKey) { }

        public RsaCryptoAdpter(string publicKeyBase64, string privateKeyBase64) : base(publicKeyBase64, privateKeyBase64) { }
    }
}
