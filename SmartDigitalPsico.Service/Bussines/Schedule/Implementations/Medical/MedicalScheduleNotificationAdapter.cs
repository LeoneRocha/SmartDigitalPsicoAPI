using SmartDigitalPsico.Domain.DTO.Notification;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Clinical notification side-effects (Medical host only). Does not persist MedicalCalendar.
    /// </summary>
    public class MedicalScheduleNotificationAdapter
    {
        private readonly IPatientRepositories _patientRepositoriesShared;
        private readonly IMedicalCalenderNotificationService _medicalCalenderNotification;
        private readonly INotificationRecordsService _notificationRecordsService;
        private readonly INotificationRecordsRepository _notificationRecordsRepository;

        public MedicalScheduleNotificationAdapter(
            IPatientRepositories patientRepositoriesShared,
            IMedicalCalenderNotificationService medicalCalenderNotification,
            INotificationRecordsService notificationRecordsService,
            INotificationRecordsRepository notificationRecordsRepository)
        {
            _patientRepositoriesShared = patientRepositoriesShared;
            _medicalCalenderNotification = medicalCalenderNotification;
            _notificationRecordsService = notificationRecordsService;
            _notificationRecordsRepository = notificationRecordsRepository;
        }

        public async Task SendNotifyRegisterAsync(MedicalCalendar entity, EMedicalCalendarActionType action = EMedicalCalendarActionType.Add)
        {
            if (entity.Patient == null || entity.Medical == null)
            {
                var patient = await _patientRepositoriesShared.PatientRepository.FindAsync(
                    entity.PatientId.GetValueOrDefault(), p => p.Medical!);
                entity.Patient = patient;
                entity.Medical = patient?.Medical;
            }

            await _medicalCalenderNotification.NotifyAsync(entity, action);
        }

        public async Task CreateOrUpdateNotificationRecordsAsync(MedicalCalendar[] entities)
        {
            // SoT Ids are ScheduleCalendar — must not be written to NotificationRecords.MedicalCalendarId
            // (FK still references MedicalCalendar). Persist reminder rules with MedicalCalendarId = null.
            var forRecords = entities.Select(WithoutMedicalCalendarFk).ToArray();
            var notificationDto = new GenerateNotificationRecordsDto
            {
                MedicalCalendars = forRecords,
                IsEnabled = true,
                NotificationType = ENotificationType.BeforeAppointment
            };
            await _notificationRecordsService.CreateOrUpdateNotificationRecordsAsync(notificationDto);
        }

        public Task DeleteNotificationRecordsAsync(params long[] scheduleCalendarIds)
            => _notificationRecordsRepository.DeleteAll(scheduleCalendarIds);

        /// <summary>
        /// Clone with Id=0 so NotificationRecords.MedicalCalendarId stays null (avoids FK to MedicalCalendar).
        /// </summary>
        private static MedicalCalendar WithoutMedicalCalendarFk(MedicalCalendar source)
            => new()
            {
                Id = 0,
                Enable = source.Enable,
                Title = source.Title,
                Description = source.Description,
                Location = source.Location,
                StartDateTime = source.StartDateTime,
                EndDateTime = source.EndDateTime,
                IsAllDay = source.IsAllDay,
                Status = source.Status,
                ColorCategoryHexa = source.ColorCategoryHexa,
                TimeZone = source.TimeZone,
                IsPushedCalendar = source.IsPushedCalendar,
                RecurrenceDays = source.RecurrenceDays,
                RecurrenceType = source.RecurrenceType,
                RecurrenceEndDate = source.RecurrenceEndDate,
                RecurrenceCount = source.RecurrenceCount,
                TokenRecurrence = source.TokenRecurrence,
                MedicalId = source.MedicalId,
                PatientId = source.PatientId,
                Patient = source.Patient,
                Medical = source.Medical
            };
    }
}
