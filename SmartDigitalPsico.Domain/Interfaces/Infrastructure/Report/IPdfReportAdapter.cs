using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportAdapter
    {
        byte[] Generate(ReportContent content);

        void Generate(ReportContent content, string filePath);
    }
}
