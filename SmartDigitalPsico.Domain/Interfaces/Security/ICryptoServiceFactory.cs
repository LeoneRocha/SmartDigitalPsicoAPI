using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoServiceFactory
    {
        ICryptoAdpter CreateCryptoService(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}
