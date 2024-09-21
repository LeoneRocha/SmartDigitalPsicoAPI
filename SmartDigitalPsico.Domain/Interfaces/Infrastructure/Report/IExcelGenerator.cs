using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IExcelGenerator
    {
        Task Generate(ReportWorkbookDataVO workbookDataInput, string filePath);
    }
}
