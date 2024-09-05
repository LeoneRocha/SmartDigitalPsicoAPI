using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoAdapterFactory
    {
        ICryptoAdpter Create(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}
