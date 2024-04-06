using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.AddVOs
{
    public class AddRoleGroupVO : EntityVOBaseDomainAdd
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}