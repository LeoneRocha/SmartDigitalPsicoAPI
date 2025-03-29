using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Validation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class ScheduleBatchService : EntityBaseService<ScheduleBatch, AddScheduleBatchDto, UpdateScheduleBatchDto, GetScheduleBatchDto, IScheduleBatchRepository>, IScheduleBatchService
    {
        private readonly IPatientRepositories _patientRepositoriesShared;
        private readonly IMedicalRepository _medicalRepository;
        private readonly IUserRepository _userRepository;
        private readonly IScheduleBatchValidators _validators;

        public ScheduleBatchService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IScheduleBatchValidators scheduleBatchValidators,
            IScheduleBatchRepository entityRepository,
            IPatientRepositories repositoriesPatientShared)
            : base(sharedServices, sharedDependenciesConfig, repositoriesPatientShared.SharedRepositories, entityRepository, scheduleBatchValidators.EntityValidator)
        {
            _medicalRepository = repositoriesPatientShared.MedicalRepository;
            _patientRepositoriesShared = repositoriesPatientShared;
            _userRepository = repositoriesPatientShared.SharedRepositories.UserRepository;
            _validators = scheduleBatchValidators;
        }

        public override async Task<ServiceResponse<GetScheduleBatchDto>> Create(AddScheduleBatchDto item)
        {
            ServiceResponse<GetScheduleBatchDto> response = new ServiceResponse<GetScheduleBatchDto>();
            try
            {
                var entityAdd = _mapper.Map<ScheduleBatch>(item);
                entityAdd.Enable = true;

                #region Relationship
                entityAdd.CreatedUserId = UserId;
                entityAdd.PatientId = item.PatientId;
                entityAdd.MedicalId = item.MedicalId;
                #endregion Relationship

                entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                // Gerar BatchToken se não fornecido
                if (string.IsNullOrEmpty(entityAdd.BatchToken))
                {
                    entityAdd.BatchToken = Guid.NewGuid().ToString();
                }

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    ScheduleBatch entityResponse = await _entityRepository.Create(entityAdd);
                    response.Data = _mapper.Map<GetScheduleBatchDto>(entityResponse);
                    response.Message = await base.GetLocalization("ScheduleBatch_Created_Key", "Schedule batch created successfully.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.Create");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetScheduleBatchDto>> Update(UpdateScheduleBatchDto item)
        {
            ServiceResponse<GetScheduleBatchDto> response = new ServiceResponse<GetScheduleBatchDto>();
            try
            {
                var entityUpdate = _mapper.Map<ScheduleBatch>(item);
                entityUpdate.Enable = item.Enable;

                #region Relationship
                entityUpdate.ModifyUserId = UserId;
                entityUpdate.PatientId = item.PatientId;
                entityUpdate.MedicalId = item.MedicalId;
                #endregion Relationship

                // Obter dados existentes para preservar informações
                var existingEntity = await _entityRepository.FindByID(item.Id);
                if (existingEntity != null)
                {
                    entityUpdate.CreatedUserId = existingEntity.CreatedUserId;
                    entityUpdate.CreatedDate = existingEntity.CreatedDate;

                    // Manter o BatchToken original
                    if (string.IsNullOrEmpty(entityUpdate.BatchToken))
                    {
                        entityUpdate.BatchToken = existingEntity.BatchToken;
                    }
                }

                entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    ScheduleBatch entityResponse = await _entityRepository.Update(entityUpdate);
                    response.Data = _mapper.Map<GetScheduleBatchDto>(entityResponse);
                    response.Message = await base.GetLocalization(
                        "ScheduleBatch_Updated_Key",
                        "Schedule batch updated successfully.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.Update");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> DeleteBatchAsync(DeleteScheduleBatchDto request)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                ScheduleBatch? batch = null;

                // Buscar por ID ou BatchToken
                if (request.Id > 0)
                {
                    batch = await _entityRepository.FindByID(request.Id);
                }
                else if (!string.IsNullOrEmpty(request.BatchToken))
                {
                    batch = await _entityRepository.GetByBatchTokenAsync(request.BatchToken);
                }

                if (batch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Verificar permissões
                var recordsList = new RecordsList<ScheduleBatch>
                {
                    UserIdLogged = UserId,
                    Records = new List<ScheduleBatch>() { batch }
                };

                var validationResult = await _validators.EntityValidator.ValidateAsync(batch);

                if (validationResult.IsValid)
                {
                    await _entityRepository.Delete(batch.Id);

                    response.Success = true;
                    response.Data = true;
                    response.Message = await base.GetLocalization(
                        "ScheduleBatch_Deleted_Key",
                        "Schedule batch deleted successfully.");
                }
                else
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission,
                        ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.DeleteBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<GetScheduleItemDto[]>> GetScheduleItemsAsync(ScheduleBatchCriteriaDto criteria)
        {
            var response = new ServiceResponse<GetScheduleItemDto[]>();
            try
            {
                // Validar critérios
                if (criteria.MedicalId <= 0)
                {
                    response.Success = false;
                    response.Message = "Invalid medical ID";
                    return response;
                }

                // Buscar itens
                var items = await _entityRepository.GetScheduleItemsAsync(
                    criteria.MedicalId,
                    criteria.PatientId,
                    criteria.StartDate,
                    criteria.EndDate);

                // Mapear para DTOs
                var itemDtos = _mapper.Map<GetScheduleItemDto[]>(items);

                // Adicionar informação se o evento já passou
                var currentTime = DateHelper.GetDateTimeNowFromUtc();
                foreach (var item in itemDtos)
                {
                    item.IsPast = item.StartDateTime <= currentTime;
                }

                response.Success = true;
                response.Data = itemDtos;
                response.Message = itemDtos.Length > 0
                    ? await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound)
                    : await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GetScheduleItemsAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<GetScheduleBatchDto>> GetBatchByTokenAsync(string batchToken)
        {
            var response = new ServiceResponse<GetScheduleBatchDto>();
            try
            {
                var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);

                if (batch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Carregar relacionamentos
                batch = await _entityRepository.FindAsync(batch.Id, p => p.Medical!, p => p.Patient!);

                response.Success = true;
                response.Data = _mapper.Map<GetScheduleBatchDto>(batch);
                response.Message = await base.GetLocalization(
                    GeneralLanguageKeyConstants.RegisterIsFound,
                    GeneralLanguageMenssageConstants.RegisterIsFound);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GetBatchByTokenAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> GenerateRecurrenceAsync(ScheduleBatchRecurrenceDto request)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Validar solicitação
                if (request.MedicalId <= 0 || request.TemplateItem == null)
                {
                    response.Success = false;
                    response.Message = "Invalid request parameters";
                    return response;
                }

                // Gerar token de recorrência
                var batchToken = Guid.NewGuid().ToString();

                // Criar lista para armazenar itens gerados
                var items = new List<ScheduleItem>();

                // Mapear o template para um ScheduleItem
                var templateItem = _mapper.Map<ScheduleItem>(request.TemplateItem);
                templateItem.TokenRecurrence = batchToken;
                templateItem.RecurrenceType = request.RecurrenceType;
                templateItem.RecurrenceEndDate = request.RecurrenceEndDate;
                templateItem.RecurrenceCount = request.RecurrenceCount;
                templateItem.RecurrenceDays = request.RecurrenceDays;

                // Determinar datas de início e fim para o batch
                DateTime startPeriod = templateItem.StartDateTime;
                DateTime endPeriod = request.RecurrenceEndDate ?? templateItem.StartDateTime.AddYears(1);

                // Gerar itens recorrentes com base no tipo de recorrência
                switch (request.RecurrenceType)
                {
                    case ERecurrenceCalendarType.Daily:
                        GenerateDailyRecurrence(templateItem, items, request.RecurrenceEndDate, request.RecurrenceCount);
                        break;
                    case ERecurrenceCalendarType.Weekly:
                        GenerateWeeklyRecurrence(templateItem, items, request.RecurrenceEndDate, request.RecurrenceCount, request.RecurrenceDays);
                        break;
                    case ERecurrenceCalendarType.Monthly:
                        GenerateMonthlyRecurrence(templateItem, items, request.RecurrenceEndDate, request.RecurrenceCount);
                        break;
                    case ERecurrenceCalendarType.Yearly:
                        GenerateYearlyRecurrence(templateItem, items, request.RecurrenceEndDate, request.RecurrenceCount);
                        break;
                    default:
                        // Para ERecurrenceCalendarType.None, apenas adicionar o item original
                        items.Add(templateItem);
                        break;
                }

                if (items.Count == 0)
                {
                    response.Success = false;
                    response.Message = "No items were generated";
                    return response;
                }

                // Criar o batch com os itens gerados
                var batch = new ScheduleBatch
                {
                    MedicalId = request.MedicalId,
                    PatientId = request.PatientId,
                    BatchToken = batchToken,
                    StartPeriod = startPeriod,
                    EndPeriod = endPeriod,
                    CreatedUserId = UserId,
                    ModifyUserId = UserId,
                    CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                    ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                    LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                    Enable = true,
                    ScheduleData = items.ToArray()
                };

                // Validar o batch antes de salvar
                var validationResult = await _validators.EntityValidator.ValidateAsync(batch);
                if (!validationResult.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Message = validationResult.Errors.First().ErrorMessage;
                    return response;
                }

                // Salvar o batch
                await _entityRepository.Create(batch);

                response.Success = true;
                response.Data = true;
                response.Message = await base.GetLocalization(
                    "ScheduleBatch_Recurrence_Created_Key",
                    "Recurrence pattern created successfully.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.GenerateRecurrenceAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> AddItemToBatchAsync(string batchToken, AddScheduleItemDto item)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Buscar o batch existente
                var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
                if (batch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Converter o DTO para ScheduleItem
                var scheduleItem = _mapper.Map<ScheduleItem>(item);
                scheduleItem.TokenRecurrence = batchToken;

                // Validar o item
                var validator = _validators.ScheduleItemValidator;
                var validationResult = await validator.ValidateAsync(scheduleItem);
                if (!validationResult.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Message = validationResult.Errors.First().ErrorMessage;
                    return response;
                }
                

                // Adicionar o item ao batch
                var updatedItems = batch.ScheduleData.ToList();
                updatedItems.Add(scheduleItem);
                batch.ScheduleData = updatedItems.ToArray();

                // Atualizar o período do batch se necessário
                if (scheduleItem.StartDateTime < batch.StartPeriod)
                {
                    batch.StartPeriod = scheduleItem.StartDateTime;
                }
                if (scheduleItem.EndDateTime > batch.EndPeriod)
                {
                    batch.EndPeriod = scheduleItem.EndDateTime.GetValueOrDefault();
                }

                batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                batch.ModifyUserId = UserId;

                // Salvar as alterações
                await _entityRepository.Update(batch);

                response.Success = true;
                response.Data = true;
                response.Message = await base.GetLocalization(
                    "ScheduleItem_Added_Key",
                    "Schedule item added successfully.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.AddItemToBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> RemoveItemFromBatchAsync(string batchToken, long itemId)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Buscar o batch existente
                var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
                if (batch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Encontrar o item pelo ID
                var items = batch.ScheduleData.ToList();
                var itemToRemove = items.FirstOrDefault(i => i.TokenRecurrence == itemId.ToString());

                if (itemToRemove == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        "ScheduleItem_NotFound_Key",
                        "Schedule item not found in the batch.");
                    return response;
                }

                // Remover o item
                items.Remove(itemToRemove);
                batch.ScheduleData = items.ToArray();

                // Recalcular o período do batch se necessário
                if (items.Any())
                {
                    batch.StartPeriod = items.Min(i => i.StartDateTime);
                    batch.EndPeriod = items.Max(i => i.EndDateTime ?? i.StartDateTime);
                }

                batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                batch.ModifyUserId = UserId;

                // Salvar as alterações
                await _entityRepository.Update(batch);

                response.Success = true;
                response.Data = true;
                response.Message = await base.GetLocalization(
                    "ScheduleItem_Removed_Key",
                    "Schedule item removed successfully.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.RemoveItemFromBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> UpdateItemInBatchAsync(string batchToken, UpdateScheduleItemDto item)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Buscar o batch existente
                var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
                if (batch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Encontrar o item pelo ID
                var items = batch.ScheduleData.ToList();
                var itemIndex = items.FindIndex(i => i.TokenRecurrence == item.Id.ToString());

                if (itemIndex == -1)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        "ScheduleItem_NotFound_Key",
                        "Schedule item not found in the batch.");
                    return response;
                }

                // Converter o DTO para ScheduleItem
                var updatedItem = _mapper.Map<ScheduleItem>(item);
                updatedItem.TokenRecurrence = batchToken;

                // Validar o item
                var validator = _validators.ScheduleItemValidator;
                var validationResult = await validator.ValidateAsync(updatedItem);
                if (!validationResult.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Message = validationResult.Errors.First().ErrorMessage;
                    return response;
                }

                // Atualizar o item
                items[itemIndex] = updatedItem;
                batch.ScheduleData = items.ToArray();

                // Recalcular o período do batch
                batch.StartPeriod = items.Min(i => i.StartDateTime);
                batch.EndPeriod = items.Max(i => i.EndDateTime ?? i.StartDateTime);

                batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                batch.ModifyUserId = UserId;

                // Salvar as alterações
                await _entityRepository.Update(batch);

                response.Success = true;
                response.Data = true;
                response.Message = await base.GetLocalization(
                    "ScheduleItem_Updated_Key",
                    "Schedule item updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.UpdateItemInBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }
public async Task<ServiceResponse<bool>> AddHolidayExceptionAsync(string batchToken, DateTime holidayDate)
{
    var response = new ServiceResponse<bool>();
    try
    {
        var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
        if (batch == null)
        {
            response.Success = false;
            response.Message = await base.GetLocalization(
                GeneralLanguageKeyConstants.RegisterIsNotFound, 
                GeneralLanguageMenssageConstants.RegisterIsNotFound);
            return response;
        }
        
        // Remover itens que caem no feriado
        var items = batch.ScheduleData.ToList();
        var itemsToRemove = items.Where(i => i.StartDateTime.Date == holidayDate.Date).ToList();
        
        foreach (var item in itemsToRemove)
        {
            items.Remove(item);
        }
        
        batch.ScheduleData = items.ToArray();
        batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
        batch.ModifyUserId = UserId;
        
        await _entityRepository.Update(batch);
        
        response.Success = true;
        response.Data = true;
        response.Message = await base.GetLocalization(
            "Holiday_Exception_Added_Key", 
            "Holiday exception added successfully");
    }
    catch (Exception ex)
    {
        _logger.Error(ex, "Error at ScheduleBatchService.AddHolidayExceptionAsync");
        response.Success = false;
        response.Message = await base.GetLocalization(
            ValidatorConstants.GenericErroMessageKey, 
            ValidatorConstants.Generic_Erro_Message);
    }
    return response;
}

public async Task<ServiceResponse<bool>> AdjustRecurrenceAsync(string batchToken, DateTime fromDate, ScheduleBatchRecurrenceDto newPattern)
{
    var response = new ServiceResponse<bool>();
    try
    {
        var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
        if (batch == null)
        {
            response.Success = false;
            response.Message = await base.GetLocalization(
                GeneralLanguageKeyConstants.RegisterIsNotFound, 
                GeneralLanguageMenssageConstants.RegisterIsNotFound);
            return response;
        }
        
        // Remover itens a partir da data especificada
        var items = batch.ScheduleData.ToList();
        items.RemoveAll(i => i.StartDateTime >= fromDate);
        
        // Gerar novos itens com o novo padrão
        var newItems = new List<ScheduleItem>();
        var templateItem = _mapper.Map<ScheduleItem>(newPattern.TemplateItem);
        templateItem.TokenRecurrence = batch.BatchToken;
        templateItem.StartDateTime = fromDate;
        templateItem.RecurrenceType = newPattern.RecurrenceType;
        templateItem.RecurrenceEndDate = newPattern.RecurrenceEndDate;
        templateItem.RecurrenceCount = newPattern.RecurrenceCount;
        templateItem.RecurrenceDays = newPattern.RecurrenceDays;
        
        // Gerar novos itens com base no tipo de recorrência
        switch (newPattern.RecurrenceType)
        {
            case ERecurrenceCalendarType.Daily:
                GenerateDailyRecurrence(templateItem, newItems, newPattern.RecurrenceEndDate, newPattern.RecurrenceCount);
                break;
            case ERecurrenceCalendarType.Weekly:
                GenerateWeeklyRecurrence(templateItem, newItems, newPattern.RecurrenceEndDate, newPattern.RecurrenceCount, newPattern.RecurrenceDays);
                break;
            case ERecurrenceCalendarType.Monthly:
                GenerateMonthlyRecurrence(templateItem, newItems, newPattern.RecurrenceEndDate, newPattern.RecurrenceCount);
                break;
            case ERecurrenceCalendarType.Yearly:
                GenerateYearlyRecurrence(templateItem, newItems, newPattern.RecurrenceEndDate, newPattern.RecurrenceCount);
                break;
        }
        
        // Adicionar novos itens ao batch
        items.AddRange(newItems);
        batch.ScheduleData = items.ToArray();
        
        // Atualizar período do batch
        if (items.Any())
        {
            batch.StartPeriod = items.Min(i => i.StartDateTime);
            batch.EndPeriod = items.Max(i => i.EndDateTime ?? i.StartDateTime);
        }
        
        batch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
        batch.ModifyUserId = UserId;
        
        await _entityRepository.Update(batch);
        
        response.Success = true;
        response.Data = true;
        response.Message = await base.GetLocalization(
            "Recurrence_Adjusted_Key", 
            "Recurrence adjusted successfully");
    }
    catch (Exception ex)
    {
        _logger.Error(ex, "Error at ScheduleBatchService.AdjustRecurrenceAsync");
        response.Success = false;
        response.Message = await base.GetLocalization(
            ValidatorConstants.GenericErroMessageKey, 
            ValidatorConstants.Generic_Erro_Message);
    }
    return response;
}

public async Task<ServiceResponse<ScheduleBatchStatisticsDto>> GetBatchStatisticsAsync(string batchToken)
{
    var response = new ServiceResponse<ScheduleBatchStatisticsDto>();
    try
    {
        var batch = await _entityRepository.GetByBatchTokenAsync(batchToken);
        if (batch == null)
        {
            response.Success = false;
            response.Message = await base.GetLocalization(
                GeneralLanguageKeyConstants.RegisterIsNotFound, 
                GeneralLanguageMenssageConstants.RegisterIsNotFound);
            return response;
        }
        
        var items = batch.ScheduleData;
        var statistics = new ScheduleBatchStatisticsDto
        {
            TotalItems = items.Length,
            ItemsByDay = items.GroupBy(i => i.StartDateTime.DayOfWeek)
                .Select(g => new DayCountDto { Day = g.Key, Count = g.Count() })
                .ToArray(),
            ItemsByMonth = items.GroupBy(i => i.StartDateTime.Month)
                .Select(g => new MonthCountDto { Month = g.Key, Count = g.Count() })
                .ToArray(),
            AverageItemsPerDay = items.GroupBy(i => i.StartDateTime.Date)
                .Average(g => g.Count()),
            EarliestDate = items.Min(i => i.StartDateTime),
            LatestDate = items.Max(i => i.StartDateTime)
        };
        
        response.Success = true;
        response.Data = statistics;
        response.Message = await base.GetLocalization(
            "Statistics_Generated_Key", 
            "Statistics generated successfully");
    }
    catch (Exception ex)
    {
        _logger.Error(ex, "Error at ScheduleBatchService.GetBatchStatisticsAsync");
        response.Success = false;
        response.Message = await base.GetLocalization(
            ValidatorConstants.GenericErroMessageKey, 
            ValidatorConstants.Generic_Erro_Message);
    }
    return response;
}


        #region Private Methods for Recurrence Generation
        private void GenerateDailyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
        {
            DateTime currentDate = template.StartDateTime;
            int itemCount = 0;
            TimeSpan duration = template.EndDateTime.GetValueOrDefault() - template.StartDateTime;

            while ((endDate == null || currentDate <= endDate) && (count == null || itemCount < count))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = currentDate.Add(duration);
                items.Add(newItem);

                currentDate = currentDate.AddDays(1);
                itemCount++;
            }
        }

        private void GenerateWeeklyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count, DayOfWeek[] days)
        {
            if (days == null || days.Length == 0)
            {
                days = new[] { template.StartDateTime.DayOfWeek };
            }

            DateTime currentDate = template.StartDateTime;
            int itemCount = 0;
            TimeSpan duration = template.EndDateTime.GetValueOrDefault() - template.StartDateTime;

            // Ajustar para a primeira ocorrência
            while ((endDate == null || currentDate <= endDate) && (count == null || itemCount < count))
            {
                foreach (var day in days)
                {
                    // Encontrar o próximo dia da semana correspondente
                    DateTime nextDate = GetNextWeekday(currentDate, day);

                    if (endDate != null && nextDate > endDate)
                        continue;

                    if (count != null && itemCount >= count)
                        break;

                    var newItem = CloneScheduleItem(template);
                    newItem.StartDateTime = nextDate;
                    newItem.EndDateTime = nextDate.Add(duration);
                    items.Add(newItem);

                    itemCount++;
                }

                // Avançar para a próxima semana
                currentDate = currentDate.AddDays(7);
            }
        }

        private void GenerateMonthlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
        {
            DateTime currentDate = template.StartDateTime;
            int itemCount = 0;
            TimeSpan duration = template.EndDateTime.GetValueOrDefault() - template.StartDateTime;
            int dayOfMonth = currentDate.Day;

            while ((endDate == null || currentDate <= endDate) && (count == null || itemCount < count))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = currentDate.Add(duration);
                items.Add(newItem);

                // Avançar para o mesmo dia do próximo mês
                currentDate = currentDate.AddMonths(1);

                // Ajustar para o último dia do mês se necessário
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                if (dayOfMonth > daysInMonth)
                {
                    currentDate = new DateTime(currentDate.Year, currentDate.Month, daysInMonth,
                        currentDate.Hour, currentDate.Minute, currentDate.Second);
                }

                itemCount++;
            }
        }

        private void GenerateYearlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
        {
            DateTime currentDate = template.StartDateTime;
            int itemCount = 0;
            TimeSpan duration = template.EndDateTime.GetValueOrDefault() - template.StartDateTime;

            while ((endDate == null || currentDate <= endDate) && (count == null || itemCount < count))
            {
                var newItem = CloneScheduleItem(template);
                newItem.StartDateTime = currentDate;
                newItem.EndDateTime = currentDate.Add(duration);
                items.Add(newItem);

                // Avançar para o mesmo dia do próximo ano
                currentDate = currentDate.AddYears(1);
                itemCount++;
            }
        }

        private ScheduleItem CloneScheduleItem(ScheduleItem source)
        {
            return new ScheduleItem
            {
                Title = source.Title,
                Description = source.Description,
                Location = source.Location,
                IsAllDay = source.IsAllDay,
                Status = source.Status,
                ColorCategoryHexa = source.ColorCategoryHexa,
                IsPushedCalendar = source.IsPushedCalendar,
                TimeZone = source.TimeZone,
                TokenRecurrence = source.TokenRecurrence,
                RecurrenceType = source.RecurrenceType,
                RecurrenceDays = source.RecurrenceDays,
                RecurrenceEndDate = source.RecurrenceEndDate,
                RecurrenceCount = source.RecurrenceCount,
                ReasonCancellation = source.ReasonCancellation
            };
        }

        private DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            if (daysToAdd == 0) // Se for o mesmo dia da semana
            {
                return start;
            }
            return start.AddDays(daysToAdd);
        }
        #region Private Methods for Validation

        private async Task<bool> ValidateTimeSlotOverlap(ScheduleItem newItem, List<ScheduleItem> existingItems)
        {
            // Verificar se o novo item se sobrepõe a itens existentes
            return !existingItems.Any(item =>
                item.StartDateTime < newItem.EndDateTime &&
                item.EndDateTime > newItem.StartDateTime);
        }

        private async Task<bool> ValidateWorkingHours(ScheduleItem item, long medicalId)
        {
            var medical = await _medicalRepository.FindByID(medicalId);
            if (medical == null) return false;

            // Verificar se o dia da semana está nos dias de trabalho do médico
            if (!medical.WorkingDays.Contains(item.StartDateTime.DayOfWeek))
                return false;

            // Verificar se o horário está dentro do horário de trabalho
            var startTimeOfDay = item.StartDateTime.TimeOfDay;
            var endTimeOfDay = item.EndDateTime.GetValueOrDefault().TimeOfDay;

            return startTimeOfDay >= medical.StartWorkingTime &&
                   endTimeOfDay <= medical.EndWorkingTime;
        }

        #endregion Private Methods for Validation 

        #endregion Private Methods for Recurrence Generation
    }
}