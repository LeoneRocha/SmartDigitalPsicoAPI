using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report
{
    /// <summary>
    /// Classe responsável por PdfReportAdapterFactory.
    /// </summary>
    public class PdfReportAdapterFactory : IPdfReportAdapterFactory
    {
        public IPdfReportAdapter Create(EPdfReportComponentType ePdfReportComponentType)
        {
            switch (ePdfReportComponentType)
            {
                case EPdfReportComponentType.QuestPDF:
                    return new QuestPdfReportAdapter();
                case EPdfReportComponentType.PDFsharp:
                    return new PDFsharpMigraDocReportAdapter();
                default:
                    throw new ArgumentException("Invalid Pdf Component Type");
            }
        }
    }
}
