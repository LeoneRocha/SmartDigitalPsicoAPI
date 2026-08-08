using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.DTO.Security
{
    /// <summary>
    /// Classe responsável por RsaCryptoDto.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class RsaCryptoDto
    {
        public RSAParameters PublicKey { get; set; }
        public RSAParameters PrivateKey { get; set; }
        public string PublicKeyBase64 { get; set; } = string.Empty;
        public string PrivateKeyBase64 { get; set; } = string.Empty;
    }
}
