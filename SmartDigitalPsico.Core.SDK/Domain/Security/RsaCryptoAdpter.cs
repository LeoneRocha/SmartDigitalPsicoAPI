using System.Security.Cryptography;
using System.Text;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security
{
    /// <summary>
    /// Classe responsável por RsaCryptoAdpter.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class RsaCryptoAdpter : ICryptoAdpter
    {
        private readonly RSAParameters _publicKey;
        private readonly RSAParameters _privateKey;

        /// <summary>
        /// Método RsaCryptoAdpter: executa a operação RsaCryptoAdpter.
        /// </summary>
        public RsaCryptoAdpter(RSAParameters publicKey, RSAParameters privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
        }

        /// <summary>
        /// Método RsaCryptoAdpter: executa a operação RsaCryptoAdpter.
        /// </summary>
        public RsaCryptoAdpter(string publicKeyBase64, string privateKeyBase64)
        {
            _publicKey = RsaCryptoServiceHelper.ConvertFromBase64(publicKeyBase64, RSAEncryptionPadding.OaepSHA256);
            _privateKey = RsaCryptoServiceHelper.ConvertFromBase64(privateKeyBase64, RSAEncryptionPadding.OaepSHA256);
        }

        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
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
        /// Método Decrypt: executa a operação Decrypt.
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
