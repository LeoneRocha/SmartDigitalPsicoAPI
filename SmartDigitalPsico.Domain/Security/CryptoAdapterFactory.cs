using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por CryptoAdapterFactory.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class CryptoAdapterFactory : ICryptoAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
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
