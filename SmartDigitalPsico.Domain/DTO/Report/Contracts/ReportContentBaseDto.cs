namespace SmartDigitalPsico.Domain.DTO.Report.Contracts
{
    public abstract class ReportContentBaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string FolderOutput { get; set; } = string.Empty;
    }
}