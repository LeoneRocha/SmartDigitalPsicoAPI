using SmartDigitalPsico.Domain.DTO.Notification.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Schedule.Medical
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
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
