using SmartDigitalPsico.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    /// <summary>
    /// Classe responsável por ReportSheetDataDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ReportSheetDataDto : ReportDataBaseDto
    { 
        public List<string> MergeCellReferences { get; set; } = new List<string>(); 
    } 
}
