using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    public class UpdateRoleGroupDto : EntityDtoBaseDomain
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}