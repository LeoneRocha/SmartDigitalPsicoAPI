using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands
{
    /// <summary>
    /// Classe responsável por ScheduleDeleteService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleDeleteService : IScheduleDeleteService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly ILogger _logger;

        /// <summary>
        /// Método ScheduleDeleteService: operação de agendamento.
        /// </summary>
        public ScheduleDeleteService(IScheduleCalendarRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Exclusão por token — apenas I/O de repositório. Sem paralelismo CPU (não há transformação em lote).
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteByTokenAsync(string uniqueToken)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var entity = await _repository.GetByUniqueTokenAsync(uniqueToken);
                if (entity == null)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.Delete(entity.Id);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByTokenAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// Método DeleteByTokenFilteredAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteByTokenFilteredAsync(ScheduleDeleteTokenRequest request)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var packages = await _repository.GetByTokenAsync(request.UniqueToken, request.OwnerKey, request.SubjectKey);
                if (packages.Length == 0)
                {
                    var byToken = await _repository.GetByUniqueTokenAsync(request.UniqueToken);
                    if (byToken != null)
                        packages = [byToken];
                }

                if (packages.Length == 0)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.DeleteRangeAsync(packages);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByTokenFilteredAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// Método DeleteByIdAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteByIdAsync(long id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (!await _repository.Exists(id))
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.Delete(id);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByIdAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
