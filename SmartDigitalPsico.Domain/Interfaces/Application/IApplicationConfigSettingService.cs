using SmartDigitalPsico.Domain.DTO.Application.GET;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Application
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationConfigSettingService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IApplicationConfigSettingService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<ApplicationConfigSetting, GetApplicationConfigSettingDto>
    {

    }
}
