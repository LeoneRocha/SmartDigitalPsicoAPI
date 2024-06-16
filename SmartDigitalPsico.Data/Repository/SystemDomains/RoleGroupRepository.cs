using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class RoleGroupRepository : GenericRepositoryEntityBase<RoleGroup>, IRoleGroupRepository
    {
        public RoleGroupRepository(SmartDigitalPsicoDataContext context,IPolicyConfig policyConfig) : base(context, policyConfig) { }

        public async Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds)
        {
            if (roleGroupsIds == null) { return new List<RoleGroup>(); }

            return await _dataset
                .AsNoTracking()
                .Where(p => roleGroupsIds.Contains(p.Id)).ToListAsync();
        }
    }
}
