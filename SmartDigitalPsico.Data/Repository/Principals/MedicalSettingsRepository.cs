using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalSettingsRepository : GenericRepositoryEntityBase<MedicalSettings>, IMedicalSettingsRepository
    {
        public MedicalSettingsRepository(IEntityDataContext context) : base(context) { }
    }
}
