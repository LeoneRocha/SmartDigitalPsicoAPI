using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseDomainAdd.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBaseDomainAdd : IEntityDtoAdd
    { 
        public string Description { get; set; } = string.Empty;  
        public string Language { get; set; } = "en";
    }
}
