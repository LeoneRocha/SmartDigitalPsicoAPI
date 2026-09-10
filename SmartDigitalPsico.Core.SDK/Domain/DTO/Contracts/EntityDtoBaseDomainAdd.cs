using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts;

/// <summary>
/// Casca EntityDtoBaseDomainAdd — herda SCH e implementa IEntityDtoAdd SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseDomainAdd",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EntityDtoBaseDomainAdd do SCH.")]
public abstract class EntityDtoBaseDomainAdd : SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseDomainAdd, IEntityDtoAdd
{
}
