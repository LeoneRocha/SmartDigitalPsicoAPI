using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Casca SecurityDto — herda SCH (Id com set público no base).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.SecurityDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando SecurityDto do SCH.")]
public class SecurityDto : Sch.SecurityDto
{
}
