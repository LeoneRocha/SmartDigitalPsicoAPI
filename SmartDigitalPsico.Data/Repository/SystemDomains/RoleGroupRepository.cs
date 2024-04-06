using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class RoleGroupRepository : GenericRepositoryEntityBase<RoleGroup>, IRoleGroupRepository
    {
        public RoleGroupRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds)
        {
            if (roleGroupsIds == null) { return new List<RoleGroup>(); }

            return await dataset.Where(p => roleGroupsIds.Contains(p.Id)).ToListAsync();
        }
    }
}
