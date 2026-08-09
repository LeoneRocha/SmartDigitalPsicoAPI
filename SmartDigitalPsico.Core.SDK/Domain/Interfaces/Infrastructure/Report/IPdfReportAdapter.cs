using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IPdfReportAdapter.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPdfReportAdapter
    {
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        byte[] Generate(ReportPageContentDto content);

        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        Task Generate(ReportPageContentDto content, string filePath);
    }
}
