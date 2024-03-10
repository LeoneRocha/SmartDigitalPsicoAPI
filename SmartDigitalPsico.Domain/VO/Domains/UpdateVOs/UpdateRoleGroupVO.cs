using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Domains.UpdateVOs
{
    public class UpdateRoleGroupVO : EntityVOBaseDomain
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}