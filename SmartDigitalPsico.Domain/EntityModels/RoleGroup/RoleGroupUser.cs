namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por RoleGroupUser.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class RoleGroupUser
    {
        public User? User { get; set; }
        public long UserId { get; set; }

        public RoleGroup? RoleGroup { get; set; }
        public long RoleGroupId { get; set; }
    }
}
