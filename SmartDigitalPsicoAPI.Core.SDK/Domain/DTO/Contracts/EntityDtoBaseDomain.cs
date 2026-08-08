namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseDomain.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBaseDomain : EntityDtoBase
    {
        public string Description { get; set; } = string.Empty;     
        public string Language { get; set; } = "en";
    }
}
