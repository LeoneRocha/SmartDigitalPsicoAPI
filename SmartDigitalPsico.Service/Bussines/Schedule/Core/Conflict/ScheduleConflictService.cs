using Serilog;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
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
        /// Método HasNoConflictAsync: executa a operação HasNoConflictAsync.
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
    }
}
