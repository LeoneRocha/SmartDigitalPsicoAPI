namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class AuditDataSelectiveEntityLog  : AuditDataEntityLogBase
    { 
        public string RowKey { get; set; } = string.Empty;
        public string PartitionKey { get; set; } = string.Empty; 
    }
}
