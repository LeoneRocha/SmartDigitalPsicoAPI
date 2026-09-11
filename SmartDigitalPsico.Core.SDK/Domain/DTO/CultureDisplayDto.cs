using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.DTOs.Entities;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO;

/// <summary>
/// Casca CultureDisplayDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Entities.CultureDisplayDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando CultureDisplayDto do SCH.")]
public class CultureDisplayDto : Sch.CultureDisplayDto
{
}
