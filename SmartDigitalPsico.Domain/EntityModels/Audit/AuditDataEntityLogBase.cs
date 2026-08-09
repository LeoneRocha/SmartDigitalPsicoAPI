using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por AuditDataEntityLogBase.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public abstract class AuditDataEntityLogBase : EntityBase
    {
        /// <summary>
        /// Método AuditDataEntityLogBase: executa a operação AuditDataEntityLogBase.
        /// </summary>
        protected AuditDataEntityLogBase()
        {
            ModifyDate = DateTime.UtcNow;
            CreatedDate = DateTime.UtcNow;
            LastAccessDate = DateTime.UtcNow;
            Enable = true;
        }
        public string TableName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string KeyValue { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public DateTime AuditDate { get; set; } = DateTime.UtcNow;
        public string? UserAuditedLogin { get; set; } = null;

        public User? UserAudited { get; set; }
        public long? UserAuditedId { get; set; }
    }
}
