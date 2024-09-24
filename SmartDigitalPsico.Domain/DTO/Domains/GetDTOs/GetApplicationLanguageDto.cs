using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    public class GetApplicationLanguageDto : EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        public string LanguageKey { get; set; } = string.Empty;
        public string LanguageValue { get; set; } = string.Empty;
        public string ResourceKey { get; set; } = string.Empty;
    }
}