using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands
{
    /// <summary>
    /// Classe responsável por ScheduleUpdateService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleUpdateService : IScheduleUpdateService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IScheduleConflictService _conflictService;
        private readonly ILogger _logger;

        /// <summary>
        /// Método ScheduleUpdateService: operação de agendamento.
        /// </summary>
        public ScheduleUpdateService(
            IScheduleCalendarRepository repository,
            IScheduleConflictService conflictService,
            ILogger logger)
        {
            _repository = repository;
            _conflictService = conflictService;
            _logger = logger;
        }

        /// <summary>
        /// Update: conflito batch (CPU Parallel interno) → merge/replace → 1× Update.
        /// Sem Parallel neste serviço: MergeByStartDateTime é sequencial (estado compartilhado; Dictionary O(1)).
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar>> UpdateAsync(ScheduleCalendarWriteRequest request)
        {
            var response = new ServiceResponse<ScheduleCalendar>();
            try
            {
                if (string.IsNullOrWhiteSpace(request.UniqueToken)
                    || string.IsNullOrWhiteSpace(request.OwnerKey)
                    || string.IsNullOrWhiteSpace(request.TenantKey)
                    || request.Items == null
                    || request.Items.Length == 0)
                {
                    response.Success = false;
                    response.Message = "UniqueToken, TenantKey, OwnerKey and Items are required.";
                    return response;
                }

                var token = request.UniqueToken.Trim();
                ScheduleCalendar? entity = null;
                if (request.PackageId is > 0)
                    entity = await _repository.FindByID(request.PackageId.Value);
                if (entity == null)
                    entity = await _repository.GetByUniqueTokenAsync(token);

                if (entity == null)
                {
                    response.Success = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                var conflict = await EnsureNoConflictAsync(request, entity.UniqueToken);
                if (conflict != null)
                    return conflict;

                var now = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entity.Enable = request.Enable;
                entity.ModifyDate = now;
                entity.LastAccessDate = now;
                entity.TenantKey = ScheduleKeyHelper.RequireTenant(request.TenantKey);
                entity.OwnerKey = request.OwnerKey;
                entity.SubjectKey = request.SubjectKey;

                ScheduleCalendarItem[] finalItems;
                if (request.IsUpdate && !request.UpdateSeries)
                    finalItems = MergeByStartDateTime(entity.ScheduleData, request.Items);
                else
                    finalItems = request.Items;

                var (startPeriod, endPeriod) = ComputePeriod(finalItems);
                entity.StartPeriod = startPeriod;
                entity.EndPeriod = endPeriod;
                entity.ScheduleData = finalItems;
                entity = await _repository.Update(entity);

                response.Data = entity;
                response.Success = true;
                response.Message = "Agenda schedule saved.";
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleUpdateService.UpdateAsync failed. Inner={Inner}", ex.InnerException?.Message);
                response.Success = false;
                response.Message = ex.InnerException?.Message ?? ex.Message;
                return response;
            }
        }

        /// <summary>
        /// Método CancelOccurrenceAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCancelResult>> CancelOccurrenceAsync(ScheduleCancelRequest request)
        {
            var response = new ServiceResponse<ScheduleCancelResult>();
            try
            {
                var tenant = ScheduleKeyHelper.RequireTenant(request.TenantKey);
                var item = await _repository.GetItemAsync(tenant, request.OwnerKey, request.SubjectKey, request.AppointmentDateTime);
                if (item == null)
                {
                    response.Success = false;
                    response.Message = "Appointment not found.";
                    return response;
                }

                var packages = await _repository.GetOverlappingByOwnerAsync(
                    tenant, request.OwnerKey, request.AppointmentDateTime, request.AppointmentDateTime.AddMinutes(1));

                var package = packages.FirstOrDefault(p =>
                    (request.SubjectKey == null || p.SubjectKey == null || p.SubjectKey == request.SubjectKey)
                    && p.ScheduleData != null
                    && p.ScheduleData.Any(i => i.StartDateTime == item.StartDateTime));

                if (package == null)
                {
                    response.Success = false;
                    response.Message = "Appointment package not found.";
                    return response;
                }

                var newStatus = item.Status;
                // Sequencial: mutação in-place do mesmo ScheduleData — Parallel não é seguro/útil aqui.
                for (var i = 0; i < package.ScheduleData.Length; i++)
                {
                    var entry = package.ScheduleData[i];
                    if (entry.StartDateTime != item.StartDateTime)
                        continue;

                    if (entry.Status == EStatusCalendar.PendingConfirmation)
                        entry.Status = EStatusCalendar.Canceled;
                    else if (entry.Status == EStatusCalendar.Confirmed)
                        entry.Status = EStatusCalendar.PendingCancellation;

                    entry.ReasonCancellation = request.Reason ?? string.Empty;
                    newStatus = entry.Status;
                }

                package.ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                await _repository.Update(package);

                response.Success = true;
                response.Data = new ScheduleCancelResult
                {
                    PackageId = package.Id,
                    UniqueToken = package.UniqueToken,
                    NewStatus = newStatus
                };
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleUpdateService.CancelOccurrenceAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// Conflito em batch: 1 query de janela + checks CPU (via ConflictService). Sem N× Find no loop.
        /// Propaga Errors detalhados (PatientId, datas, horários) para o FE.
        /// </summary>
        private async Task<ServiceResponse<ScheduleCalendar>?> EnsureNoConflictAsync(
            ScheduleCalendarWriteRequest request, string excludeToken)
        {
            StampSubjectKey(request);

            var check = await _conflictService.HasNoConflictBatchAsync(
                request.TenantKey, request.OwnerKey, request.Items, excludeToken);
            if (!check.Success || !check.Data)
            {
                return new ServiceResponse<ScheduleCalendar>
                {
                    Success = false,
                    Message = check.Message ?? "There is a scheduling conflict for the specified time.",
                    Errors = check.Errors ?? []
                };
            }
            return null;
        }

        private static void StampSubjectKey(ScheduleCalendarWriteRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.SubjectKey) || request.Items == null)
                return;
            foreach (var item in request.Items)
                item.SubjectKey ??= request.SubjectKey;
        }

        private static (DateTime start, DateTime end) ComputePeriod(ScheduleCalendarItem[] items)
        {
            var start = items.Min(i => i.StartDateTime);
            var end = items.Max(i => i.EndDateTime ?? i.StartDateTime);
            return (start, end);
        }

        /// <summary>
        /// Merge por StartDateTime (exato) ou mesmo dia. Sequencial de propósito:
        /// cada incoming depende do estado atual da lista (replace/add) — Parallel geraria race.
        /// Lookup O(1) via dicionários em vez de FindIndex O(n) por item.
        /// </summary>
        private static ScheduleCalendarItem[] MergeByStartDateTime(
            ScheduleCalendarItem[]? existing,
            ScheduleCalendarItem[] incoming)
        {
            var source = existing ?? [];
            var result = new List<ScheduleCalendarItem>(source.Length + incoming.Length);
            var byExact = new Dictionary<DateTime, int>(source.Length + incoming.Length);
            var byDay = new Dictionary<DateTime, int>(source.Length + incoming.Length);

            for (var i = 0; i < source.Length; i++)
            {
                var e = source[i];
                result.Add(e);
                byExact[e.StartDateTime] = i;
                // First-wins (equivalente a FindIndex).
                byDay.TryAdd(e.StartDateTime.Date, i);
            }

            foreach (var item in incoming)
            {
                if (byExact.TryGetValue(item.StartDateTime, out var exact))
                {
                    result[exact] = item;
                    byDay[item.StartDateTime.Date] = exact;
                    continue;
                }

                if (byDay.TryGetValue(item.StartDateTime.Date, out var sameDay))
                {
                    byExact.Remove(result[sameDay].StartDateTime);
                    result[sameDay] = item;
                    byExact[item.StartDateTime] = sameDay;
                    byDay[item.StartDateTime.Date] = sameDay;
                    continue;
                }

                var idx = result.Count;
                result.Add(item);
                byExact[item.StartDateTime] = idx;
                byDay[item.StartDateTime.Date] = idx;
            }

            return result.OrderBy(i => i.StartDateTime).ToArray();
        }
    }
}
