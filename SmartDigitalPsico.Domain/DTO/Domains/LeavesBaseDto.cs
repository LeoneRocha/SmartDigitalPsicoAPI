using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public abstract class LeavesBaseDto : EntityDtoBaseDomain
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public bool IsRecurring { get; set; }
    }
}
