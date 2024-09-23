using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBase : IEntityDto
    {
        public long Id { get; set; }

        public bool Enable { get; set; }
    }
}