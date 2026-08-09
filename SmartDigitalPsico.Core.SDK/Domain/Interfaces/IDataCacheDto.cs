namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces
{

    /// <summary>
    /// Interface (contrato) responsável por IDataCacheDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IDataCacheDto<T>
    {
        public string CacheKey { get; }
        public string CacheId { get; }
        public DateTime DateTimeSlidingExpiration { get; }

        public T? Data { get; set; }
    }
}
