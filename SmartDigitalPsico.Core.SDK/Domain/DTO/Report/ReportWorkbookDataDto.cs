using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

/// <summary>
/// Casca ReportWorkbookDataDto — herda SCH; <see cref="Sheets"/> tipado SDP (List invariante).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportWorkbookDataDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca ReportWorkbookDataDto; Sheets List&lt;ReportSheetDataDto&gt; SDP sincroniza base SCH.")]
public class ReportWorkbookDataDto : SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportWorkbookDataDto
{
    /// <summary>
    /// Surface SDP; sincroniza <c>base.Sheets</c> (List invariante).
    /// </summary>
    public new List<ReportSheetDataDto> Sheets
    {
        get => base.Sheets.ConvertAll(static p => (ReportSheetDataDto)p);
        set => base.Sheets = (value ?? new List<ReportSheetDataDto>())
            .ConvertAll(static p => (SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportSheetDataDto)p);
    }
}
