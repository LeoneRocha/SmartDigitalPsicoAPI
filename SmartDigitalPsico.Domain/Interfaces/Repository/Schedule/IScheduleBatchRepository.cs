using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Repository.Schedule
{
    public interface IScheduleBatchRepository : IEntityBaseRepository<ScheduleBatch>
    {
        Task DeleteRangeAsync(IEnumerable<ScheduleBatch> batches);
        Task<ScheduleBatch?> GetByMedicalAndPatientAsync(long medicalId, long? patientId, DateTime startDate, DateTime endDate);
        Task<ScheduleBatch[]> GetByMedicalAsync(long medicalId, DateTime startDate, DateTime endDate);
        Task<ScheduleBatch?> GetByBatchTokenAsync(string batchToken);
        Task<ScheduleItem[]> GetScheduleItemsAsync(long medicalId, long? patientId, DateTime startDate, DateTime endDate);
        Task<ScheduleItem[]> GetScheduleItemsByTokenAsync(string batchToken);
    }
} 