using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.DTO.Notification
{
    public class GenerateNotificationRecordsDto
    {
        public required MedicalCalendar MedicalCalendar { get; set; }
        public ENotificationType NotificationType { get; set; }
        public bool IsEnabled { get; set; } = true;  // Flag para buscar apenas regras ativas
        public bool IsCompleted { get; set; }
        // Outras propriedades podem ser adicionadas conforme necessário
    }

}
