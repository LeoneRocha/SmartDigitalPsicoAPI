namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por ICacheService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface ICacheService
    {
        bool Exists<T>(string? cacheKey) where T : class, new();
        bool TryGet<T>(string? cacheKey, out T value) where T : class, new();
        bool Set<T>(string? cacheKey, T value);
        bool Remove<T>(string? cacheKey);
        /// <summary>
        /// Método GetSlidingExpiration: consulta e retorna dados.
        /// </summary>
        DateTime GetSlidingExpiration();
        /// <summary>
        /// Método IsEnable: executa a operação IsEnable.
        /// </summary>
        bool IsEnable(); 
    }
}
