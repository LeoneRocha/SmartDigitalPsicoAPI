using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportAdapter
    {
        byte[] Generate(ReportContentDto content);

        void Generate(ReportContentDto content, string filePath);
    }
}
