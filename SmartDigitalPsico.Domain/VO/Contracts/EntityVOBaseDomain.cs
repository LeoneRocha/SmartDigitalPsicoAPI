using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Contracts
{
    public abstract class EntityVOBaseDomain : EntityVOBase
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(5)]
        public string Language { get; set; } = string.Empty;
    }
}