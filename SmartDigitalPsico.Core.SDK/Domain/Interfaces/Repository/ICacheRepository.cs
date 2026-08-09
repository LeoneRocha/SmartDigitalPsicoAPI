namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por ICacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ICacheRepository
    {
        bool TryGet<T>(string cacheKey, out T? value);
        bool Set<T>(string cacheKey, T value);
        /// <summary>
        /// Método Remove: remove ou cancela um registro/recurso.
        /// </summary>
        bool Remove(string cacheKey);
    }

}
