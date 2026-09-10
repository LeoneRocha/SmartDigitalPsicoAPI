using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Casca IEntityBaseDomains — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IEntityBaseDomains do SCH.")]
public interface IEntityBaseDomains : SmartCoreHub.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
{
}
