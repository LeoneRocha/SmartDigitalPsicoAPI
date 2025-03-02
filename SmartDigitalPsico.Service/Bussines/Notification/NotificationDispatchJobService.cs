using Serilog;
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
            _logger.Information("Iniciando processamento de notificações pendentes.");
            var pendingRecords = await _notificationRecordsService.GetPendingNotificationsAsync();
            _logger.Information("Encontrados {Count} registros pendentes.", pendingRecords.Length);
            var currentUtc = DateHelper.GetDateTimeNowFromUtc();

            // Agrupa registros com MedicalCalendar por MedicalId.
            var groupedRecords = pendingRecords
                .Where(r => r.MedicalCalendar != null)
                .GroupBy(r => r.MedicalCalendar!.MedicalId)
                .ToList();
            _logger.Information("Registros agrupados em {GroupCount} grupos.", groupedRecords.Count);

            var updatedRecords = new ConcurrentBag<NotificationRecords>();

            // Processa os grupos em paralelo.
            await Parallel.ForEachAsync(groupedRecords, async (group, cancellationToken) =>
            {
                _logger.Debug("Processando grupo para MedicalId {MedicalId} com {Count} registros.", group.Key, group.Count());
                foreach (var record in group)
                {
                    if (await ProcessRecordAsync(record, currentUtc))
                    {
                        updatedRecords.Add(record);
                        _logger.Debug("Registro {RecordId} processado para atualização.", record.Id);
                    }
                }
            });

            // Processa os registros sem MedicalCalendar.
            var recordsWithoutCalendar = pendingRecords.Where(r => r.MedicalCalendar == null).ToList();
            _logger.Information("Processando {Count} registros sem MedicalCalendar.", recordsWithoutCalendar.Count);
            await Parallel.ForEachAsync(recordsWithoutCalendar, async (record, cancellationToken) =>
            {
                if (await ProcessRecordAsync(record, currentUtc))
                {
                    updatedRecords.Add(record);
                    _logger.Debug("Registro {RecordId} (sem MedicalCalendar) processado para atualização.", record.Id);
                }
            });

            // Atualiza os registros processados (executado de forma sequencial para preservar a thread-safety do DbContext).
            foreach (var record in updatedRecords)
            {
                var updateDto = MapToUpdateDto(record);
                await _notificationRecordsService.Update(updateDto);
                _logger.Information("Registro {RecordId} atualizado com sucesso.", record.Id);
            }
            _logger.Information("Processamento concluído. Registros atualizados: {UpdatedCount}.", updatedRecords.Count);
        }

        /// <summary>
        /// Processa um registro pendente enviando notificações para as regras cujo ScheduledSendTime já ocorreu.
        /// Retorna true se ao menos uma regra foi processada.
        /// </summary>
        private async Task<bool> ProcessRecordAsync(NotificationRecords record, DateTime currentUtc)
        {
            if (record.NotificationRules == null || !record.NotificationRules.Any())
                return false;

            var pendingRules = record.NotificationRules
                                    .Where(r => !r.IsSent && r.ScheduledSendTime <= currentUtc)
                                    .ToList();

            if (!pendingRules.Any())
                return false;

            bool updated = false;
            foreach (var rule in pendingRules)
            {
                if (record.MedicalCalendar != null)
                {
                    await NotifyAsync(record.MedicalCalendar, record.Id, rule.ScheduledSendTime);
                    rule.IsSent = true;
                    updated = true;
                }
            }

            if (updated)
            {
                UpdateRecordStatus(record, currentUtc);
                _logger.Debug("Registro {RecordId} atualizado: NextScheduledSendTime={NextTime}, IsCompleted={Completed}.",
                    record.Id, record.NextScheduledSendTime, record.IsCompleted);
            }
            return updated;
        }

        /// <summary>
        /// Envia a notificação para o MedicalCalendar e registra o evento.
        /// </summary>
        private async Task NotifyAsync(MedicalCalendar calendar, long recordId, DateTime ruleTime)
        {
            _logger.Information("Enviando notificação para registro {RecordId} (ScheduledSendTime: {ScheduleTime}).", recordId, ruleTime);
            await _medicalCalenderNotificationService.NotifyAsync(calendar, EMedicalCalendarActionType.Add);
        }

        /// <summary>
        /// Atualiza os campos NextScheduledSendTime, IsCompleted e FinalSendDate com base nas regras ainda não enviadas.
        /// </summary>
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

        /// <summary>
        /// Mapeia o registro atualizado para o DTO de atualização.
        /// </summary>
        private static UpdateNotificationRecordsDto MapToUpdateDto(NotificationRecords record)
        {
            return new UpdateNotificationRecordsDto
            {
                Id = record.Id,
                MedicalCalendarId = record.MedicalCalendarId,
                NotificationRules = record.NotificationRules,
                IsCompleted = record.IsCompleted,
                FinalSendDate = record.FinalSendDate,
                ModifyDate = DateTime.UtcNow
            };
        }
    }
}
