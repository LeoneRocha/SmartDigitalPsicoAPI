namespace SmartDigitalPsico.Domain.VO.Report
{ 
    public class ReportSheetDataVO
    {
        public int Order { get; set; }
        public string SheetName { get; set; } = string.Empty;
        public List<string> MergeCellReferences { get; set; } = new List<string>();
        public List<string> PropertiesToIgnore { get; set; } = new List<string>();
        public List<object> Rows { get; set; } = new List<object>();
    } 
}
