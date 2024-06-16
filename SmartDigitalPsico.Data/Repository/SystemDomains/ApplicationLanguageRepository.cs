
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationLanguageRepository : GenericRepositoryEntityBase<ApplicationLanguage>, IApplicationLanguageRepository
    {
        public ApplicationLanguageRepository(SmartDigitalPsicoDataContext context, IPolicyConfig policyConfig) : base(context, policyConfig) 
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
    }
}
