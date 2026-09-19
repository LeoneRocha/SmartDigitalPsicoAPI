using SmartDigitalPsico.Core.SDK.Domain.Extensions;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;
using SmartCoreHub.Core.SDK.Infrastructure.Logging;
using IAppLogger = SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe respons?vel por ScheduleDeleteService.
    /// Responsabilidade: m?dulo de agendamento (Schedule).
    /// Rela??o: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleDeleteService : IScheduleDeleteService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IAppLogger _logger;

        /// <summary>
        /// M?todo ScheduleDeleteService: opera??o de agendamento.
        /// </summary>
        public ScheduleDeleteService(IScheduleCalendarRepository repository, IAppLogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Exclus?o por token ? apenas I/O de reposit?rio.
        /// Sem Parallel: n?o h? transforma??o CPU em lote; DB permanece sequencial.
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteByTokenAsync(string uniqueToken)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var entity = await _repository.GetByUniqueTokenAsync(uniqueToken);
                if (entity == null)
                {
                    response.Data = false;
                    return response.FailWith("Agenda schedule not found.", "DeleteByTokenAsync");
                }

                await _repository.Delete(entity.Id);
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByTokenAsync failed");
                return response.FailWith(ex.Message, "DeleteByTokenAsync");
            }
        }

        /// <summary>
        /// M?todo DeleteByTokenFilteredAsync: remove ou cancela um registro/recurso.
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
                    response.Data = false;
                    return response.FailWith("Agenda schedule not found.", "DeleteByTokenFilteredAsync");
                }

                await _repository.DeleteRangeAsync(packages);
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByTokenFilteredAsync failed");
                return response.FailWith(ex.Message, "DeleteByTokenFilteredAsync");
            }
        }

        /// <summary>
        /// M?todo DeleteByIdAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteByIdAsync(long id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (!await _repository.Exists(id))
                {
                    response.Data = false;
                    return response.FailWith("Agenda schedule not found.", "DeleteByIdAsync");
                }

                await _repository.Delete(id);
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleDeleteService.DeleteByIdAsync failed");
                return response.FailWith(ex.Message, "DeleteByIdAsync");
            }
        }
    }
}
