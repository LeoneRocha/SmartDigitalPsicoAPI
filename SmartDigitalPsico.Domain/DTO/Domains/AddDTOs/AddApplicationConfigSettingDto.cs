using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    public class AddApplicationConfigSettingDto: EntityDtoBaseDomainAdd
    {

        [MaxLength(255)]
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;

        [MaxLength(255)]
        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}