using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Security;
using System.Security.Cryptography;
using System.Text;

namespace SmartDigitalPsico.Domain.Security
{
    public class RsaCryptoAdpter : ICryptoAdpter
    {
        private readonly RSAParameters _publicKey;
        private readonly RSAParameters _privateKey;

        public RsaCryptoAdpter(RSAParameters publicKey, RSAParameters privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
        }

        public RsaCryptoAdpter(string publicKeyBase64, string privateKeyBase64)
        {
            _publicKey = RsaCryptoServiceHelper.ConvertFromBase64(publicKeyBase64, RSAEncryptionPadding.OaepSHA256);
            _privateKey = RsaCryptoServiceHelper.ConvertFromBase64(privateKeyBase64, RSAEncryptionPadding.OaepSHA256);
        }

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
