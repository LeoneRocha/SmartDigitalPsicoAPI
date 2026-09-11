using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO;

/// <summary>
/// Casca RepositoryInfo — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.RepositoryInfo",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando RepositoryInfo do SCH.")]
public class RepositoryInfo : Sch.RepositoryInfo
{
}
