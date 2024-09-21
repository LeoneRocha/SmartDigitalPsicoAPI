namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportWorkbookDataVO
    {
        /// <summary>
        /// FileName
        /// </summary>
        public string WorkbookName { get; set; } = string.Empty;

        public List<ReportSheetDataVO> Sheets { get; set; } = new List<ReportSheetDataVO>();
    } 
}
