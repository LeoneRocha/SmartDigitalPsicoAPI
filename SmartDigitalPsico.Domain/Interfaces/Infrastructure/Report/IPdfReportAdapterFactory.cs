using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IPdfReportAdapterFactory.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IPdfReportAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        IPdfReportAdapter Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EPdfReportComponentType ePdfReportComponentType);
    }
}
