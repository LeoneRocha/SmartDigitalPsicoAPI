using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts;

/// <summary>
/// Casca EntityDtoBaseAdd — herda SCH e implementa IEntityDtoAdd SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseAdd",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EntityDtoBaseAdd do SCH.")]
public abstract class EntityDtoBaseAdd : SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseAdd, IEntityDtoAdd
{
}
