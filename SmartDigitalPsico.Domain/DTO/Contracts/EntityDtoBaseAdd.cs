using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseAdd : IEntityDtoAdd
    { 
        public bool Enable { get; set; }
    }
}