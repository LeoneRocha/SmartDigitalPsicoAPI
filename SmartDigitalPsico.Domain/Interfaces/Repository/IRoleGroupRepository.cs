using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IRoleGroupRepository : IEntityBaseSimpleRepository<RoleGroup>
    {
        Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds);
    }
}
