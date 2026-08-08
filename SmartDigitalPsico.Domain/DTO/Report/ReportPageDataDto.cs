using SmartDigitalPsico.Domain.DTO.Report.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;


namespace SmartDigitalPsico.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportPageDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ReportPageDataDto : ReportDataBaseDto
    {
        public SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType PageType { get; set; }
        public string FooterTitle { get; set; } = "Page ";
        public float FontSizeDefaultTextStyle { get; set; } = 12;
        public float FontSizeHeader { get; set; } = 36;
    }
}
