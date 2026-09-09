using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report.Contracts;

/// <summary>
/// Casca ReportContentBaseDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Report.Contracts.ReportContentBaseDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ReportContentBaseDto em SmartCoreHub.Core.SDK.")]
public abstract class ReportContentBaseDto : SmartCoreHub.Core.SDK.Domain.DTOs.Report.Contracts.ReportContentBaseDto
{
}
