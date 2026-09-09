using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

/// <summary>
/// Casca ReportPageContentDto — herda SCH; <see cref="Pages"/> tipado SDP (List invariante).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportPageContentDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca ReportPageContentDto; Pages List&lt;ReportPageDataDto&gt; SDP sincroniza base SCH.")]
public class ReportPageContentDto : SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportPageContentDto
{
    /// <summary>
    /// Surface SDP; sincroniza <c>base.Pages</c> (List invariante Enuns/DTO).
    /// </summary>
    public new List<ReportPageDataDto> Pages
    {
        get => base.Pages.ConvertAll(static p => (ReportPageDataDto)p);
        set => base.Pages = (value ?? new List<ReportPageDataDto>())
            .ConvertAll(static p => (SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportPageDataDto)p);
    }
}
