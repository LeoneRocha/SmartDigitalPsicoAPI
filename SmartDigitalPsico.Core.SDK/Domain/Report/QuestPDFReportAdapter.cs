using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Report;

/// <summary>
/// Casca QuestPDF — herda SCH; bridge <see cref="IPdfReportAdapter"/> SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Reports.QuestPdfReportAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando QuestPdfReportAdapter; bridge IPdfReportAdapter SDP.")]
public class QuestPdfReportAdapter
    : SmartCoreHub.Core.SDK.Infrastructure.Reports.QuestPdfReportAdapter,
      IPdfReportAdapter
{
    byte[] IPdfReportAdapter.Generate(ReportPageContentDto content)
        => base.Generate(content);

    Task IPdfReportAdapter.Generate(ReportPageContentDto content, string filePath)
        => base.Generate(content, filePath);
}
