using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseName : EntityDtoBase
    {
        [MaxLength(255)]
        [Required]
        public string Name { get; set; } = string.Empty;


        [MaxLength(200)]
        [Required]
        public string Email { get; set; } = string.Empty;

    }
}