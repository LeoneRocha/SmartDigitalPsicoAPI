using Azure;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por ITableBaseEntity.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ITableBaseEntity
    {
        ETag ETag { get; set; }
        string PartitionKey { get; set; }
        string RowKey { get; set; }
        DateTimeOffset? Timestamp { get; set; }
    }
}
