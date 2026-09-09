using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Casca fábrica crypto — cria adapters SDP (herdam SCH); enum surface permanece <c>Enuns</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Security.Cryptography.CryptoAdapterFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca Create com ECryptoServiceType SDP (Enuns); adapters herdam SCH.")]
public class CryptoAdapterFactory : ICryptoAdapterFactory
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
