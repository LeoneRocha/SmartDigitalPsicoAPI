using SmartDigitalPsico.Domain.DTO.Report.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportPageContentDto : ReportContentBaseDto
    {
        public List<ReportPageDataDto> Pages { get; set; } = new List<ReportPageDataDto>();
    }
}