namespace SmartDigitalPsico.Domain.DTO.Report.Contracts
{
    /// <summary>
    /// Classe responsável por ReportContentBaseDto.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public abstract class ReportContentBaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string FolderOutput { get; set; } = string.Empty;
    }
}
