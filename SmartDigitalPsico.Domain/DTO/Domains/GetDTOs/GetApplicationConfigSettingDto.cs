using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    public class GetApplicationConfigSettingDto: EntityDtoBaseDomain, ISupportsHyperMedia
    { 
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();         
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}