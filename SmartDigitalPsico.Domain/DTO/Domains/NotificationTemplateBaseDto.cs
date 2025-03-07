using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public abstract class NotificationTemplateBaseDto : EntityDtoBaseDomain
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string TagApi { get; set; } = string.Empty;
    }
}
