using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IExcelGeneratorService
    {
        Task Generate(ReportWorkbookDataDto workbook);
    }
}
