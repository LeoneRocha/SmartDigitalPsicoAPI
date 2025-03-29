using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs;
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
        /// Gets a batch by its token
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <returns>The batch data</returns>
        Task<ServiceResponse<GetScheduleBatchDto>> GetBatchByTokenAsync(string batchToken);

        /// <summary>
        /// Generates a recurrence pattern of schedule items
        /// </summary>
        /// <param name="request">Recurrence generation parameters</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> GenerateRecurrenceAsync(ScheduleBatchRecurrenceDto request);

        /// <summary>
        /// Adds a new item to an existing batch
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <param name="item">The item to add</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> AddItemToBatchAsync(string batchToken, AddScheduleItemDto item);

        /// <summary>
        /// Removes an item from a batch
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <param name="itemId">The ID of the item to remove</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> RemoveItemFromBatchAsync(string batchToken, long itemId);

        /// <summary>
        /// Updates an item in a batch
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <param name="item">The updated item</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> UpdateItemInBatchAsync(string batchToken, UpdateScheduleItemDto item);


        // Adicione estes métodos à interface existente

        /// <summary>
        /// Adds a holiday exception to the batch, removing any items on that date
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <param name="holidayDate">The holiday date</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> AddHolidayExceptionAsync(string batchToken, DateTime holidayDate);

        /// <summary>
        /// Adjusts the recurrence pattern from a specific date
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <param name="fromDate">The date from which to adjust</param>
        /// <param name="newPattern">The new recurrence pattern</param>
        /// <returns>Success or failure response</returns>
        Task<ServiceResponse<bool>> AdjustRecurrenceAsync(string batchToken, DateTime fromDate, ScheduleBatchRecurrenceDto newPattern);

        /// <summary>
        /// Gets statistics about the batch
        /// </summary>
        /// <param name="batchToken">The batch token</param>
        /// <returns>Batch statistics</returns>
        Task<ServiceResponse<ScheduleBatchStatisticsDto>> GetBatchStatisticsAsync(string batchToken);

    }
}
