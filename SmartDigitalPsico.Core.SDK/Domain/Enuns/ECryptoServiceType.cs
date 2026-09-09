using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca: enum espelho de algoritmo crypto (namespace SDP <c>Enuns</c> estável).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ECryptoServiceType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho com valores idênticos a ECryptoServiceType em SmartCoreHub.Core.SDK.")]
public enum ECryptoServiceType
{
    Aes = (int)SchEnums.ECryptoServiceType.Aes,
    Rsa = (int)SchEnums.ECryptoServiceType.Rsa,
}
