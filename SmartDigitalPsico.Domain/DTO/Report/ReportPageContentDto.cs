using SmartDigitalPsico.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportPageContentDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ReportPageContentDto : ReportContentBaseDto
    {
        public List<ReportPageDataDto> Pages { get; set; } = new List<ReportPageDataDto>();
    }
}
