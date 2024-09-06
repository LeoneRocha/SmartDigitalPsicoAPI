using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Security
{
    public class CryptoService : ICryptoService
    {
        private readonly ECryptoServiceType _cryptoServiceType;
        private readonly string _key;
        private readonly string _ivOrPublicKey;

        private readonly ICryptoAdapterFactory _cryptoAdapterFactory;

        public CryptoService(ICryptoAdapterFactory cryptoAdapterFactory)
        {
            _key = "kuPiJg4r/IY1dTndthO56883V+SdxxPMahlIzCz32KM=";//Mudar para appConfig e depois config do medico
            _ivOrPublicKey = "37mVgkf+tXUTlaEhBPUIeA==";//Mudar para appConfig e depois config do medico 
            _cryptoServiceType = ECryptoServiceType.Aes;  //Mudar para appConfig e depois config do medico 
            _cryptoAdapterFactory = cryptoAdapterFactory;
        }

        public string Encrypt(string plainText)
        {
            var cryptoAdpter = _cryptoAdapterFactory.Create(_cryptoServiceType, _key, _ivOrPublicKey);
            var cipherText = cryptoAdpter.Encrypt(plainText);

            var cipherTextBase64 = Convert.ToBase64String(cipherText);
            return cipherTextBase64;
        }

        public string Decrypt(string cipherTextBase64)
        {
            if (!string.IsNullOrWhiteSpace(cipherTextBase64) && SecurityHelper.IsBase64String(cipherTextBase64))
            {
                var cryptoService = _cryptoAdapterFactory.Create(_cryptoServiceType, _key, _ivOrPublicKey);

                var cipherTextBytes = Convert.FromBase64String(cipherTextBase64);

                var plainText = cryptoService.Decrypt(cipherTextBytes);
                return plainText;
            }
            return string.Empty;
        }
    }
}
