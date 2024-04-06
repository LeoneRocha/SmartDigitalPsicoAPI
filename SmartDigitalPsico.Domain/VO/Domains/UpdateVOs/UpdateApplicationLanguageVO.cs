using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Domains.UpdateVOs
{
    public class UpdateApplicationLanguageVO : EntityVOBaseDomain
    {

        [MaxLength(255)]
        public string LanguageKey { get; set; } = string.Empty;

        [MaxLength(255)]
        public string LanguageValue { get; set; } = string.Empty;

        [MaxLength(255)]
        public string ResourceKey { get; set; } = string.Empty;
    }
}