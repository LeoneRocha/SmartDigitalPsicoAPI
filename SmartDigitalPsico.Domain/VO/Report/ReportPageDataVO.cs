using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportPageDataVO : ReportDataVO
    {
        public EReportPageType PageType { get; set; }
        public string FooterTitle { get; set; } = "Page ";
        public float FontSizeDefaultTextStyle { get; set; } = 12;
        public float FontSizeHeader { get; set; } = 36;
    }
}
