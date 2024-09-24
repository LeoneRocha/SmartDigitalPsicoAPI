using SmartDigitalPsico.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportWorkbookDataDto : ReportContentBaseDto
    {
        public List<ReportSheetDataDto> Sheets { get; set; } = new List<ReportSheetDataDto>();
    }
}
