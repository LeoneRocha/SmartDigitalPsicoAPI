using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportAdapter
    {
        byte[] Generate(ReportPageContentDto content);

        Task Generate(ReportPageContentDto content, string filePath);
    }
}
