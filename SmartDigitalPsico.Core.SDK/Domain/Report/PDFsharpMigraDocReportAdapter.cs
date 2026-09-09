using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Report;

/// <summary>
/// Casca PDFsharp/MigraDoc — herda SCH; bridge <see cref="IPdfReportAdapter"/> SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Reports.PDFsharpMigraDocReportAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando PDFsharpMigraDocReportAdapter; bridge IPdfReportAdapter SDP.")]
public class PDFsharpMigraDocReportAdapter
    : SmartCoreHub.Core.SDK.Infrastructure.Reports.PDFsharpMigraDocReportAdapter,
      IPdfReportAdapter
{
    byte[] IPdfReportAdapter.Generate(ReportPageContentDto content)
        => base.Generate(content);

    Task IPdfReportAdapter.Generate(ReportPageContentDto content, string filePath)
        => base.Generate(content, filePath);
}
