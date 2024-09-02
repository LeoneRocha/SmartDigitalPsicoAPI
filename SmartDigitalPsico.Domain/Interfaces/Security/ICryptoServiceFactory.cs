using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoServiceFactory
    {
        ICryptoAdpter Create(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}
