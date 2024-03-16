using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.SystemDomains
{
    public class OfficeRepository : GenericRepositoryEntityBaseSimple<Office>, IOfficeRepository
    {
        public OfficeRepository(SmartDigitalPsicoDataContext context) : base(context) { }

    }
}
