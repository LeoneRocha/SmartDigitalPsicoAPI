using SmartDigitalPsico.Domain.DTO.Report.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;


namespace SmartDigitalPsico.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportPageDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ReportPageDataDto : ReportDataBaseDto
    {
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EReportPageType PageType { get; set; }
        public string FooterTitle { get; set; } = "Page ";
        public float FontSizeDefaultTextStyle { get; set; } = 12;
        public float FontSizeHeader { get; set; } = 36;
    }
}
