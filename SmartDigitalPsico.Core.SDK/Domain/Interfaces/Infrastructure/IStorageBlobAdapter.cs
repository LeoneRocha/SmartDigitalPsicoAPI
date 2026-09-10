using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

/// <summary>
/// Casca IStorageBlobAdapter — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IStorageBlobAdapter do SCH.")]
public interface IStorageBlobAdapter : SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter
{
}
