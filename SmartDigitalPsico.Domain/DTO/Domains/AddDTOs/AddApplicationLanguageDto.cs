using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    public class AddApplicationLanguageDto: EntityDtoBaseDomainAdd
    {

        [MaxLength(255)]
        public string LanguageKey { get; set; } = string.Empty;

        [MaxLength(255)]
        public string LanguageValue { get; set; } = string.Empty;

        [MaxLength(255)]
        public string ResourceKey { get; set; } = string.Empty;

    }
}