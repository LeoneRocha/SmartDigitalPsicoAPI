using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class LeavesRepository : GenericRepositoryEntityBase<Leaves>, ILeavesRepository
    {
        public LeavesRepository(IEntityDataContext context) : base(context) { }

       
    }
}