using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    /// <summary>
    /// Classe responsável por AddApplicationLanguageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddApplicationLanguageDto: SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomainAdd
    {
        public string LanguageKey { get; set; } = string.Empty;
        public string LanguageValue { get; set; } = string.Empty;
        public string ResourceKey { get; set; } = string.Empty;

    }
}
