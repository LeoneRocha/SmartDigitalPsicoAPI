using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IScheduleBatchService : IEntityBaseService<ScheduleBatch, AddScheduleBatchDto, UpdateScheduleBatchDto, GetScheduleBatchDto>
    {
        /// <summary>
        /// Deletes a schedule batch by ID or batch token
        /// </summary>
        /// <param name="request">Delete request containing ID or batch token</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> DeleteBatchAsync(DeleteScheduleBatchDto request); 

        /// <summary>
        /// Gets schedule items based on criteria
        /// </summary>
        /// <param name="criteria">Search criteria</param>
        /// <returns>Array of schedule items</returns>
        Task<ServiceResponse<GetScheduleItemDto[]>> GetScheduleItemsAsync(ScheduleBatchCriteriaDto criteria);
  
        /// <summary>
        /// Gets statistics about the batch
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <returns>Batch statistics</returns>
        Task<ServiceResponse<ScheduleBatchStatisticsDto>> GetBatchStatisticsAsync(string batchToken);

        Task<ServiceResponse<GetScheduleBatchDto>> CreateOrUpdateBatchAsync(ScheduleMedicalCalendarCriteriaDto request);

    }
}
