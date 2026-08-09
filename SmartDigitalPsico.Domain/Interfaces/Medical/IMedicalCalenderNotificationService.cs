using SmartDigitalPsico.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalCalenderNotificationService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IMedicalCalenderNotificationService
    {
        /// <summary>
        /// Método NotifyAsync: dispara notificação ou comunicação.
        /// </summary>
        Task NotifyAsync(MedicalCalendar calendar, EMedicalCalendarActionType action);
    }
}
