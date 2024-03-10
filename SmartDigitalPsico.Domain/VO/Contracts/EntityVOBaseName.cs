using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Contracts
{
    public abstract class EntityVOBaseName : EntityVOBase
    {
        [MaxLength(255)]
        [Required]
        public string Name { get; set; } = string.Empty;


        [MaxLength(200)]
        [Required]
        public string Email { get; set; } = string.Empty;

    }
}