using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class OfficeRepository : GenericRepositoryEntityBase<Office>, IOfficeRepository
    {
        public OfficeRepository(SmartDigitalPsicoDataContext context) : base(context) { } 
    }
}
