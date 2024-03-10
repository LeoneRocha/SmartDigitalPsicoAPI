using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.UpdateVOs
{
    public class UpdateApplicationConfigSettingVO : EntityVOBaseDomain
    {
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;

        public string EndPointUrl_Cache { get; set; } = string.Empty;
    }
}