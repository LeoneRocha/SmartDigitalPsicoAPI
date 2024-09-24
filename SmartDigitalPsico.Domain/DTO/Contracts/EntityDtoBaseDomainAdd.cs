using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseDomainAdd : IEntityDtoAdd
    { 
        public string Description { get; set; } = string.Empty;  
        public string Language { get; set; } = "en";
    }
}