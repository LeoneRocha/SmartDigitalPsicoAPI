using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por RoleGroup.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class RoleGroup : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        /// <summary>
        /// Método RoleGroup: executa a operação RoleGroup.
        /// </summary>
        public RoleGroup()
        {
            UserRoleGroups = new List<RoleGroupUser>();
        }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string RolePolicyClaimCode { get; set; } = string.Empty;
        public ICollection<RoleGroupUser> UserRoleGroups { get; set; }
    }
}
