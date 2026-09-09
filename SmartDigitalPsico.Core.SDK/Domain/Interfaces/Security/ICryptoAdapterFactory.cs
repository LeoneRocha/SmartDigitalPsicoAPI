using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

/// <summary>
/// Contrato fábrica crypto — surface SDP com enum <c>Enuns</c> (não herda SCH por divergência Enuns/Enums).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Security.ICryptoAdapterFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; Create usa ECryptoServiceType em Domain.Enuns.")]
public interface ICryptoAdapterFactory
{
    ICryptoAdpter Create(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
}
