using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.VO.Contracts
{
    public abstract class EntityVOBase : IEntityVO
    {
        public long Id { get; set; }

        public bool Enable { get; set; }

    }
}