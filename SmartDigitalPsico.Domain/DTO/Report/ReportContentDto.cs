namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportContentDto
    {
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } =  string.Empty;
        public string FolderOutput { get; set; } = string.Empty;
        public List<ReportPageDataDto> Pages { get; set; } = new List<ReportPageDataDto>();
    }
}