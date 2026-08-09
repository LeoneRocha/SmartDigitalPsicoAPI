using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Application.GET
{
    /// <summary>
    /// Classe responsável por GetApplicationConfigSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetApplicationConfigSettingDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}
