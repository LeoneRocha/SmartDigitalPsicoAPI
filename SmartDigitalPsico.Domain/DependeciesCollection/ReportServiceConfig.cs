using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por ReportServiceConfig.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ReportServiceConfig : IReportServiceConfig
    { 
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService ExcelGeneratorService { get; }
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService PdfReportService { get; } 

        /// <summary>
        /// Método ReportServiceConfig: executa a operação ReportServiceConfig.
        /// </summary>
        public ReportServiceConfig(
            SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService excelGeneratorService,
            SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService pdfReportService
            )
        {
            ExcelGeneratorService = excelGeneratorService;
            PdfReportService = pdfReportService; 
        }
    }
}
