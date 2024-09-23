namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportSheetDataVO : ReportDataVO
    { 
        public List<string> MergeCellReferences { get; set; } = new List<string>(); 
    } 
}
