namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLog.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class AuditDataSelectiveEntityLog  : AuditDataEntityLogBase
    { 
        public string RowKey { get; set; } = string.Empty;
        public string PartitionKey { get; set; } = string.Empty; 
    }
}
