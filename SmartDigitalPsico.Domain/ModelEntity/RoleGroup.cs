using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por RoleGroup.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class RoleGroup : EntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
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
