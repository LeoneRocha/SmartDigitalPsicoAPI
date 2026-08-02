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

        public Task CreateOrUpdateNotificationRecordsAsync(MedicalCalendar[] entities)
        {
            // ScheduleCalendar SoT Ids must not be written to NotificationRecords.MedicalCalendarId
            // (FK still references MedicalCalendar table). Email notify remains via SendNotifyRegisterAsync.
            return Task.CompletedTask;
        }

        public Task DeleteNotificationRecordsAsync(params long[] scheduleCalendarIds)
            => _notificationRecordsRepository.DeleteAll(scheduleCalendarIds);
    }
}
