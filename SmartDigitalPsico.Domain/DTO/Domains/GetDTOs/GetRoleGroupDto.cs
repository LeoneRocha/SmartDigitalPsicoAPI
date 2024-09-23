using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    public class GetRoleGroupDto : EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}