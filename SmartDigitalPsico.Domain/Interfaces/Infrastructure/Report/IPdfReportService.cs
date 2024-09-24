using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPdfReportService
    {
        Task<string> Generate(ReportPageContentDto content);
    }
}
