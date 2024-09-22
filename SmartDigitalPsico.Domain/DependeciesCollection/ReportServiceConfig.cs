using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class ReportServiceConfig : IReportServiceConfig
    { 
        public IExcelGeneratorService ExcelGeneratorService { get; }
        public IPdfReportService PdfReportService { get; } 

        public ReportServiceConfig(
            IExcelGeneratorService excelGeneratorService,
            IPdfReportService pdfReportService
            )
        {
            ExcelGeneratorService = excelGeneratorService;
            PdfReportService = pdfReportService; 
        }
    }
}