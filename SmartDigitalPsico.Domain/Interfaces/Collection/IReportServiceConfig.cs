using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    /// <summary>
    /// Interface (contrato) responsável por IReportServiceConfig.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IReportServiceConfig
    {
        SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService ExcelGeneratorService { get; }

        SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService PdfReportService { get; }
    }
}
