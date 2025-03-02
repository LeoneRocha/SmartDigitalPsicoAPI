using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.DataEntity.General
{
    public class MedicalCalenderNotificationService : IMedicalCalenderNotificationService
    {
        private readonly ISharedServices _sharedServices;

        public MedicalCalenderNotificationService(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        public async Task NotifyAsync(MedicalCalendar calendar, EMedicalCalendarActionType action)
        {
            GetEmailTemplateDto? template = null;            
            action = changeTypeActionByStatus(calendar, action);
            switch (action)
            {
                case EMedicalCalendarActionType.Add:
                case EMedicalCalendarActionType.Scheduled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentScheduledSuccess);                    
                    break;
                case EMedicalCalendarActionType.Update:
                case EMedicalCalendarActionType.Rescheduled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentRescheduled);                    
                    break;
                case EMedicalCalendarActionType.Delete:
                case EMedicalCalendarActionType.Cancelled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentCancelled);
                    break;
                case EMedicalCalendarActionType.NotificationDispatch:
                    template = await GetTemplate(EmailTemplateTagConstants.NotificationDispatch);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
            var tokens = new Dictionary<string, string>
            {
                { "MedicalName", calendar.Medical?.Name ?? string.Empty },
                { "PatientName", calendar.Patient?.Name ?? string.Empty },
                { "Title", calendar.Title },
                { "StartDateTime", calendar.StartDateTime.ToString("g") },
                { "EndDateTime", calendar.EndDateTime?.ToString("g") ?? string.Empty },
                { "Description", calendar.Description },
                { "AppointmentLocation", calendar.Location }
            };
            if (template != null)
            {
                string emailBody = template.Body;
                var notificationVO = new NotificationTemplate
                {
                    Subject = template.Subject,
                    Body = emailBody,
                    ToEmails = new List<string> { "leocr_lem@yahoo.com.br" }
                };

                await _sharedServices.SendNotificationService.SendNotificationAsync(notificationVO, ENotificationServiceType.Email, tokens);
            }
        }

        private static EMedicalCalendarActionType changeTypeActionByStatus(MedicalCalendar calendar, EMedicalCalendarActionType action)
        {
            if (calendar != null)
            {
                if (action != EMedicalCalendarActionType.NotificationDispatch)
                {
                    switch (calendar.Status)
                    {
                        case EStatusCalendar.Active:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.Scheduled:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.Confirmed:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.Refused:
                            return EMedicalCalendarActionType.Refused;
                        case EStatusCalendar.Completed:
                            return EMedicalCalendarActionType.Update;
                        case EStatusCalendar.NoShow:
                            return EMedicalCalendarActionType.Update;
                        case EStatusCalendar.PendingConfirmation:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.InProgress:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.Rescheduled:
                            return EMedicalCalendarActionType.Scheduled;
                        case EStatusCalendar.Canceled:
                            return EMedicalCalendarActionType.Cancelled;
                        case EStatusCalendar.PendingCancellation:
                            return EMedicalCalendarActionType.Scheduled;
                        default:
                            break;
                    }
                } 
            }
            return action;
        }

        private async Task<GetEmailTemplateDto?> GetTemplate(string tag)
        {
            var templateResult = await _sharedServices.EmailTemplateService.GetEmailTemplateAsync(tag);
            return templateResult != null && templateResult.Success ? templateResult.Data : null;
        }
    }
}
