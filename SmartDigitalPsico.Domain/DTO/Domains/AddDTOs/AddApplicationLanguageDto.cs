using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    public class AddApplicationLanguageDto: EntityDtoBaseDomainAdd
    {
        public string LanguageKey { get; set; } = string.Empty;
        public string LanguageValue { get; set; } = string.Empty;
        public string ResourceKey { get; set; } = string.Empty;

    }
}