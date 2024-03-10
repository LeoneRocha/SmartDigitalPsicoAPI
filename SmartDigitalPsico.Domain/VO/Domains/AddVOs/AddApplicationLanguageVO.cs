using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Domains.AddVOs
{
    public class AddApplicationLanguageVO : EntityVOBaseDomainAdd
    {

        [MaxLength(255)]
        public string LanguageKey { get; set; } = string.Empty;

        [MaxLength(255)]
        public string LanguageValue { get; set; } = string.Empty;

        [MaxLength(255)]
        public string ResourceKey { get; set; } = string.Empty;

    }
}