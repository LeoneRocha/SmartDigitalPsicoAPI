using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IExcelGenerator
    {
        Task Generate(ReportWorkbookDataDto workbookDataInput, string filePath);
    }
}
