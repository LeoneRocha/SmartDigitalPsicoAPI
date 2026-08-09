namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Report.Contracts
{
    /// <summary>
    /// Classe responsável por ReportDataBaseDto.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class ReportDataBaseDto
    {
        public int Order { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> PropertiesToIgnore { get; set; } = new List<string>();
        public List<object> Rows { get; set; } = new List<object>();
    }
}
