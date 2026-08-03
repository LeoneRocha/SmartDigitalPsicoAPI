using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetSpecialtyDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetSpecialtyDto : EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
