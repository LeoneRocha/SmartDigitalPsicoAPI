using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

/// <summary>
/// Casca ReportPageDataDto — herda SCH; <see cref="PageType"/> permanece na surface <c>Domain.Enuns</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportPageDataDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca ReportPageDataDto; PageType espelha Enuns↔Enums via cast (int).")]
public class ReportPageDataDto : SmartCoreHub.Core.SDK.Domain.DTOs.Report.ReportPageDataDto
{
    /// <summary>
    /// Surface SDP (<c>Domain.Enuns</c>); sincroniza com a propriedade base SCH (<c>Domain.Enums</c>).
    /// </summary>
    public new EReportPageType PageType
    {
        get => (EReportPageType)(int)base.PageType;
        set => base.PageType = (SchEnums.EReportPageType)(int)value;
    }
}
