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

        public async Task SendNotifyRegisterAsync(MedicalCalendar entityAdd)
        {
            if (entityAdd.Patient == null || entityAdd.Medical == null)
            {
                var patient = await _patientRepositoriesShared.PatientRepository.FindAsync(
                    entityAdd.PatientId.GetValueOrDefault(), p => p.Medical!);
                entityAdd.Patient = patient;
                entityAdd.Medical = patient?.Medical;
            }

            await _medicalCalenderNotification.NotifyAsync(entityAdd, EMedicalCalendarActionType.Add);
        }

        public async Task CreateOrUpdateNotificationRecordsAsync(MedicalCalendar[] entities)
        {
            var notificationDto = new GenerateNotificationRecordsDto
            {
                MedicalCalendars = entities,
                IsEnabled = true,
                NotificationType = ENotificationType.BeforeAppointment
            };
            await _notificationRecordsService.CreateOrUpdateNotificationRecordsAsync(notificationDto);
        }

        public Task DeleteNotificationRecordsAsync(params long[] scheduleCalendarIds)
            => _notificationRecordsRepository.DeleteAll(scheduleCalendarIds);
    }
}
