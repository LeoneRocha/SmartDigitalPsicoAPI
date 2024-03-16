
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationLanguageRepository : GenericRepositoryEntityBaseSimple<ApplicationLanguage>, IApplicationLanguageRepository 
    { 
        public ApplicationLanguageRepository(SmartDigitalPsicoDataContext context            
            )
            : base(context)
        {
            
        }
        public override async Task<ApplicationLanguage> Create(ApplicationLanguage item)
        {  
            return await base.Create(item);
        }
         

        public override async Task<ApplicationLanguage> Update(ApplicationLanguage item)
        { 
            return await base.Update(item);
        }

        public async Task<ApplicationLanguage> Find(string language, string languageKey, string resourceKey = "SharedResource")
        {
            return await dataset.SingleAsync(p =>
            p.ResourceKey.ToUpper().Trim().Equals(resourceKey.ToUpper().Trim())
            && p.LanguageKey.ToUpper().Trim().Equals(languageKey.ToUpper().Trim())
            && p.Language.ToUpper().Trim().Equals(language.ToUpper().Trim())
            );
        } 

        public override async Task<bool> Delete(long id)
        { 
            return await base.Delete(id);
        } 
    }
}
