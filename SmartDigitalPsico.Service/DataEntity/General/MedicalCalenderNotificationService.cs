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
        private readonly ISharedRepositories _sharedRepositories;

        public MedicalCalenderNotificationService(ISharedServices sharedServices, ISharedRepositories sharedRepositories)
        {
            _sharedRepositories = sharedRepositories;
            _sharedServices = sharedServices;
        }

        public async Task NotifyAsync(MedicalCalendar calendar, EMedicalCalendarActionType action)
        {
            GetEmailTemplateDto? template = null;
            long userId = 0;
            switch (action)
            {
                case EMedicalCalendarActionType.Add:
                case EMedicalCalendarActionType.Scheduled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentScheduledSuccess);
                    userId = calendar.CreatedUserId.GetValueOrDefault();
                    break;
                case EMedicalCalendarActionType.Update:
                case EMedicalCalendarActionType.Rescheduled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentRescheduled);
                    userId = calendar.ModifyUserId.GetValueOrDefault();
                    break;
                case EMedicalCalendarActionType.Delete:
                case EMedicalCalendarActionType.Cancelled:
                    template = await GetTemplate(EmailTemplateTagConstants.AppointmentCancelled);
                    userId = calendar.ModifyUserId.GetValueOrDefault();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            } 
            User userAction = await _sharedRepositories.UserRepository.FindByID(userId);


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

                await _sharedServices.SendNotificationService.SendNotificationAsync(notificationVO, NotificationServiceType.Email, tokens);
            }
        }

        private async Task<GetEmailTemplateDto?> GetTemplate(string tag)
        {
            var templateResult = await _sharedServices.EmailTemplateService.GetEmailTemplateAsync(tag);
            return templateResult != null && templateResult.Success ? templateResult.Data : null;
        }
    }
}
