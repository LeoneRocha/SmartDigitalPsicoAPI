using System.Security.Cryptography;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Security
{
    /// <summary>
    /// Classe responsável por RsaCryptoDto.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class RsaCryptoDto
    {
        public RSAParameters PublicKey { get; set; }
        public RSAParameters PrivateKey { get; set; }
        public string PublicKeyBase64 { get; set; } = string.Empty;
        public string PrivateKeyBase64 { get; set; } = string.Empty;
    }
}
