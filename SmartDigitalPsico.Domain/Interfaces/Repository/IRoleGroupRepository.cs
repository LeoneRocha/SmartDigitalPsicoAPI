using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IRoleGroupRepository : IEntityBaseRepository<RoleGroup>
    {
        Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds);
    }
}
