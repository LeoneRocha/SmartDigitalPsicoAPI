using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por NotificationTemplateBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class NotificationTemplateBaseDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        /// <summary>
        /// Stable lookup key for this template (e.g. AppointmentScheduledSuccess).
        /// </summary>
        public string TemplateKey { get; set; } = string.Empty;
    }
}
