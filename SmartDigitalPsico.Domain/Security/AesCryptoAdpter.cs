namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class AesCryptoAdpter : SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter, Interfaces.Security.ICryptoAdpter
    {
        public AesCryptoAdpter(byte[] key, byte[] iv) : base(key, iv) { }

        public AesCryptoAdpter(string base64Key, string base64IV) : base(base64Key, base64IV) { }
    }
}
