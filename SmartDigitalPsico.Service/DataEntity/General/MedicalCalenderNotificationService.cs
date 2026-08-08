using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.DataEntity.General
{
    /// <summary>
    /// Classe responsável por MedicalCalenderNotificationService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class MedicalCalenderNotificationService : IMedicalCalenderNotificationService
    {
        private readonly ISharedServices _sharedServices;

        /// <summary>
        /// Método MedicalCalenderNotificationService: executa a operação MedicalCalenderNotificationService.
        /// </summary>
        public MedicalCalenderNotificationService(ISharedServices sharedServices)
        {
            _sharedServices = sharedServices;
        }

        /// <summary>
        /// Método NotifyAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task NotifyAsync(MedicalCalendar calendar, EMedicalCalendarActionType action)
        {
            GetNotificationTemplateDto? template = null;
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
                // Prefer canonical card templates (distinct header color per type).
                string emailBody = EmailTemplateBodyConstants.Resolve(template.TemplateKey) ?? template.Body;

                var notificationVO = new DataNotificationTemplateVO
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
            // Explicit lifecycle actions (update/delete/dispatch) must keep their templates.
            if (action is EMedicalCalendarActionType.Update
                or EMedicalCalendarActionType.Rescheduled
                or EMedicalCalendarActionType.Delete
                or EMedicalCalendarActionType.Cancelled
                or EMedicalCalendarActionType.NotificationDispatch)
            {
                return action;
            }

            if (calendar == null)
                return action;

            return calendar.Status switch
            {
                EStatusCalendar.Active
                    or EStatusCalendar.Scheduled
                    or EStatusCalendar.Confirmed
                    or EStatusCalendar.PendingConfirmation
                    or EStatusCalendar.InProgress
                    or EStatusCalendar.Rescheduled
                    or EStatusCalendar.PendingCancellation
                    => EMedicalCalendarActionType.Scheduled,
                EStatusCalendar.Canceled => EMedicalCalendarActionType.Cancelled,
                EStatusCalendar.Completed
                    or EStatusCalendar.NoShow
                    => EMedicalCalendarActionType.Update,
                EStatusCalendar.Refused => EMedicalCalendarActionType.Cancelled,
                _ => action
            };
        }

        private async Task<GetNotificationTemplateDto?> GetTemplate(string tag)
        {
            var templateResult = await _sharedServices.NotificationTemplateService.GetNotificationTemplatesAsync(tag);
            return templateResult != null && templateResult.Success ? templateResult.Data : null;
        }
    }
}
