using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.Contracts;

/// <summary>
/// Casca EntityBase long+Enable — herda SCH Domain.Contracts.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Contracts.EntityBase",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EntityBase (long) de SmartCoreHub.Core.SDK.")]
public abstract class EntityBase
    : SmartCoreHub.Core.SDK.Domain.Contracts.EntityBase,
      IEntityBase,
      IEntityBaseLog
{
}
