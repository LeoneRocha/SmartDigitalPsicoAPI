using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportService
    {
        void Generate(ReportPageContentDto content);
    }
}
