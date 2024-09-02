using Azure;
using Azure.Data.Tables;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;

namespace SmartDigitalPsico.Domain.TableEntityNoSQL
{
    public abstract class BaseEntityTable : ITableEntity, ITableBaseEntity
    {
        public string PartitionKey { get; set; } = string.Empty;
        public string RowKey { get; set; } = string.Empty;
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
