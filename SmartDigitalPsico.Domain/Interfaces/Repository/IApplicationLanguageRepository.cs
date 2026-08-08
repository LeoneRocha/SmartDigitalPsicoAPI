using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationLanguageRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IApplicationLanguageRepository : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<ApplicationLanguage>
    {

        /// <summary>
        /// Método ExistLanguage: executa a operação ExistLanguage.
        /// </summary>
        Task<bool> ExistLanguage(string language, string languageKey, string resourceKey = "SharedResource");
        /// <summary>
        /// Método Find: consulta e retorna dados.
        /// </summary>
        Task<ApplicationLanguage> Find(string language, string languageKey, string resourceKey = "SharedResource");

    }
}
