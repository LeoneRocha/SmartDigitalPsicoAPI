using SmartDigitalPsico.Core.SDK.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportWorkbookDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ReportWorkbookDataDto : ReportContentBaseDto
    {
        public List<ReportSheetDataDto> Sheets { get; set; } = new List<ReportSheetDataDto>();
    }
}
