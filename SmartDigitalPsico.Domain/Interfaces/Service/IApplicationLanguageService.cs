using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationLanguageService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IApplicationLanguageService
        : IEntityBaseService<ApplicationLanguage, GetApplicationLanguageDto>
    { 
        Task<string> GetLocalization<T>(string key, string defaultMenssage, ICacheService cacheService);
    }
}
