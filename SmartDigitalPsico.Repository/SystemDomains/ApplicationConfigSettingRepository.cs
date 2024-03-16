using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.SystemDomains
{
    public class ApplicationConfigSettingRepository : GenericRepositoryEntityBaseSimple<ApplicationConfigSetting>, IApplicationConfigSettingRepository
    {
        public ApplicationConfigSettingRepository(SmartDigitalPsicoDataContext context) : base(context) { }
         
    }
}
