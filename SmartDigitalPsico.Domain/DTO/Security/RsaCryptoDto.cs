using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.DTO.Security
{
    public class RsaCryptoDto
    {
        public RSAParameters PublicKey { get; set; }
        public RSAParameters PrivateKey { get; set; }
        public string PublicKeyBase64 { get; set; } = string.Empty;
        public string PrivateKeyBase64 { get; set; } = string.Empty;
    }
}
