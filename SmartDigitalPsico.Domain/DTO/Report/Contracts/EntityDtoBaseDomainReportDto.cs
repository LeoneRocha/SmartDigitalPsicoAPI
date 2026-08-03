namespace SmartDigitalPsico.Domain.DTO.Report.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseDomainReportDto.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBaseDomainReportDto
    {
        public string Description { get; set; } = string.Empty;
    }
}
