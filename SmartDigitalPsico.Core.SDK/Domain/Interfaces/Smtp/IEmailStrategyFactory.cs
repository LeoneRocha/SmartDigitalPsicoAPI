using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

/// <summary>
/// Contrato fábrica email — surface SDP com enum <c>Enuns</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.IEmailStrategyFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; CreateStrategy usa EEmailStrategyType em Domain.Enuns.")]
public interface IEmailStrategyFactory
{
    IEmailStrategy CreateStrategy(EEmailStrategyType strategyType);
}
