using FluentValidation;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Extensions;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class ScheduleBatchService : IScheduleBatchService
    {
        private readonly IScheduleBatchRepository _repository;
        private readonly ISharedServices _sharedServices;
        private readonly ILogger _logger;

        public ScheduleBatchService(
            IScheduleBatchRepository repository,
            ISharedServices sharedServices)
        {
            _repository = repository;
            _sharedServices = sharedServices;
            _logger = _sharedServices.Logger;
        }

        public async Task<ServiceResponse<bool>> CreateOrUpdateBatchAsync(long medicalId, long? patientId, ScheduleItem[] items, string batchToken = "")
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Determinar o período de início e fim
                var startPeriod = items.Min(i => i.StartDateTime);
                var endPeriod = items.Max(i => i.EndDateTime ?? i.StartDateTime);
                
                // Verificar se já existe um batch para este período
                var existingBatch = await _repository.GetByMedicalAndPatientAsync(medicalId, patientId, startPeriod, endPeriod);
                
                if (existingBatch != null)
                {
                    // Atualizar o batch existente
                    existingBatch.ScheduleData = items;
                    existingBatch.EndPeriod = endPeriod > existingBatch.EndPeriod ? endPeriod : existingBatch.EndPeriod;
                    existingBatch.StartPeriod = startPeriod < existingBatch.StartPeriod ? startPeriod : existingBatch.StartPeriod;
                    existingBatch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    
                    await _repository.Update(existingBatch);
                    
                    response.Success = true;
                    response.Data = true;
                    response.Message = "Batch updated successfully";
                }
                else
                {
                    // Criar um novo batch
                    var newBatch = new ScheduleBatch
                    {
                        MedicalId = medicalId,
                        PatientId = patientId,
                        StartPeriod = startPeriod,
                        EndPeriod = endPeriod,
                        BatchToken = !string.IsNullOrEmpty(batchToken) ? batchToken : Guid.NewGuid().ToString(),
                        CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                        ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                        LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                        Enable = true,
                        ScheduleData = items
                    };
                    
                    await _repository.Create(newBatch);
                    
                    response.Success = true;
                    response.Data = true;
                    response.Message = "Batch created successfully";
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.CreateOrUpdateBatchAsync");
                response.Success = false;
                response.Message = "An error occurred while processing the batch";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<ScheduleItem[]>> GetScheduleItemsAsync(long medicalId, long? patientId, DateTime startDate, DateTime endDate)
        {
            var response = new ServiceResponse<ScheduleItem[]>();
            try
            {
                var items = await _repository.GetScheduleItemsAsync(medicalId, patientId, startDate, endDate);
                
                response.Success = true;
                response.Data = items;
                response.Message = items.Length > 0 ? "Schedule items found" : "No schedule items found";
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GetScheduleItemsAsync");
                response.Success = false;
                response.Message = "An error occurred while retrieving schedule items";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<bool>> DeleteBatchAsync(string batchToken)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var batch = await _repository.GetByBatchTokenAsync(batchToken);
                if (batch != null)
                {
                    await _repository.Delete(batch.Id);
                    
                    response.Success = true;
                    response.Data = true;
                    response.Message = "Batch deleted successfully";
                }
                else
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Batch not found";
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.DeleteBatchAsync");
                response.Success = false;
                response.Message = "An error occurred while deleting the batch";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<bool>> AddItemToBatchAsync(string batchToken, ScheduleItem item)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var batch = await _repository.GetByBatchTokenAsync(batchToken);
                if (batch != null)
                {
                    batch.AddScheduleItem(item);
                    
                    // Atualizar período se necessário
                    if (item.StartDateTime < batch.StartPeriod)
                        batch.StartPeriod = item.StartDateTime;
                        
                    if ((item.EndDateTime ?? item.StartDateTime) > batch.EndPeriod)
                        batch.EndPeriod = item.EndDateTime ?? item.StartDateTime;
                        
                    batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    
                    await _repository.Update(batch);
                    
                    response.Success = true;
                    response.Data = true;
                    response.Message = "Item added to batch successfully";
                }
                else
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Batch not found";
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.AddItemToBatchAsync");
                response.Success = false;
                response.Message = "An error occurred while adding item to batch";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<bool>> RemoveItemFromBatchAsync(string batchToken, ScheduleItem item)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var batch = await _repository.GetByBatchTokenAsync(batchToken);
                if (batch != null)
                {
                    batch.RemoveScheduleItem(item);
                    batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    
                    await _repository.Update(batch);
                    
                    response.Success = true;
                    response.Data = true;
                    response.Message = "Item removed from batch successfully";
                }
                else
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Batch not found";
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.RemoveItemFromBatchAsync");
                response.Success = false;
                response.Message = "An error occurred while removing item from batch";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<ScheduleItem[]>> GetItemsByTokenAsync(string batchToken)
        {
            var response = new ServiceResponse<ScheduleItem[]>();
            try
            {
                var items = await _repository.GetScheduleItemsByTokenAsync(batchToken);
                
                response.Success = true;
                response.Data = items;
                response.Message = items.Length > 0 ? "Schedule items found" : "No schedule items found";
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GetItemsByTokenAsync");
                response.Success = false;
                response.Message = "An error occurred while retrieving schedule items";
            }
            
            return response;
        }
        
        public async Task<ServiceResponse<bool>> GenerateRecurrenceAsync(long medicalId, long? patientId, ScheduleItem template, ERecurrenceCalendarType recurrenceType, DateTime? recurrenceEndDate, short? recurrenceCount, DayOfWeek[] recurrenceDays)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var batchToken = Guid.NewGuid().ToString();
                var items = new List<ScheduleItem>();
                
                // Configurar o template com informações de recorrência
                template.TokenRecurrence = batchToken;
                template.RecurrenceType = recurrenceType;
                template.RecurrenceEndDate = recurrenceEndDate;
                template.RecurrenceCount = recurrenceCount;
                template.RecurrenceDays = recurrenceDays;
                
                // Gerar os itens recorrentes com base no tipo de recorrência
                switch (recurrenceType)
                {
                    case ERecurrenceCalendarType.Daily:
                        GenerateDailyRecurrence(template, items, recurrenceEndDate, recurrenceCount);
                        break;
                    case ERecurrenceCalendarType.Weekly:
                        GenerateWeeklyRecurrence(template, items, recurrenceEndDate, recurrenceCount, recurrenceDays);
                        break;
                    case ERecurrenceCalendarType.Monthly:
                        GenerateMonthlyRecurrence(template, items, recurrenceEndDate, recurrenceCount);
                        break;
                    case ERecurrenceCalendarType.Yearly:
                        GenerateYearlyRecurrence(template, items, recurrenceEndDate, recurrenceCount);
                        break;
                    default:
                        // Para ERecurrenceCalendarType.None, apenas adicionar o item original
                        items.Add(template);
                        break;
                }
                
                // Criar o batch com os itens gerados
                var createResult = await CreateOrUpdateBatchAsync(medicalId, patientId, items.ToArray(), batchToken);
                
                response.Success = createResult.Success;
                response.Data = createResult.Data;
                response.Message = createResult.Message;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GenerateRecurrenceAsync");
                response.Success = false;
                response.Message = "An error occurred while generating recurrence";
            }
            
            return response;
        }
        
        #region Private Methods for Recurrence Generation
        
        private void GenerateDailyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? maxCount)
        {
            DateTime currentDate = template.StartDateTime;
            int count = 0;
            
            while (ShouldContinueRecurrence(currentDate, endDate, count, maxCount))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = template.EndDateTime.HasValue 
                    ? currentDate.Add(template.EndDateTime.Value - template.StartDateTime) 
                    : null;
                
                items.Add(newItem);
                
                currentDate = currentDate.AddDays(1);
                count++;
            }
        }
        
        private void GenerateWeeklyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? maxCount, DayOfWeek[] days)
        {
            if (days == null || days.Length == 0)
            {
                // Se não houver dias especificados, usar o dia da semana da data inicial
                days = new[] { template.StartDateTime.DayOfWeek };
            }
            
            DateTime currentDate = template.StartDateTime;
            int count = 0;
            
            while (ShouldContinueRecurrence(currentDate, endDate, count, maxCount))
            {
                foreach (var day in days)
                {
                    // Encontrar o próximo dia da semana especificado
                    DateTime nextDay = GetNextWeekday(currentDate, day);
                    
                    if (!ShouldContinueRecurrence(nextDay, endDate, count, maxCount))
                        break;
                    
                    var newItem = CloneScheduleItem(template);
                    newItem.StartDateTime = nextDay;
                    newItem.EndDateTime = template.EndDateTime.HasValue 
                        ? nextDay.Add(template.EndDateTime.Value - template.StartDateTime) 
                        : null;
                    
                    items.Add(newItem);
                    count++;
                }
                
                // Avançar para a próxima semana
                currentDate = currentDate.AddDays(7);
            }
        }
        
        private void GenerateMonthlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? maxCount)
        {
            DateTime currentDate = template.StartDateTime;
            int count = 0;
            
            while (ShouldContinueRecurrence(currentDate, endDate, count, maxCount))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = template.EndDateTime.HasValue 
                    ? currentDate.Add(template.EndDateTime.Value - template.StartDateTime) 
                    : null;
                
                items.Add(newItem);
                
                // Avançar para o próximo mês, mantendo o mesmo dia
                currentDate = currentDate.AddMonths(1);
                count++;
            }
        }
        
        private void GenerateYearlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? maxCount)
        {
            DateTime currentDate = template.StartDateTime;
            int count = 0;
            
            while (ShouldContinueRecurrence(currentDate, endDate, count, maxCount))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = template.EndDateTime.HasValue 
                    ? currentDate.Add(template.EndDateTime.Value - template.StartDateTime)
