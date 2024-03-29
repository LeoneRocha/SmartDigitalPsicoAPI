using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IApplicationLanguageRepository : IEntityBaseRepository<ApplicationLanguage>
    {
        Task<ApplicationLanguage> Find(string language, string languageKey, string resourceKey = "SharedResource");

    }
}
