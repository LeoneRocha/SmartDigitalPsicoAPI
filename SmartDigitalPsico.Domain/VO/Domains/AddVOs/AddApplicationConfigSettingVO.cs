using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Domains.AddVOs
{
    public class AddApplicationConfigSettingVO : EntityVOBaseDomainAdd
    {

        [MaxLength(255)]
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;

        [MaxLength(255)]
        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}