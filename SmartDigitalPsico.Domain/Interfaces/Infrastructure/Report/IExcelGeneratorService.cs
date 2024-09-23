using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IExcelGeneratorService
    {
        Task Generate(ReportWorkbookDataVO workbook);
    }
}
