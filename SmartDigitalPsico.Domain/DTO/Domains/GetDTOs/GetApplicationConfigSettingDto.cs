using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetApplicationConfigSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetApplicationConfigSettingDto: SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain, ISupportsHyperMedia
    { 
        public List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink>();         
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}
