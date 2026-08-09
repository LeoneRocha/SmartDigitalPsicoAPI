using SmartDigitalPsico.Domain.DTO.User.GET;

namespace SmartDigitalPsico.Domain.DTO.Audit.Common
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class AuditDataSelectiveEntityLogBaseDto
    {
        public string RowKey { get; set; } = string.Empty;
        public string PartitionKey { get; set; } = string.Empty;

        public string TableName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string KeyValue { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public DateTime AuditDate { get; set; } = DateTime.UtcNow;
        public string? UserAuditedLogin { get; set; } = null;

        public GetUserDto? UserAudited { get; set; }
        public long? UserAuditedId { get; set; }
    }
}
