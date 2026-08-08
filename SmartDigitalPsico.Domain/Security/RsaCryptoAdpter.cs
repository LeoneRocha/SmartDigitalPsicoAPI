using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Security;
using System.Security.Cryptography;
using System.Text;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsÃ¡vel por RsaCryptoAdpter.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// RelaÃ§Ã£o: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class RsaCryptoAdpter : ICryptoAdpter
    {
        private readonly RSAParameters _publicKey;
        private readonly RSAParameters _privateKey;

        /// <summary>
        /// MÃ©todo RsaCryptoAdpter: executa a operaÃ§Ã£o RsaCryptoAdpter.
        /// </summary>
        public RsaCryptoAdpter(RSAParameters publicKey, RSAParameters privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
        }

        /// <summary>
        /// MÃ©todo RsaCryptoAdpter: executa a operaÃ§Ã£o RsaCryptoAdpter.
        /// </summary>
        public RsaCryptoAdpter(string publicKeyBase64, string privateKeyBase64)
        {
            _publicKey = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertFromBase64(publicKeyBase64, RSAEncryptionPadding.OaepSHA256);
            _privateKey = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertFromBase64(privateKeyBase64, RSAEncryptionPadding.OaepSHA256);
        }

        /// <summary>
        /// MÃ©todo Encrypt: executa a operaÃ§Ã£o Encrypt.
        /// </summary>
        public byte[] Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentException("Text cannot be null or empty", nameof(plainText));

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(_publicKey);
                return rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), RSAEncryptionPadding.OaepSHA256);
            }
        }

        /// <summary>
        /// MÃ©todo Decrypt: executa a operaÃ§Ã£o Decrypt.
        /// </summary>
        public string Decrypt(byte[] cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentException("Cipher text cannot be null or empty", nameof(cipherText));

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(_privateKey);
                return Encoding.UTF8.GetString(rsa.Decrypt(cipherText, RSAEncryptionPadding.OaepSHA256));
            }
        }
    }
}
