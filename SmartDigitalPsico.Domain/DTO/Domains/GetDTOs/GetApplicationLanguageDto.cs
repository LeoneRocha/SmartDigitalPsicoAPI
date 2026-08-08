using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetApplicationLanguageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetApplicationLanguageDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        public string LanguageKey { get; set; } = string.Empty;
        public string LanguageValue { get; set; } = string.Empty;
        public string ResourceKey { get; set; } = string.Empty;
    }
}
