using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportPageDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ReportPageDataDto : ReportDataBaseDto
    {
        public EReportPageType PageType { get; set; }
        public string FooterTitle { get; set; } = "Page ";
        public float FontSizeDefaultTextStyle { get; set; } = 12;
        public float FontSizeHeader { get; set; } = 36;
    }
}
