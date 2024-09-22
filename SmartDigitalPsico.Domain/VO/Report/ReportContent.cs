namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportContent
    {
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } =  string.Empty;

        public string FolderOutput { get; set; } = string.Empty;

        public List<ReportDataVO> Pages { get; set; } = new List<ReportDataVO>();
    }
}
