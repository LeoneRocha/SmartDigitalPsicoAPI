using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.GetVOs
{
    public class GetApplicationConfigSettingVO : EntityVOBaseDomain, ISupportsHyperMedia
    { 
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
         
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;

        public string EndPointUrl_Cache { get; set; } = string.Empty;

    }
}