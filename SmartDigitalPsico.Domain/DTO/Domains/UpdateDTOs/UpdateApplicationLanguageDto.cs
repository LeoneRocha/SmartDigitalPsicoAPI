using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    public class UpdateApplicationLanguageDto : EntityDtoBaseDomain
    {

        [MaxLength(255)]
        public string LanguageKey { get; set; } = string.Empty;

        [MaxLength(255)]
        public string LanguageValue { get; set; } = string.Empty;

        [MaxLength(255)]
        public string ResourceKey { get; set; } = string.Empty;
    }
}