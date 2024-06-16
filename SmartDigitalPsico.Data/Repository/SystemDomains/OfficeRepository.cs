using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class OfficeRepository : GenericRepositoryEntityBase<Office>, IOfficeRepository
    {
        public OfficeRepository(SmartDigitalPsicoDataContext context,IPolicyConfig policyConfig) : base(context, policyConfig) { }

    }
}
