
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Application;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por ApplicationLanguageRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class ApplicationLanguageRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ApplicationLanguage>, IApplicationLanguageRepository
    {
        /// <summary>
        /// Método ApplicationLanguageRepository: executa a operação ApplicationLanguageRepository.
        /// </summary>
        public ApplicationLanguageRepository(IEntityDataContext context) : base(context)
        {

        }
        /// <summary>
        /// Método Find: consulta e retorna dados.
        /// </summary>
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

        /// <summary>
        /// Método ExistLanguage: executa a operação ExistLanguage.
        /// </summary>
        public async Task<bool> ExistLanguage(string language, string languageKey, string resourceKey = "SharedResource")
        {
            return await _dataset.AsNoTracking().AnyAsync(p => p.ResourceKey.ToUpper().Trim().Equals(resourceKey.ToUpper().Trim())
            && p.LanguageKey.ToUpper().Trim().Equals(languageKey.ToUpper().Trim())
            && p.Language.ToUpper().Trim().Equals(language.ToUpper().Trim())
            );
        }
    }
}
