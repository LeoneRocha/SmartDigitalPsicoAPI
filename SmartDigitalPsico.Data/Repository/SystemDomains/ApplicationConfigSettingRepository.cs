using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

using SmartDigitalPsico.Domain.Interfaces;
namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationConfigSettingRepository : GenericRepositoryEntityBase<ApplicationConfigSetting>, IApplicationConfigSettingRepository
    {
        public ApplicationConfigSettingRepository(SmartDigitalPsicoDataContextMysql context) : base(context) { }

    }
}
