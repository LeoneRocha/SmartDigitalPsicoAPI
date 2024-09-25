namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class AuditDataEntityLog
    {
        public long Id { get; set; }
        public string TableName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string KeyValues { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public DateTime AuditDate { get; set; } = DateTime.UtcNow;
        public string? UserAuditedLogin { get; set; } = null;

        public User? UserAudited { get; set; }
        public long? UserAuditedId { get; set; }
    }
}
