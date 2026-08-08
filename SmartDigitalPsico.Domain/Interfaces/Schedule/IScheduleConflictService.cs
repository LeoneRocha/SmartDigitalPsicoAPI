using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleConflictService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleConflictService
    {
        /// <summary>
        /// Método HasNoConflictAsync: executa a operação HasNoConflictAsync.
        /// </summary>
        Task<ServiceResponse<bool>> HasNoConflictAsync(ScheduleCalendarConflictRequest request);

        /// <summary>
        /// Verifica conflito de múltiplos itens: 1 leitura de DB na janela, depois checks CPU em paralelo.
        /// </summary>
        Task<ServiceResponse<bool>> HasNoConflictBatchAsync(
            string tenantKey,
            string ownerKey,
            ScheduleCalendarItem[] items,
            string? excludeToken);
    }
}
