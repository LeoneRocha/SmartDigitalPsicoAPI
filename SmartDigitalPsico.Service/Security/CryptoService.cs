using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Security
{
    public class CryptoService : ICryptoService
    {
        private readonly ICryptoServiceFactory _cryptoServiceFactory;

        public CryptoService(ICryptoServiceFactory cryptoServiceFactory)
        {
            _cryptoServiceFactory = cryptoServiceFactory;
        }

        public byte[] Encrypt(string plainText, ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey)
        {
            var cryptoService = _cryptoServiceFactory.CreateCryptoService(cryptoServiceType, key, ivOrPublicKey);
            return cryptoService.Encrypt(plainText);
        }

        public string Decrypt(byte[] cipherText, ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey)
        {
            var cryptoService = _cryptoServiceFactory.CreateCryptoService(cryptoServiceType, key, ivOrPublicKey);
            return cryptoService.Decrypt(cipherText);
        }
    }
}
