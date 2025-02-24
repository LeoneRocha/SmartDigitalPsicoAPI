using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    public interface IMedicalCalenderNotificationService
    {
        Task NotifyAsync(MedicalCalendar calendar, EMedicalCalendarActionType action);
    }
}