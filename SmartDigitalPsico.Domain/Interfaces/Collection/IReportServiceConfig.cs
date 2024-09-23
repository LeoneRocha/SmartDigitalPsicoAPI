using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface IReportServiceConfig
    {
        IExcelGeneratorService ExcelGeneratorService { get; }

        IPdfReportService PdfReportService { get; }
    }
}