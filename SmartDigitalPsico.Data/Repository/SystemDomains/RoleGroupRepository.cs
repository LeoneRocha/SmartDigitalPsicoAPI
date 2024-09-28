using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class RoleGroupRepository : GenericRepositoryEntityBase<RoleGroup>, IRoleGroupRepository
    {
        public RoleGroupRepository(IEntityDataContext context) : base(context) { }

        public async Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds)
        {
            if (roleGroupsIds == null) { return new List<RoleGroup>(); }

            return await _dataset
                .AsNoTracking()
                .Where(p => roleGroupsIds.Contains(p.Id)).ToListAsync();
        }
    }
}
