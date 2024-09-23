using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportService
    {
        void Generate(ReportContent content);
    }
}
