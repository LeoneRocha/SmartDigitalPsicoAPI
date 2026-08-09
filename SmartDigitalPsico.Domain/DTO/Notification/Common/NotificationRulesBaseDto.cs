using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Notification.Common
{
    /// <summary>
    /// Classe responsável por NotificationRulesBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class NotificationRulesBaseDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain
    {
        public long MedicalId { get; set; }
        public bool IsEnabled { get; set; }
        public EIntervalNotificationType IntervalType { get; set; }
        public short IntervalValue { get; set; }
        public bool IsBefore { get; set; }
        public ENotificationServiceType[] ENotificationServiceType { get; set; } = [];

    }
}

