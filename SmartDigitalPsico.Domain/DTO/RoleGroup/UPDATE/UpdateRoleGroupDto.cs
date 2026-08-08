namespace SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdateRoleGroupDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateRoleGroupDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}
