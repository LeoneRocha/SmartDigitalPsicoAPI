using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca IEntityBaseLog — herda SCH Abstractions.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityBaseLog",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IEntityBaseLog do SCH.")]
public interface IEntityBaseLog : SmartCoreHub.Core.SDK.Domain.Abstractions.IEntityBaseLog
{
}
