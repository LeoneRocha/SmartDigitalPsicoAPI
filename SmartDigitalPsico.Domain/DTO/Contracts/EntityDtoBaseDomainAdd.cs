using System.ComponentModel.DataAnnotations;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseDomainAdd : IEntityDtoAdd
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(5)]
        public string Language { get; set; } = "en";
    }
}