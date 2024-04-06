using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.GetVOs
{
    public class GetRoleGroupVO : EntityVOBaseDomain, ISupportsHyperMedia
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}