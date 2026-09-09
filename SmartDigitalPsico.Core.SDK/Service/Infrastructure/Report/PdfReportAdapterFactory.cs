using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report;

/// <summary>
/// Casca fábrica PDF — surface enum <c>Enuns</c>; instancia adapters SDP (herdam SCH).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Reports.PdfReportAdapterFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca PdfReportAdapterFactory; Create usa EPdfReportComponentType Enuns.")]
public class PdfReportAdapterFactory : IPdfReportAdapterFactory
{
    public IPdfReportAdapter Create(EPdfReportComponentType ePdfReportComponentType)
    {
        return ePdfReportComponentType switch
        {
            EPdfReportComponentType.QuestPDF => new QuestPdfReportAdapter(),
            EPdfReportComponentType.PDFsharp => new PDFsharpMigraDocReportAdapter(),
            _ => throw new ArgumentException("Invalid Pdf Component Type"),
        };
    }
}
