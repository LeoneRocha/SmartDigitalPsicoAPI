using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IApplicationConfigSettingService : IEntityBaseService<ApplicationConfigSetting, AddApplicationConfigSettingDto, UpdateApplicationConfigSettingDto, GetApplicationConfigSettingDto>
    {

    }
}
