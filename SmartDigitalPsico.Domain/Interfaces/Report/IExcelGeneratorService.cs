using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Report
{
    public interface IExcelGeneratorService
    {
        Task Generate(ReportWorkbookDataVO workbook);
    }
}
