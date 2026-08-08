using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    /// <summary>
    /// Classe responsável por UpdateRoleGroupDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateRoleGroupDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}
