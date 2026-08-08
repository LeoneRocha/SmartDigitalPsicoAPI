using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    /// <summary>
    /// Classe responsável por UpdateApplicationLanguageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateApplicationLanguageDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    { 
        public string LanguageKey { get; set; } = string.Empty;         
        public string LanguageValue { get; set; } = string.Empty;         
        public string ResourceKey { get; set; } = string.Empty;
    }
}
