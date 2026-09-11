using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO;

/// <summary>
/// Casca TimeZoneDisplayDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.TimeZoneDisplayDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando TimeZoneDisplayDto do SCH.")]
public class TimeZoneDisplayDto : Sch.TimeZoneDisplayDto
{
}
