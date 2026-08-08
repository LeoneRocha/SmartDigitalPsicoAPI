using Serilog;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Events;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace SmartDigitalPsico.Service.Bussines.Notification
{
    /// <summary>
    /// Classe responsável por NotificationDispatchJobService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class NotificationDispatchJobService : INotificationDispatchJobService
    {
        private readonly INotificationRecordsService _notificationRecordsService;
        private readonly IMedicalCalenderNotificationService _medicalCalenderNotificationService;
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;
        private readonly IPatientRepositories _patientRepositories;
        private readonly ILogger _logger;

        public event EventHandler<NotificationProgressEventArgs>? ProgressChanged;

        /// <summary>
        /// Método NotificationDispatchJobService: executa a operação NotificationDispatchJobService.
        /// </summary>
        public NotificationDispatchJobService(
             INotificationRecordsService notificationRecordsService,
             IMedicalCalenderNotificationService medicalCalenderNotificationService,
             IScheduleCalendarRepository scheduleCalendarRepository,
             IPatientRepositories patientRepositories,
             ILogger logger)
        {
            _notificationRecordsService = notificationRecordsService;
            _medicalCalenderNotificationService = medicalCalenderNotificationService;
            _scheduleCalendarRepository = scheduleCalendarRepository;
            _patientRepositories = patientRepositories;
            _logger = logger;
        }

        /// <summary>
        /// Método ProcessPendingNotificationsAsync: executa a operação ProcessPendingNotificationsAsync.
        /// </summary>
        public async Task ProcessPendingNotificationsAsync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();

            LogInformation(NotificationDispatchConstants.StartingProcessing);
            var pendingRecords = await _notificationRecordsService.GetPendingNotificationsAsync();
            var currentUtc = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            var filteredRecords = FilterPendingRecords(pendingRecords, currentUtc);
            int totalRecords = filteredRecords.Length;
            int processedCount = 0;

            LogInformation(NotificationDispatchConstants.FoundPendingRecords, totalRecords);
            RaiseProgressChanged(0, totalRecords);

            var updatedRecords = new ConcurrentBag<NotificationRecord>();
            var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
            await Parallel.ForEachAsync(filteredRecords, parallelOptions, async (record, cancellationToken) =>
            {
                if (await ProcessRecordAsync(record, currentUtc))
                {
                    updatedRecords.Add(record);
                    int current = Interlocked.Increment(ref processedCount);
                    RaiseProgressChanged(current, totalRecords);
                }
            });

            await UpdateRecordsSended(updatedRecords);

            LogInformation(NotificationDispatchConstants.ProcessingCompleted, processedCount);
             
            stopwatch.Stop();
            _logger.Information("NotificationDispatchJobService - ProcessPendingNotificationsAsync : Finished at: {Time}  Duration:  {DurationTime}", SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog(), LogAppHelper.GetDurationStopwatch(stopwatch));
        }

        private async Task UpdateRecordsSended(ConcurrentBag<NotificationRecord> updatedRecords)
        {
            foreach (var record in updatedRecords)
            {
                var updateDto = MapToUpdateDto(record);
                await _notificationRecordsService.Update(updateDto);
                LogInformation(NotificationDispatchConstants.RecordUpdated, record.Id);
            } 
        }

        private static NotificationRecord[] FilterPendingRecords(NotificationRecord[] records, DateTime currentUtc)
        {
            return records
                .Where(record =>
                    record.NotificationRules != null &&
                    record.NotificationRules.Any(rule => !rule.IsSent && rule.ScheduledSendTime <= currentUtc)  
                )
                .ToArray();
        }

        private async Task<bool> ProcessRecordAsync(NotificationRecord record, DateTime currentUtc)
        {
            if (record.NotificationRules == null || record.NotificationRules.Length == 0)
                return false;

            var pendingRules = record.NotificationRules.Where(r => !r.IsSent && r.ScheduledSendTime <= currentUtc).ToList();
            if (pendingRules.Count == 0)
                return false;

            if (record.TokenId == Guid.Empty)
                return false;

            var package = await _scheduleCalendarRepository.GetByUniqueTokenAsync(record.TokenId.ToString());
            if (package == null)
                return false;

            var calendar = MedicalScheduleMapper.ToMedicalCalendarFromPackage(package, record.EventDate);
            await HydratePatientAndMedicalAsync(calendar);

            bool updated = false;
            foreach (var rule in pendingRules)
            {
                await NotifyAsync(calendar, record.Id, rule.ScheduledSendTime);
                rule.IsSent = true;
                rule.ActualSendTime = currentUtc;
                updated = true;
            }
            if (updated)
            {
                UpdateRecordStatus(record, currentUtc);
            }
            return updated;
        }

        private async Task HydratePatientAndMedicalAsync(MedicalCalendar calendar)
        {
            if (calendar.Patient != null && calendar.Medical != null)
                return;

            if (!calendar.PatientId.HasValue || calendar.PatientId.Value <= 0)
                return;

            var patient = await _patientRepositories.PatientRepository.FindAsync(
                calendar.PatientId.Value, p => p.Medical!);
            calendar.Patient = patient;
            calendar.Medical = patient?.Medical;
        }

        private async Task NotifyAsync(MedicalCalendar calendar, long recordId, DateTime ruleTime)
        {
            await _medicalCalenderNotificationService.NotifyAsync(calendar, EMedicalCalendarActionType.NotificationDispatch);
            LogInformation(NotificationDispatchConstants.SendedNotification, recordId, ruleTime);
        }

        private static void UpdateRecordStatus(NotificationRecord record, DateTime currentUtc)
        {
            var unsentRules = record.NotificationRules.Where(r => !r.IsSent).ToList();
            if (unsentRules.Count > 0)
            {
                record.NextScheduledSendTime = unsentRules.Min(r => r.ScheduledSendTime);
                record.IsCompleted = false;
                record.FinalSendDate = null;
            }
            else
            {
                record.NextScheduledSendTime = null;
                record.IsCompleted = true;
                record.FinalSendDate = currentUtc;
            }
        }

        private static UpdateNotificationRecordsDto MapToUpdateDto(NotificationRecord record)
        {
            return new UpdateNotificationRecordsDto
            {
                Id = record.Id,
                TokenId = record.TokenId,
                NotificationRules = record.NotificationRules,
                IsCompleted = record.IsCompleted,
                FinalSendDate = record.FinalSendDate,
                CreatedDate = record.CreatedDate,
                ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                Description = string.Empty,
                Enable = record.Enable,
                EventDate = record.EventDate,
                Language = "en",
            };
        }

        private void LogInformation(string message, params object[] args)
        {
            _logger.Information(message, args);
        }

        private void RaiseProgressChanged(int processed, int total)
        {
            ProgressChanged?.Invoke(this, new NotificationProgressEventArgs
            {
                Processed = processed,
                Total = total
            });
            if (total > 0 && processed > 0)
            {
                double percentage = (double)processed / total * 100;
                LogInformation("Processing progress: {Percentage:F2}% / Progresso do processamento: {Percentage:F2}%", percentage);
            }
        }
    }
}
