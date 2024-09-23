namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportSheetDataDto : ReportDataVO
    { 
        public List<string> MergeCellReferences { get; set; } = new List<string>(); 
    } 
}
