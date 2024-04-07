using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class RoleGroup : EntityBase, IEntityBaseDomains
    {
        public RoleGroup()
        {
            Users = new List<User>();
        }
        public ICollection<User> Users { get; set; }
        public string Description { get; set; } = string.Empty;         
        public string Language { get; set; } = string.Empty;
        public string RolePolicyClaimCode { get; set; } = string.Empty;
    }
}