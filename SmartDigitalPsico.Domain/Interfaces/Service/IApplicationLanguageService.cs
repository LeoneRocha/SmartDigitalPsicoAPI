using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IApplicationLanguageService
        : IEntityBaseService<ApplicationLanguage, AddApplicationLanguageDto, UpdateApplicationLanguageDto, GetApplicationLanguageDto>
    { 
        Task<string> GetLocalization<T>(string key, string defaultMenssage, ICacheService cacheService);
    }
}