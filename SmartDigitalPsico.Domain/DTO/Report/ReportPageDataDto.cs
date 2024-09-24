using SmartDigitalPsico.Domain.DTO.Report.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Report
{
    public class ReportPageDataDto : ReportDataBaseDto
    {
        public EReportPageType PageType { get; set; }
        public string FooterTitle { get; set; } = "Page ";
        public float FontSizeDefaultTextStyle { get; set; } = 12;
        public float FontSizeHeader { get; set; } = 36;
    }
}
