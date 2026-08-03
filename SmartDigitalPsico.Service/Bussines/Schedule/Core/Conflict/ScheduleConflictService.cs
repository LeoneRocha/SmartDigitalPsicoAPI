using System.Collections.Concurrent;
using Serilog;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Conflict
{
    /// <summary>
    /// Classe responsável por ScheduleConflictService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleConflictService : IScheduleConflictService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly ILogger _logger;

        /// <summary>
        /// Método ScheduleConflictService: operação de agendamento.
        /// </summary>
        public ScheduleConflictService(IScheduleCalendarRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Checagem single-item (FluentValidation). Uma query por chamada — não paralelizar DB.
        /// </summary>
        public async Task<ServiceResponse<bool>> HasNoConflictAsync(ScheduleCalendarConflictRequest request)
        {
            try
            {
                var ok = await ScheduleCalendarConflictValidator.HasNoConflictAsync(request, _repository);
                return new ServiceResponse<bool>
                {
                    Success = true,
                    Data = ok,
                    Message = ok ? string.Empty : "There is a scheduling conflict for the specified time."
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleConflictService.HasNoConflictAsync failed");
                return new ServiceResponse<bool> { Success = false, Data = false, Message = ex.Message };
            }
        }

        /// <summary>
        /// Batch de conflito: DB uma vez, depois checks CPU.
        /// Onde Parallel: Parallel.For item vs existentes; ConcurrentBag coleta ErrorResponse detalhados.
        /// Ganho: N itens / 1 query; errors[] com PatientId, datas e horários conflitantes.
        /// </summary>
        public async Task<ServiceResponse<bool>> HasNoConflictBatchAsync(
            string tenantKey,
            string ownerKey,
            ScheduleCalendarItem[] items,
            string? excludeToken)
        {
            try
            {
                if (items == null || items.Length == 0)
                    return new ServiceResponse<bool> { Success = true, Data = true };

                var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
                var windowStart = items.Min(i => i.StartDateTime);
                var windowEnd = items.Max(i => i.EndDateTime ?? i.StartDateTime);

                // DB antes do paralelismo
                var packages = await _repository.GetOverlappingByOwnerAsync(tenant, ownerKey, windowStart, windowEnd);
                var existing = packages
                    .SelectMany(p => (p.ScheduleData ?? [])
                        .Where(i => i.Status is not (EStatusCalendar.Canceled or EStatusCalendar.Refused))
                        .Select(i =>
                        {
                            var token = string.IsNullOrWhiteSpace(i.TokenRecurrence) ? p.UniqueToken : i.TokenRecurrence;
                            return (Item: i, Token: token, SubjectKey: p.SubjectKey);
                        }))
                    .Where(x => string.IsNullOrWhiteSpace(excludeToken)
                        || !string.Equals(x.Token, excludeToken, StringComparison.Ordinal))
                    .ToArray();

                var conflictErrors = new List<ErrorResponse>();

                // Self-overlap da série (sequencial — índices cruzados + early fill de errors).
                for (var i = 0; i < items.Length && conflictErrors.Count < ScheduleConflictDetailHelper.MaxErrors; i++)
                {
                    for (var j = i + 1; j < items.Length && conflictErrors.Count < ScheduleConflictDetailHelper.MaxErrors; j++)
                    {
                        if (!ScheduleOverlapHelper.Overlaps(
                                items[i].StartDateTime, items[i].EndDateTime,
                                items[j].StartDateTime, items[j].EndDateTime))
                            continue;

                        conflictErrors.Add(ScheduleConflictDetailHelper.Create(
                            items[i], items[i].SubjectKey,
                            items[j], items[j].SubjectKey));
                    }
                }

                if (conflictErrors.Count > 0)
                    return ConflictResponse(conflictErrors);

                // CPU paralelo: cada item vs existentes; ConcurrentBag para detalhes.
                var bag = new ConcurrentBag<ErrorResponse>();
                Parallel.For(0, items.Length, ScheduleParallel.MaxAvailableThreads, i =>
                {
                    if (bag.Count >= ScheduleConflictDetailHelper.MaxErrors)
                        return;

                    var item = items[i];
                    var end = item.EndDateTime ?? item.StartDateTime;
                    foreach (var other in existing)
                    {
                        if (bag.Count >= ScheduleConflictDetailHelper.MaxErrors)
                            return;

                        if (!ScheduleOverlapHelper.Overlaps(
                                item.StartDateTime, end,
                                other.Item.StartDateTime, other.Item.EndDateTime))
                            continue;

                        bag.Add(ScheduleConflictDetailHelper.Create(
                            item, item.SubjectKey,
                            other.Item, other.SubjectKey));
                        break; // um detalhe por ocorrência do request
                    }
                });

                if (!bag.IsEmpty)
                {
                    conflictErrors = bag
                        .OrderBy(e => e.Message)
                        .Take(ScheduleConflictDetailHelper.MaxErrors)
                        .ToList();
                    return ConflictResponse(conflictErrors);
                }

                return new ServiceResponse<bool> { Success = true, Data = true };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleConflictService.HasNoConflictBatchAsync failed");
                return new ServiceResponse<bool> { Success = false, Data = false, Message = ex.Message };
            }
        }

        private static ServiceResponse<bool> ConflictResponse(List<ErrorResponse> errors)
            => new()
            {
                Success = true,
                Data = false,
                Message = "There is a scheduling conflict for the specified time.",
                Errors = errors
            };
    }
}
