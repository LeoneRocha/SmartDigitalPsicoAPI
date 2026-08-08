using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.DTO.Notification.Common
{
    /// <summary>
    /// Classe responsável por GenerateNotificationRecordsDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GenerateNotificationRecordsDto
    {
        public required MedicalCalendar[] MedicalCalendars { get; set; }
        public ENotificationType NotificationType { get; set; }
        public bool IsEnabled { get; set; } = true;  // Flag para buscar apenas regras ativas
        public bool IsCompleted { get; set; }
        // Outras propriedades podem ser adicionadas conforme necessário
    }

}
