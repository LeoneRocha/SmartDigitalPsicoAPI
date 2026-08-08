using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Application
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationConfigSettingRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IApplicationConfigSettingRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<ApplicationConfigSetting>
    {

    }
}
