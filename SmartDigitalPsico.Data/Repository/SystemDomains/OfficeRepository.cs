using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class OfficeRepository : GenericRepositoryEntityBase<Office>, IOfficeRepository
    {
        public OfficeRepository(IEntityDataContext context) : base(context) { } 
    }
}
