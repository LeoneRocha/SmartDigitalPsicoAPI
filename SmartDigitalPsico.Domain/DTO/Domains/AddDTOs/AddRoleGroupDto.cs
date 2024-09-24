using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    public class AddRoleGroupDto: EntityDtoBaseDomainAdd
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}