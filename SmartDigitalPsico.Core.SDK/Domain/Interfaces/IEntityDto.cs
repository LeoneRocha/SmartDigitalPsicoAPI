using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca IEntityDto — herda SCH Abstractions.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IEntityDto do SCH.")]
public interface IEntityDto : SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityDto
{
}
