using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security
{
    /// <summary>
    /// Classe responsável por CryptoService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class CryptoService : ICryptoService
    {
        private readonly ECryptoServiceType _cryptoServiceType;
        private readonly string _key;
        private readonly string _ivOrPublicKey;
        private readonly ICryptoAdapterFactory _cryptoAdapterFactory;

        /// <summary>
        /// Método CryptoService: executa a operação CryptoService.
        /// </summary>
        public CryptoService(IConfiguration configuration, ICryptoAdapterFactory cryptoAdapterFactory)
        {
            _key = configuration.GetSection("SecuritySettings:AesSettings")["AesKey"] ?? string.Empty;
            _ivOrPublicKey = configuration.GetSection("SecuritySettings:AesSettings")["AesIv"] ?? string.Empty;
            _cryptoServiceType = ECryptoServiceType.Aes;
            _cryptoAdapterFactory = cryptoAdapterFactory;
        }

        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        public string Encrypt(string plainText)
        {
            return executeEncrypt(_key, plainText);
        }
        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        public string Encrypt(string keyBase64, string plainText)
        {
            return executeEncrypt(keyBase64, plainText);
        } 
        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        public string Decrypt(string cipherTextBase64)
        {
            return executeDecrypt(_key, cipherTextBase64);
        }
        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        public string Decrypt(string keyBase64, string cipherTextBase64)
        {
            return executeDecrypt(keyBase64, cipherTextBase64);
        }
        #region PRIVATE
        private string executeEncrypt(string keyBase64, string plainText)
        {
            var cryptoAdpter = _cryptoAdapterFactory.Create(_cryptoServiceType, keyBase64, _ivOrPublicKey);
            var cipherText = cryptoAdpter.Encrypt(plainText);

            var cipherTextBase64 = Convert.ToBase64String(cipherText);
            return cipherTextBase64;
        }
        private string executeDecrypt(string keyBase64, string cipherTextBase64)
        {
            if (!string.IsNullOrWhiteSpace(cipherTextBase64) && SecurityHelper.IsBase64String(cipherTextBase64))
            {
                var cryptoAdapter = _cryptoAdapterFactory.Create(_cryptoServiceType, keyBase64, _ivOrPublicKey);

                var cipherTextBytes = Convert.FromBase64String(cipherTextBase64);

                var plainText = cryptoAdapter.Decrypt(cipherTextBytes);
                return plainText;
            }
            return string.Empty;
        }
        #endregion
    }
}
