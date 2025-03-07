using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class NotificationTemplate : EntityBase, IEntityBaseDomains
    {  
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty; 
        public string TagApi { get; set; } = string.Empty;
        public ENotificationServiceType NotificationTemplateType { get; set; }
    }
}
