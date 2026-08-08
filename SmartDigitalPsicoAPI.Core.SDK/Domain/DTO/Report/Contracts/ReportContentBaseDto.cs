namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.Contracts
{
    /// <summary>
    /// Classe responsável por ReportContentBaseDto.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class ReportContentBaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string FolderOutput { get; set; } = string.Empty;
    }
}
