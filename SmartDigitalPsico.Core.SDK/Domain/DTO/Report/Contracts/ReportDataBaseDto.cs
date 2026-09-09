using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report.Contracts;

/// <summary>
/// Casca ReportDataBaseDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Report.Contracts.ReportDataBaseDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ReportDataBaseDto em SmartCoreHub.Core.SDK.")]
public abstract class ReportDataBaseDto : SmartCoreHub.Core.SDK.Domain.DTOs.Report.Contracts.ReportDataBaseDto
{
}
