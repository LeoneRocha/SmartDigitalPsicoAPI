using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public abstract class NotificationTemplateBaseDto : EntityDtoBaseDomain
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        /// <summary>
        /// Stable lookup key for this template (e.g. AppointmentScheduledSuccess).
        /// </summary>
        public string TemplateKey { get; set; } = string.Empty;
    }
}
