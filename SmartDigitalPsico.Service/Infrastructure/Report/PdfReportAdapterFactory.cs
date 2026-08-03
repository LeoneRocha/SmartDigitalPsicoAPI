using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    /// <summary>
    /// Classe responsável por PdfReportAdapterFactory.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PdfReportAdapterFactory : IPdfReportAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
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
