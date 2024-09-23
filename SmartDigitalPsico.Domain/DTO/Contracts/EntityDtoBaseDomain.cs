using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseDomain : EntityDtoBase
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(5)]
        public string Language { get; set; } = "en";
    }
}