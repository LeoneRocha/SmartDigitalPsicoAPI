using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.GetVOs
{
    public class GetApplicationLanguageVO : EntityVOBaseDomain, ISupportsHyperMedia
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        public string LanguageKey { get; set; } = string.Empty;

        public string LanguageValue { get; set; } = string.Empty;

        public string ResourceKey { get; set; } = string.Empty;

    }
}