using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Data.Repository
{
    public class ScheduleBatchRepository : GenericRepositoryEntityBase<ScheduleBatch>, IScheduleBatchRepository
    {
        public ScheduleBatchRepository(IEntityDataContext context) : base(context) { }

        public async Task<ScheduleBatch?> GetByMedicalAndPatientAsync(long medicalId, long? patientId, DateTime startDate, DateTime endDate)
        {
            var query = _dataset
                .Where(x => x.MedicalId == medicalId &&
                           x.StartPeriod <= endDate &&
                           x.EndPeriod >= startDate);

            if (patientId.HasValue)
            {
                query = query.Where(x => x.PatientId == patientId.Value);
            } 
            return await query.FirstOrDefaultAsync();
        }

        public async Task<ScheduleBatch[]> GetByMedicalAsync(long medicalId, DateTime startDate, DateTime endDate)
        {
            return await _dataset
                .Where(x => x.MedicalId == medicalId &&
                           x.StartPeriod <= endDate &&
                           x.EndPeriod >= startDate)
                .ToArrayAsync();
        }

        public async Task<ScheduleBatch?> GetByBatchTokenAsync(string batchToken)
        {
            return await _dataset
                .Where(x => x.BatchToken == batchToken)
                .FirstOrDefaultAsync();
        }

        public async Task<ScheduleItem[]> GetScheduleItemsAsync(long medicalId, long? patientId, DateTime startDate, DateTime endDate)
        {
            var query = _dataset.Where(x => x.MedicalId == medicalId &&
                                          x.StartPeriod <= endDate &&
                                          x.EndPeriod >= startDate);

            if (patientId.HasValue)
            {
                query = query.Where(x => x.PatientId == patientId.Value);
            }
            var batches = await query.ToArrayAsync();

            // Usando uma lista temporária para acumular os resultados
            var resultList = new List<ScheduleItem>();

            foreach (var batch in batches)
            {
                if (batch.ScheduleData.Length > 0)
                {
                    var filteredItems = batch.ScheduleData
                        .Where(i => i.StartDateTime <= endDate &&
                                   (i.EndDateTime ?? i.StartDateTime) >= startDate)
                        .ToArray();

                    resultList.AddRange(filteredItems);
                }
            } 
            // Convertendo para array no final
            return resultList.ToArray();
        }

        public async Task<ScheduleItem[]> GetScheduleItemsByTokenAsync(string batchToken)
        {
            var batch = await GetByBatchTokenAsync(batchToken);

            if (batch != null && batch.ScheduleData.Length > 0)
            {
                return batch.ScheduleData;
            } 
            return [];
        }
    }
} 