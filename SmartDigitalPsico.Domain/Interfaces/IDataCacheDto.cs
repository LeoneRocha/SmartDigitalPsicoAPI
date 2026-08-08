namespace SmartDigitalPsico.Domain.Interfaces
{

    /// <summary>
    /// Interface (contrato) responsável por IDataCacheDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IDataCacheDto<T>
    {
        public string CacheKey { get; }
        public string CacheId { get; }
        public DateTime DateTimeSlidingExpiration { get; }

        public T? Data { get; set; }
    }
}
