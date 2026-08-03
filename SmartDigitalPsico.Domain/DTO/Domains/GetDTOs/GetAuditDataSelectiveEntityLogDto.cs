using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetAuditDataSelectiveEntityLogDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto, ISupportsHyperMedia
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>(); 
    }
}
