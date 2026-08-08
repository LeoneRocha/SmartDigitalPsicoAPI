using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.ModelEntity;

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
