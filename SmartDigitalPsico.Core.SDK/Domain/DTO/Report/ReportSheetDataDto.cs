using SmartDigitalPsico.Core.SDK.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportSheetDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ReportSheetDataDto : ReportDataBaseDto
    {
        public List<string> MergeCellReferences { get; set; } = new List<string>();
    }
}
