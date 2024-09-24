using SmartDigitalPsico.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportSheetDataDto : ReportDataBaseDto
    { 
        public List<string> MergeCellReferences { get; set; } = new List<string>(); 
    } 
}
