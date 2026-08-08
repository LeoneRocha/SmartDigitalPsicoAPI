using SmartDigitalPsico.Domain.DTO.Notification.Common;
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

        /// <summary>
        /// Método MedicalScheduleNotificationAdapter: executa a operação MedicalScheduleNotificationAdapter.
        /// </summary>
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

        /// <summary>
        /// Método SendNotifyRegisterAsync: dispara notificação ou comunicação.
        /// </summary>
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

        /// <summary>
        /// Método CreateOrUpdateNotificationRecordsAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
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

        /// <summary>
        /// Método DeleteNotificationRecordsAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public Task DeleteNotificationRecordsAsync(string uniqueToken)
        {
            if (!Guid.TryParse(uniqueToken, out var tokenId) || tokenId == Guid.Empty)
                return Task.CompletedTask;
            return _notificationRecordsRepository.DeleteAllByTokenAsync(tokenId);
        }

        /// <summary>
        /// Método DeleteNotificationRecordsAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public Task DeleteNotificationRecordsAsync(string uniqueToken, DateTime eventDate)
        {
            if (!Guid.TryParse(uniqueToken, out var tokenId) || tokenId == Guid.Empty)
                return Task.CompletedTask;
            return _notificationRecordsRepository.DeleteByTokenAndEventAsync(tokenId, eventDate);
        }
    }
}
