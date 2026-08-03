using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    /// <summary>
    /// Classe responsável por AddRoleGroupDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddRoleGroupDto: EntityDtoBaseDomainAdd
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}
