using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca IEntityBase — herda SCH Abstractions.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityBase",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IEntityBase do SCH.")]
public interface IEntityBase : SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityBase
{
}
