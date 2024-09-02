using Azure;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface ITableBaseEntity
    {
        ETag ETag { get; set; }
        string PartitionKey { get; set; }
        string RowKey { get; set; }
        DateTimeOffset? Timestamp { get; set; }
    }
}