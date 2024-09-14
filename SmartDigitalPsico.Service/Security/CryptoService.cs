using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Service.Security
{
    public class CryptoService : ICryptoService
    {
        private readonly ECryptoServiceType _cryptoServiceType;
        private readonly string _key;
        private readonly string _ivOrPublicKey;
        private readonly ICryptoAdapterFactory _cryptoAdapterFactory;

        public CryptoService(IConfiguration configuration, ICryptoAdapterFactory cryptoAdapterFactory)
        {
            _key = ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesKey(configuration);
            _ivOrPublicKey = ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesIv(configuration);
            _cryptoServiceType = ECryptoServiceType.Aes;
            _cryptoAdapterFactory = cryptoAdapterFactory;
        }

        public string Encrypt(string plainText)
        {
            return executeEncrypt(_key, plainText);
        }
        public string Encrypt(string keyBase64, string plainText)
        {
            return executeEncrypt(keyBase64, plainText);
        } 
        public string Decrypt(string cipherTextBase64)
        {
            return executeDecrypt(_key, cipherTextBase64);
        }
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