using SmartDigitalPsico.Domain.Interfaces.Security;
using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Security
{
    //https://propertyguru.tech/doing-aes-encryption-correct-in-your-net-application-5d66168b5b44
    public class AesCryptoAdpter : ICryptoAdpter
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public AesCryptoAdpter(byte[] key, byte[] iv)
        {
            _key = key ?? throw new ArgumentNullException(nameof(key));
            _iv = iv ?? throw new ArgumentNullException(nameof(iv));
        }
        public AesCryptoAdpter(string base64Key, string base64IV)   
        { 
            _key = Convert.FromBase64String(base64Key);
            _iv = Convert.FromBase64String(base64IV);
        }

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
