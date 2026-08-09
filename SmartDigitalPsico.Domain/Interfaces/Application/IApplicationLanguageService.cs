using SmartDigitalPsico.Domain.DTO.Application.GET;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Application
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationLanguageService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IApplicationLanguageService
        : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<ApplicationLanguage, GetApplicationLanguageDto>
    {
        Task<string> GetLocalization<T>(string key, string defaultMenssage, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService);
    }
}
