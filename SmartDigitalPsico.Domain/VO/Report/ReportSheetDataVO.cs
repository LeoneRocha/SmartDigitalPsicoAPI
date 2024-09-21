namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportWorkbookDataVO
    {
        /// <summary>
        /// FileName
        /// </summary>
        public string WorkbookName { get; set; } = string.Empty;

        public List<ReportSheetDataBaseVO> Sheets { get; set; } = new List<ReportSheetDataBaseVO>();
    }

    public class ReportSheetDataBaseVO
    {
        public int Order { get; set; }
        public string SheetName { get; set; } = string.Empty;
        public List<string> MergeCellReferences { get; set; } = new List<string>();
        public List<string> PropertiesToIgnore { get; set; } = new List<string>();
        public List<object> Rows { get; set; } = new List<object>();
    }

    //public class ReportSheetDataVO<T> : ReportSheetDataBaseVO where T : class, new()
    //{
    //    public List<T> Rows { get; set; } = new List<T>();
    //}

    //public interface IReportSheetData<T> where T : class, new()
    //{
    //    int Id { get; set; }
    //    string SheetName { get; set; }
    //    List<string> MergeCellReferences { get; set; }
    //    List<string> PropertiesToIgnore { get; set; }
    //    List<T> Rows { get; set; }
    //}
}
