using Serilog;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Collections.Concurrent;

namespace SmartDigitalPsico.Service.Bussines.Notification
{
    public class NotificationDispatchJobService : INotificationDispatchJobService
    {
        private readonly INotificationRecordsService _notificationRecordsService;
        private readonly IMedicalCalenderNotificationService _medicalCalenderNotificationService;
        private readonly ILogger _logger;

        public NotificationDispatchJobService(
             INotificationRecordsService notificationRecordsService,
             IMedicalCalenderNotificationService medicalCalenderNotificationService,
             ILogger logger)
        {
            _notificationRecordsService = notificationRecordsService;
            _medicalCalenderNotificationService = medicalCalenderNotificationService;
            _logger = logger;
        }

        public async Task ProcessPendingNotificationsAsync()
        {
            _logger.Information(NotificationDispatchConstants.StartingProcessing);
            var pendingRecords = await _notificationRecordsService.GetPendingNotificationsAsync();
            _logger.Information(NotificationDispatchConstants.FoundPendingRecords, pendingRecords.Length);
            var currentUtc = DateHelper.GetDateTimeNowFromUtc();

            // Agrupa os registros com MedicalCalendar por MedicalId.
            var groupedRecords = pendingRecords
                .Where(r => r.MedicalCalendar != null)
                .GroupBy(r => r.MedicalCalendar!.MedicalId)
                .ToList();
            _logger.Information(NotificationDispatchConstants.RecordsGrouped, groupedRecords.Count);

            var updatedRecords = new ConcurrentBag<NotificationRecords>();

            // Processa os grupos em paralelo.
            await Parallel.ForEachAsync(groupedRecords, async (group, cancellationToken) =>
            {
                _logger.Debug(NotificationDispatchConstants.ProcessingGroup, group.Key, group.Count());
                foreach (var record in group)
                {
                    if (await ProcessRecordAsync(record, currentUtc))
                    {
                        updatedRecords.Add(record);
                        _logger.Debug(NotificationDispatchConstants.RecordProcessed, record.Id);
                    }
                }
            });

            // Processa também os registros sem MedicalCalendar.
            var recordsWithoutCalendar = pendingRecords.Where(r => r.MedicalCalendar == null).ToList();
            _logger.Information(NotificationDispatchConstants.ProcessingWithoutCalendar, recordsWithoutCalendar.Count);
            await Parallel.ForEachAsync(recordsWithoutCalendar, async (record, cancellationToken) =>
            {
                if (await ProcessRecordAsync(record, currentUtc))
                {
                    updatedRecords.Add(record);
                    _logger.Debug(NotificationDispatchConstants.RecordProcessed, record.Id);
                }
            });

            // Atualiza os registros processados de forma sequencial para preservar a thread-safety do DbContext.
            foreach (var record in updatedRecords)
            {
                var updateDto = MapToUpdateDto(record);
                await _notificationRecordsService.Update(updateDto);
                _logger.Information(NotificationDispatchConstants.RecordUpdated, record.Id);
            }
            _logger.Information(NotificationDispatchConstants.ProcessingCompleted, updatedRecords.Count);
        }

        private async Task<bool> ProcessRecordAsync(NotificationRecords record, DateTime currentUtc)
        {
            if (record.NotificationRules == null || !record.NotificationRules.Any())
                return false;

            var pendingRules = record.NotificationRules.Where(r => !r.IsSent && r.ScheduledSendTime <= currentUtc).ToList();
            if (!pendingRules.Any())
                return false;

            bool updated = false;
            foreach (var rule in pendingRules)
            {
                if (record.MedicalCalendar != null)
                {
                    await NotifyAsync(record.MedicalCalendar, record.Id, rule.ScheduledSendTime);
                    rule.IsSent = true;
                    rule.ActualSendTime = currentUtc;
                    updated = true;
                }
            }
            if (updated)
            {
                UpdateRecordStatus(record, currentUtc);
                _logger.Debug(NotificationDispatchConstants.UpdatedStatus, record.Id, record.NextScheduledSendTime, record.IsCompleted);
            }
            return updated;
        }

        private async Task NotifyAsync(MedicalCalendar calendar, long recordId, DateTime ruleTime)
        {
            _logger.Information(NotificationDispatchConstants.SendingNotification, recordId, ruleTime);
            await _medicalCalenderNotificationService.NotifyAsync(calendar, EMedicalCalendarActionType.NotificationDispatch);
        }

        private static void UpdateRecordStatus(NotificationRecords record, DateTime currentUtc)
        {
            var unsentRules = record.NotificationRules.Where(r => !r.IsSent).ToList();
            if (unsentRules.Any())
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

        private static UpdateNotificationRecordsDto MapToUpdateDto(NotificationRecords record)
        {
            return new UpdateNotificationRecordsDto
            {
                Id = record.Id,
                MedicalCalendarId = record.MedicalCalendarId,
                NotificationRules = record.NotificationRules,
                IsCompleted = record.IsCompleted,
                FinalSendDate = record.FinalSendDate,
                CreatedDate = record.CreatedDate,
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                Description = record.MedicalCalendar!.Description,
                Enable = record.Enable,
                EventDate = record.EventDate,
                Language = "en",
            };
        }
    }
}
