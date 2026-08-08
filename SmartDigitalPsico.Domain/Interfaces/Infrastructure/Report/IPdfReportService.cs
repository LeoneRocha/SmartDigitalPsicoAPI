using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IPdfReportService.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IPdfReportService
    {
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        Task<string> Generate(ReportPageContentDto content);
    }
}
