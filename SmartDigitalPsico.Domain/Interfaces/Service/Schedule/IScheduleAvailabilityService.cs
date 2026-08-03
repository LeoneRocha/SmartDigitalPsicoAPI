using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleAvailabilityService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleAvailabilityService
    {
        /// <summary>
        /// Método BuildGradeAsync: mapeia, transforma ou agenda dados.
        /// </summary>
        Task<ServiceResponse<ScheduleGradeResult>> BuildGradeAsync(ScheduleGradeRequest request);
    }
}
