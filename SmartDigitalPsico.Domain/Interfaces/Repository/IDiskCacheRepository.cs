namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IDiskCacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IDiskCacheRepository  
    {
        public Task<KeyValuePair<bool, T>> TryGetAsync<T>(string cacheKey) where T : new();

        /// <summary>
        /// Método RemoveAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public Task<bool> RemoveAsync(string cacheKey);

        public Task<bool> SetAsync<T>(string cacheKey, T value);
    }

}
