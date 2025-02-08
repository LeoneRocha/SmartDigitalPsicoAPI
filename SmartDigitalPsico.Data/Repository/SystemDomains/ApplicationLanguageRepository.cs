
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationLanguageRepository : GenericRepositoryEntityBase<ApplicationLanguage>, IApplicationLanguageRepository
    {
        public ApplicationLanguageRepository(IEntityDataContext context) : base(context)
        {

        }
        public async Task<ApplicationLanguage> Find(string language, string languageKey, string resourceKey = "SharedResource")
        {
            return await _dataset
                .AsNoTracking()
                .SingleAsync(p =>
            p.ResourceKey.ToUpper().Trim().Equals(resourceKey.ToUpper().Trim())
            && p.LanguageKey.ToUpper().Trim().Equals(languageKey.ToUpper().Trim())
            && p.Language.ToUpper().Trim().Equals(language.ToUpper().Trim())
            );
        }


        public async Task<bool> ExistLanguage(string language, string languageKey, string resourceKey = "SharedResource")
        {
            return await _dataset.AsNoTracking().AnyAsync(p => p.ResourceKey.ToUpper().Trim().Equals(resourceKey.ToUpper().Trim())
            && p.LanguageKey.ToUpper().Trim().Equals(languageKey.ToUpper().Trim())
            && p.Language.ToUpper().Trim().Equals(language.ToUpper().Trim())
            );
        }
    }
}
