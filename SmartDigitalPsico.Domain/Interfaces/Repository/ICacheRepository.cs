namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por ICacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ICacheRepository
    {
        bool TryGet<T>(string cacheKey, out T? value) ;
        bool Set<T>(string cacheKey, T value);
        /// <summary>
        /// Método Remove: remove ou cancela um registro/recurso.
        /// </summary>
        bool Remove(string cacheKey);
    }

}
