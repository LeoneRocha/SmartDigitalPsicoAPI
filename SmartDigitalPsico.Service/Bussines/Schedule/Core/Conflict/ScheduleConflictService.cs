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
        /// Batch de conflito: DB uma vez (GetOverlappingByOwnerAsync), depois checks CPU.
        /// Onde Parallel: Parallel.ForEach item do request vs existentes em memória (MaxAvailableThreads).
        /// Ganho esperado: Create/Update com recorrência (N itens) deixa de fazer N queries; overlap CPU em paralelo.
        /// Por que self-overlap i×j sequencial: N típico moderado + early return; Parallel complicaria sem ganho claro.
        /// Por que não Parallel no repositório: DbContext não é thread-safe.
        /// Sem ConcurrentBag: Interlocked.Exchange + ParallelLoopState.Stop basta para flag de conflito.
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
                    .SelectMany(p => (p.ScheduleData ?? []).Select(i =>
                    {
                        var token = string.IsNullOrWhiteSpace(i.TokenRecurrence) ? p.UniqueToken : i.TokenRecurrence;
                        return (Item: i, Token: token);
                    }))
                    .Where(x => x.Item.Status is not (EStatusCalendar.Canceled or EStatusCalendar.Refused))
                    .Where(x => string.IsNullOrWhiteSpace(excludeToken)
                        || !string.Equals(x.Token, excludeToken, StringComparison.Ordinal))
                    .Select(x => x.Item)
                    .ToArray();

                // CPU: overlap entre itens do próprio request (sequencial — N pequeno e índices cruzados)
                for (var i = 0; i < items.Length; i++)
                {
                    for (var j = i + 1; j < items.Length; j++)
                    {
                        if (ScheduleOverlapHelper.Overlaps(
                                items[i].StartDateTime, items[i].EndDateTime,
                                items[j].StartDateTime, items[j].EndDateTime))
                        {
                            return new ServiceResponse<bool>
                            {
                                Success = true,
                                Data = false,
                                Message = "There is a scheduling conflict for the specified time."
                            };
                        }
                    }
                }

                // CPU paralelo: Parallel.For item vs existentes (flag via Interlocked — sem ConcurrentDictionary).
                var conflictFound = 0;
                Parallel.For(0, items.Length, ScheduleParallel.MaxAvailableThreads, (i, state) =>
                {
                    if (Volatile.Read(ref conflictFound) != 0)
                    {
                        state.Stop();
                        return;
                    }

                    var item = items[i];
                    var end = item.EndDateTime ?? item.StartDateTime;
                    foreach (var other in existing)
                    {
                        if (ScheduleOverlapHelper.Overlaps(
                                item.StartDateTime, end,
                                other.StartDateTime, other.EndDateTime))
                        {
                            Interlocked.Exchange(ref conflictFound, 1);
                            state.Stop();
                            return;
                        }
                    }
                });

                var ok = conflictFound == 0;
                return new ServiceResponse<bool>
                {
                    Success = true,
                    Data = ok,
                    Message = ok ? string.Empty : "There is a scheduling conflict for the specified time."
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleConflictService.HasNoConflictBatchAsync failed");
                return new ServiceResponse<bool> { Success = false, Data = false, Message = ex.Message };
            }
        }
    }
}
