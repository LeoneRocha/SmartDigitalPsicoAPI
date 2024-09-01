using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Security
{
    public class CryptoService : ICryptoService
    {
        private readonly ECryptoServiceType _cryptoServiceType;
        private readonly string _key;
        private readonly string _ivOrPublicKey;
         
        private readonly ICryptoServiceFactory _cryptoServiceFactory;

        public CryptoService(ICryptoServiceFactory cryptoServiceFactory)
        {
            _key = "kuPiJg4r/IY1dTndthO56883V+SdxxPMahlIzCz32KM=";//Mudar para appConfig e depois config do medico
            _ivOrPublicKey = "37mVgkf+tXUTlaEhBPUIeA==";//Mudar para appConfig e depois config do medico 
            _cryptoServiceType = ECryptoServiceType.Aes;  //Mudar para appConfig e depois config do medico 
            _cryptoServiceFactory = cryptoServiceFactory;
        }

        public byte[] Encrypt(string plainText)
        {
            var cryptoService = _cryptoServiceFactory.CreateCryptoService(_cryptoServiceType, _key, _ivOrPublicKey);
            return cryptoService.Encrypt(plainText);
        }

        public string Decrypt(byte[] cipherText)
        {
            var cryptoService = _cryptoServiceFactory.CreateCryptoService(_cryptoServiceType, _key, _ivOrPublicKey);
            return cryptoService.Decrypt(cipherText);
        }
    }
}
