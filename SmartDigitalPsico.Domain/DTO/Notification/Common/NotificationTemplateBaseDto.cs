namespace SmartDigitalPsico.Domain.DTO.Notification.Common
{
    /// <summary>
    /// Classe responsável por NotificationTemplateBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class NotificationTemplateBaseDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        /// <summary>
        /// Stable lookup key for this template (e.g. AppointmentScheduledSuccess).
        /// </summary>
        public string TemplateKey { get; set; } = string.Empty;
    }
}
