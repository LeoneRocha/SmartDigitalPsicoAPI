namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportWorkbookDataDto : ReportContentDto
    {
        /// <summary>
        /// FileName
        /// </summary>
         
        public List<ReportSheetDataDto> Sheets { get; set; } = new List<ReportSheetDataDto>();
    } 
}
