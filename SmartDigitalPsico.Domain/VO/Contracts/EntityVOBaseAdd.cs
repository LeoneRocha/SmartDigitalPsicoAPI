using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.VO.Contracts
{
    public abstract class EntityVOBaseAdd : IEntityVOAdd
    { 
        public bool Enable { get; set; }
    }
}