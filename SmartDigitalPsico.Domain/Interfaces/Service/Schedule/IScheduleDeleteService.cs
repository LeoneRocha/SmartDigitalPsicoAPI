using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleDeleteService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleDeleteService
    {
        /// <summary>
        /// Método DeleteByTokenAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> DeleteByTokenAsync(string uniqueToken);
        /// <summary>
        /// Método DeleteByTokenFilteredAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> DeleteByTokenFilteredAsync(ScheduleDeleteTokenRequest request);
        /// <summary>
        /// Método DeleteByIdAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> DeleteByIdAsync(long id);
    }
}
