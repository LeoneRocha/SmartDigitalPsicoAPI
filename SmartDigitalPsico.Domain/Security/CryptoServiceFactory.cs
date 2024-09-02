using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Domain.Security
{
    public class CryptoServiceFactory : ICryptoServiceFactory
    {
        public ICryptoAdpter Create(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey)
        {
            switch (cryptoServiceType)
            {
                case ECryptoServiceType.Aes:
                    return new AesCryptoAdpter(key, ivOrPublicKey);
                case ECryptoServiceType.Rsa:
                    return new RsaCryptoAdpter(ivOrPublicKey, key);
                default:
                    throw new ArgumentException("Invalid crypto service type", nameof(cryptoServiceType));
            }
        }
    }
}