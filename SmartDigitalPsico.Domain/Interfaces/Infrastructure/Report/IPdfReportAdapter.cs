using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportAdapter
    {
        byte[] Generate(ReportPageContentDto content);

        void Generate(ReportPageContentDto content, string filePath);
    }
}
