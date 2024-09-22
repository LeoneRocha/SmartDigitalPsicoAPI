namespace SmartDigitalPsico.Domain.VO.Report
{
    public class ReportDataVO
    {
        public int Order { get; set; }
        public string Name { get; set; } = string.Empty; 
        public List<string> PropertiesToIgnore { get; set; } = new List<string>();
        public List<object> Rows { get; set; } = new List<object>();
    } 
}
