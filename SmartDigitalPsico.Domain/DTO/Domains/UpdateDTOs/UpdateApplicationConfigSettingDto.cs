using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    public class UpdateApplicationConfigSettingDto : EntityDtoBaseDomain
    {
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;

        public string UrlRootManager { get; set; } = string.Empty;
    }
}