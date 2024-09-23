namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportWorkbookDataVO : ReportContent
    {
        /// <summary>
        /// FileName
        /// </summary>
         
        public List<ReportSheetDataVO> Sheets { get; set; } = new List<ReportSheetDataVO>();
    } 
}
