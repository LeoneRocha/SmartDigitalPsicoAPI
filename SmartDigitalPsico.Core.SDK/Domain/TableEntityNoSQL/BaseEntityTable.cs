using Azure;
using Azure.Data.Tables;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;

namespace SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL
{
    /// <summary>
    /// Classe responsável por BaseEntityTable.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class BaseEntityTable : ITableEntity, ITableBaseEntity
    {
        public string PartitionKey { get; set; } = string.Empty;
        public string RowKey { get; set; } = string.Empty;
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
