namespace SmartDigitalPsico.Domain.DTO.Report.Contracts
{
    public abstract class ReportDataBaseDto
    {
        public int Order { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> PropertiesToIgnore { get; set; } = new List<string>();
        public List<object> Rows { get; set; } = new List<object>();
    }
}
