using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts;

/// <summary>
/// Casca EntityDtoBase — herda SCH Common.EntityDtoBase.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.EntityDtoBase",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EntityDtoBase do SCH.")]
public abstract class EntityDtoBase : SmartCoreHub.Core.SDK.Common.EntityDtoBase, IEntityDto
{
}
