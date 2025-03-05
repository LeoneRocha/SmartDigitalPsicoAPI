using Serilog;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Events; // Para ProgressEventArgs
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

        // Evento de progresso que pode ser assinado para acompanhar o percentual de processamento.
        public event EventHandler<NotificationProgressEventArgs>? ProgressChanged;
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
            LogInformation(NotificationDispatchConstants.StartingProcessing);
            var pendingRecords = await _notificationRecordsService.GetPendingNotificationsAsync();
            var currentUtc = DateHelper.GetDateTimeNowFromUtc();

            // Filtra os registros pendentes antes de qualquer processamento
            var filteredRecords = FilterPendingRecords(pendingRecords, currentUtc);

            int totalRecords = filteredRecords.Length; // Total de registros pendentes
            int processedCount = 0; // Contador compartilhado para progresso

            // Dispara evento inicial de progresso com 0%
            RaiseProgressChanged(0, totalRecords);

            // Agrupa os registros com MedicalCalendar por MedicalId.
            var groupedRecords = filteredRecords
                .Where(r => r.MedicalCalendar != null)
                .GroupBy(r => r.MedicalCalendar!.MedicalId)
                .ToList();

            var updatedRecords = new ConcurrentBag<NotificationRecords>();

            // Processa os grupos em paralelo.
            processedCount = await ProcesseByMedicalId(currentUtc, totalRecords, processedCount, groupedRecords, updatedRecords);

            // Processa também os registros sem MedicalCalendar.
            processedCount = await ProcessWithOutMedical(currentUtc, filteredRecords, totalRecords, processedCount, updatedRecords);

            // Atualiza os registros processados de forma sequencial para preservar a thread-safety do DbContext.
            await UpdateRecordsSended(updatedRecords);

            LogInformation(NotificationDispatchConstants.ProcessingCompleted, updatedRecords.Count);
        }

        private async Task UpdateRecordsSended(ConcurrentBag<NotificationRecords> updatedRecords)
        {
            foreach (var record in updatedRecords)
            {
                var updateDto = MapToUpdateDto(record);
                await _notificationRecordsService.Update(updateDto);
                LogInformation(NotificationDispatchConstants.UpdatedStatus, record.Id);
            }
        }

        private async Task<int> ProcessWithOutMedical(DateTime currentUtc, NotificationRecords[] filteredRecords, int totalRecords, int processedCount, ConcurrentBag<NotificationRecords> updatedRecords)
        {
            var recordsWithoutCalendar = filteredRecords.Where(r => r.MedicalCalendar == null).ToList();
            await Parallel.ForEachAsync(recordsWithoutCalendar, async (record, cancellationToken) =>
            {
                if (await ProcessRecordAsync(record, currentUtc))
                {
                    updatedRecords.Add(record);
                    int current = Interlocked.Increment(ref processedCount);
                    RaiseProgressChanged(current, totalRecords);
                }
            });
            return processedCount;
        }

        private async Task<int> ProcesseByMedicalId(DateTime currentUtc, int totalRecords, int processedCount, List<IGrouping<long, NotificationRecords>> groupedRecords, ConcurrentBag<NotificationRecords> updatedRecords)
        {
            await Parallel.ForEachAsync(groupedRecords, async (group, cancellationToken) =>
            {
                foreach (var record in group)
                {
                    if (await ProcessRecordAsync(record, currentUtc))
                    {
                        updatedRecords.Add(record);
                        int current = Interlocked.Increment(ref processedCount);
                        RaiseProgressChanged(current, totalRecords);
                    }
                }
            });
            return processedCount;
        }

        private  NotificationRecords[] FilterPendingRecords(NotificationRecords[] records, DateTime currentUtc)
        {
            // Método para filtrar os registros pendentes com base nas regras
            return records
                .Where(record =>
                    record.NotificationRules != null &&
                    record.NotificationRules.Count(rule => !rule.IsSent && rule.ScheduledSendTime <= currentUtc) > 0
                )
                .ToArray();
        }

        private async Task<bool> ProcessRecordAsync(NotificationRecords record, DateTime currentUtc)
        {
            if (record.NotificationRules == null || record.NotificationRules.Length == 0)
                return false;

            var pendingRules = record.NotificationRules.Where(r => !r.IsSent && r.ScheduledSendTime <= currentUtc).ToList();
            if (pendingRules.Count == 0)
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
            }
            return updated;
        }

        private async Task NotifyAsync(MedicalCalendar calendar, long recordId, DateTime ruleTime)
        {
            await _medicalCalenderNotificationService.NotifyAsync(calendar, EMedicalCalendarActionType.NotificationDispatch);
            LogInformation(NotificationDispatchConstants.SendedNotification, recordId, ruleTime);
        }

        private static void UpdateRecordStatus(NotificationRecords record, DateTime currentUtc)
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

        private void LogInformation(string message, params object[] args)
        {
            _logger.Information(message, args);
        }
        // Método para disparar o evento de progresso
        private void RaiseProgressChanged(int processed, int total)
        {
            ProgressChanged?.Invoke(this, new NotificationProgressEventArgs
            {
                Processed = processed,
                Total = total
            });
            if (total > 0 && processed > 0)
            {
                // Log para progresso em porcentagem
                LogInformation("Processing progress: {Percentage:F2}% / Progresso do processamento: {Percentage:F2}%", (double)processed / total * 100);
            }
        }
    }
}