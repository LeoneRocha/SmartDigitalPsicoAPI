using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de estratégia de e-mail.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EEmailStrategyType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho com valores idênticos a EEmailStrategyType em SmartCoreHub.Core.SDK.")]
public enum EEmailStrategyType
{
    Smtp = (int)SchEnums.EEmailStrategyType.Smtp,
    ThirdParty = (int)SchEnums.EEmailStrategyType.ThirdParty,
}
