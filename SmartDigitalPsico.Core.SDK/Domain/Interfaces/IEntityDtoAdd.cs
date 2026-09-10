using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca IEntityDtoAdd — herda SCH Abstractionsions.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityDtoAdd",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IEntityDtoAdd do SCH.")]
public interface IEntityDtoAdd : SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityDtoAdd
{
}
