using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Application
{
    /// <summary>
    /// Interface (contrato) responsável por IApplicationLanguageRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IApplicationLanguageRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<ApplicationLanguage>
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
