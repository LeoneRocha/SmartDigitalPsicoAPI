using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportPageContentDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ReportPageContentDto : ReportContentBaseDto
    {
        public List<ReportPageDataDto> Pages { get; set; } = new List<ReportPageDataDto>();
    }
}
