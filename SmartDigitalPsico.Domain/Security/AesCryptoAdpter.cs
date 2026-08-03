using SmartDigitalPsico.Domain.Interfaces.Security;
using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Security
{
    //https://propertyguru.tech/doing-aes-encryption-correct-in-your-net-application-5d66168b5b44
    /// <summary>
    /// Classe responsável por AesCryptoAdpter.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AesCryptoAdpter : ICryptoAdpter
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        /// <summary>
        /// Método AesCryptoAdpter: executa a operação AesCryptoAdpter.
        /// </summary>
        public AesCryptoAdpter(byte[] key, byte[] iv)
        {
            _key = key ?? throw new ArgumentNullException(nameof(key));
            _iv = iv ?? throw new ArgumentNullException(nameof(iv));
        }
        /// <summary>
        /// Método AesCryptoAdpter: executa a operação AesCryptoAdpter.
        /// </summary>
        public AesCryptoAdpter(string base64Key, string base64IV)   
        { 
            _key = Convert.FromBase64String(base64Key);
            _iv = Convert.FromBase64String(base64IV);
        }

        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        public byte[] Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentException("Text cannot be null or empty", nameof(plainText));

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = _key;
                aesAlg.IV = _iv;

                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        public string Decrypt(byte[] cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentException("Cipher text cannot be null or empty", nameof(cipherText));

            try
            {
                using (var aesAlg = Aes.Create())
                {
                    aesAlg.Key = _key;
                    aesAlg.IV = _iv;

                    var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (var msDecrypt = new MemoryStream(cipherText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            } 
        }
    }
}
