using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    public class GetEmailTemplateDto : EmailTemplateBaseDto, ISupportsHyperMedia, IEntityDto
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        public long Id { get; set; }
    }
}