using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por NotificationTemplate.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class NotificationTemplate : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {  
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty; 
        /// <summary>
        /// Stable lookup key for this template (e.g. AppointmentScheduledSuccess).
        /// </summary>
        public string TemplateKey { get; set; } = string.Empty;
        public ENotificationServiceType NotificationTemplateType { get; set; }
    }
}
