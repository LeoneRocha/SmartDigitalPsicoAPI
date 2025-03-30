using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
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
        private readonly IScheduleBatchCollectionValidators _validators;

        public ScheduleBatchService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IScheduleBatchCollectionValidators scheduleBatchValidators,
            IScheduleBatchRepository entityRepository,
            IPatientRepositories repositoriesPatientShared)
            : base(sharedServices, sharedDependenciesConfig, repositoriesPatientShared.SharedRepositories, entityRepository, scheduleBatchValidators.EntityValidator)
        {
            _validators = scheduleBatchValidators;
        }
        public override Task<ServiceResponse<GetScheduleBatchDto>> Create(AddScheduleBatchDto item)
        {
            throw new NotImplementedException();
        }
        public override Task<ServiceResponse<GetScheduleBatchDto>> Update(UpdateScheduleBatchDto item)
        {
            throw new NotImplementedException();
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

        /// <summary>
        /// Cria ou atualiza um lote de agendamentos, gerando recorrências se necessário
        /// </summary>
        /// <param name="item">DTO com os dados do agendamento</param>
        /// <param name="isUpdate">Indica se é uma atualização (true) ou criação (false)</param>
        /// <param name="updateSeries">Indica se deve atualizar toda a série (apenas para atualizações)</param>
        /// <returns>Resposta do serviço com os dados do lote criado/atualizado</returns>
        public async Task<ServiceResponse<GetScheduleBatchDto>> CreateOrUpdateBatchAsync(ScheduleMedicalCalendarCriteriaDto request)
        {
            var response = new ServiceResponse<GetScheduleBatchDto>();

            try
            {
                // Validate input
                if (!await ValidateScheduleBatchRequest(request, response))
                {
                    return response;
                }

                // Get or create batch entity
                var (entityBatch, batchToken) = await GetOrCreateBatchEntity(request);
                if (entityBatch == null)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(
                        GeneralLanguageKeyConstants.RegisterIsNotFound,
                        GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }

                // Handle early return for metadata-only updates
                if (request.IsUpdate && !string.IsNullOrEmpty(request.TokenRecurrence) && !request.UpdateSeries)
                {
                    return await HandleMetadataOnlyUpdate(entityBatch);
                }

                // Generate schedule items based on recurrence pattern
                var scheduleItems = GenerateScheduleItems(request, batchToken);
                if (scheduleItems.Count == 0)
                {
                    response.Success = false;
                    response.Message = "No items were generated";
                    return response;
                }

                // Update batch with generated items
                UpdateBatchWithScheduleItems(entityBatch, scheduleItems);

                // Validate batch entity before saving
                if (!await ValidateBatchEntity(entityBatch, response))
                {
                    return response;
                }

                // Save batch and return response
                return await SaveBatchAndCreateResponse(entityBatch, request.IsUpdate);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.CreateOrUpdateBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
                return response;
            }
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

        #region  CreateOrUpdateBatchAsync    
        private async Task<bool> ValidateScheduleBatchRequest(ScheduleMedicalCalendarCriteriaDto request, ServiceResponse<GetScheduleBatchDto> response)
        {
            var validationResult = await _validators.ScheduleBatchCalendarDtoValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Message = validationResult.Errors[0].ErrorMessage;
                return false;
            }
            return true;
        }

        private async Task<(ScheduleBatch? entityBatch, string batchToken)> GetOrCreateBatchEntity(ScheduleMedicalCalendarCriteriaDto request)
        {
            string batchToken;
            ScheduleBatch? entityBatch = null;

            if (request.IsUpdate && !string.IsNullOrEmpty(request.TokenRecurrence))
            {
                // Handle update scenario
                entityBatch = await _entityRepository.GetByBatchTokenAsync(request.TokenRecurrence);
                if (entityBatch == null)
                {
                    return (null, string.Empty);
                }

                batchToken = entityBatch.BatchToken;

                if (request.UpdateSeries)
                {
                    // Delete existing batch for full series update
                    await _entityRepository.DeleteRangeAsync(new[] { entityBatch });

                    // Create new batch with same token
                    entityBatch = CreateNewBatchEntity(request);
                }
                else
                {
                    // Update metadata only
                    UpdateBatchMetadata(entityBatch, request.MedicalId, request.PatientId);
                }
            }
            else
            {
                // Handle create scenario
                batchToken = string.IsNullOrEmpty(request.TokenRecurrence)
                    ? Guid.NewGuid().ToString()
                    : request.TokenRecurrence;

                entityBatch = CreateNewBatchEntity(request);
            }

            return (entityBatch, batchToken);
        }

        private ScheduleBatch CreateNewBatchEntity(ScheduleMedicalCalendarCriteriaDto request)
        {
            var now = DateHelper.GetDateTimeNowFromUtc();

            // Map the common properties from ActionMedicalCalendarDtoBase
            var criteriaDto = _mapper.Map<ScheduleBatch>(request);  
            criteriaDto.BatchToken = request.TokenRecurrence; 
            criteriaDto.Enable = true;

            criteriaDto.StartPeriod = request.StartDateTime;
            criteriaDto.EndPeriod = request.EndDateTime ?? request.RecurrenceEndDate ?? request.StartDateTime;            

            return criteriaDto;
        }

        private void UpdateBatchMetadata(ScheduleBatch batch, long medicalId, long? patientId)
        {
            var now = DateHelper.GetDateTimeNowFromUtc();

            batch.ModifyUserId = UserId;
            batch.ModifyDate = now;
            batch.LastAccessDate = now;
            batch.MedicalId = medicalId;
            batch.PatientId = patientId;
        }

        private async Task<ServiceResponse<GetScheduleBatchDto>> HandleMetadataOnlyUpdate(ScheduleBatch entityBatch)
        {
            var response = new ServiceResponse<GetScheduleBatchDto>
            {
                Data = _mapper.Map<GetScheduleBatchDto>(entityBatch),
                Success = true,
                Message = await base.GetLocalization(
                    "ScheduleBatch_Updated_Key",
                    "Schedule batch updated successfully.")
            };

            return response;
        }

        private static List<ScheduleItem> GenerateScheduleItems(ScheduleMedicalCalendarCriteriaDto request, string batchToken)
        {
            // Create template item from request
            var templateItem = CreateTemplateScheduleItem(request, batchToken);

            // Generate items based on recurrence type
            var scheduleItems = new List<ScheduleItem>();

            if (request.RecurrenceType == ERecurrenceCalendarType.None)
            {
                scheduleItems.Add(templateItem);
                return scheduleItems;
            }

            switch (request.RecurrenceType)
            {
                case ERecurrenceCalendarType.Daily:
                    GenerateDailyRecurrence(templateItem, scheduleItems, request.RecurrenceEndDate, request.RecurrenceCount);
                    break;
                case ERecurrenceCalendarType.Weekly:
                    GenerateWeeklyRecurrence(new WeeklyRecurrenceParams() { Template = templateItem, Items = scheduleItems, EndDate = request.RecurrenceEndDate, Count = request.RecurrenceCount, Days = request.RecurrenceDays });
                    break;
                case ERecurrenceCalendarType.Monthly:
                    GenerateMonthlyRecurrence(templateItem, scheduleItems, request.RecurrenceEndDate, request.RecurrenceCount);
                    break;
                case ERecurrenceCalendarType.Yearly:
                    GenerateYearlyRecurrence(templateItem, scheduleItems, request.RecurrenceEndDate, request.RecurrenceCount);
                    break;
            }

            return scheduleItems;
        }

        private static ScheduleItem CreateTemplateScheduleItem(ScheduleMedicalCalendarCriteriaDto request, string batchToken)
        {
            return new ScheduleItem
            {
                MedicalId = request.MedicalId,
                PatientId = request.PatientId ?? 0,
                Title = request.Title,
                Description = request.Description,
                Location = request.Location,
                StartDateTime = request.StartDateTime,
                EndDateTime = request.EndDateTime,
                IsAllDay = request.IsAllDay,
                Status = request.Status,
                ColorCategoryHexa = request.ColorCategoryHexa,
                IsPushedCalendar = request.IsPushedCalendar,
                TimeZone = request.TimeZone,
                TokenRecurrence = batchToken,
                RecurrenceType = request.RecurrenceType,
                RecurrenceDays = request.RecurrenceDays,
                RecurrenceEndDate = request.RecurrenceEndDate,
                RecurrenceCount = request.RecurrenceCount
            };
        }

        private static void UpdateBatchWithScheduleItems(ScheduleBatch batch, List<ScheduleItem> items)
        {
            batch.ScheduleData = items.ToArray();
            batch.StartPeriod = items.Min(i => i.StartDateTime);
            batch.EndPeriod = items.Max(i => i.EndDateTime ?? i.StartDateTime);
        }

        private async Task<bool> ValidateBatchEntity(ScheduleBatch entityBatch, ServiceResponse<GetScheduleBatchDto> response)
        {
            var validationResult = await _validators.EntityValidator.ValidateAsync(entityBatch);
            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Message = validationResult.Errors[0].ErrorMessage;
                return false;
            }
            return true;
        }
        #endregion  CreateOrUpdateBatchAsync
        #region Private Methods for Recurrence Generation

        private static void GenerateDailyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
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
        private static void GenerateWeeklyRecurrence(WeeklyRecurrenceParams recurrenceParams)
        {
            recurrenceParams.Days ??= new[] { recurrenceParams.Template.StartDateTime.DayOfWeek };

            var context = new RecurrenceContext
            {
                CurrentDate = recurrenceParams.Template.StartDateTime,
                ItemCount = 0,
                Duration = recurrenceParams.Template.EndDateTime.GetValueOrDefault() - recurrenceParams.Template.StartDateTime
            };

            while (ShouldContinueRecurrence(context, recurrenceParams))
            {
                ProcessDaysForRecurrence(recurrenceParams, context);
                context.CurrentDate = context.CurrentDate.AddDays(7); // Avançar para a próxima semana
            }
        }

        private static bool ShouldContinueRecurrence(RecurrenceContext context, WeeklyRecurrenceParams recurrenceParams)
        {
            return (recurrenceParams.EndDate == null || context.CurrentDate <= recurrenceParams.EndDate) &&
                   (recurrenceParams.Count == null || context.ItemCount < recurrenceParams.Count);
        }

        private static void ProcessDaysForRecurrence(WeeklyRecurrenceParams recurrenceParams, RecurrenceContext context)
        {
            foreach (var day in recurrenceParams.Days)
            {
                DateTime nextDate = GetNextWeekday(context.CurrentDate, day);

                if (ShouldSkipItem(nextDate, recurrenceParams, context)) continue;

                AddScheduleItem(recurrenceParams.Template, recurrenceParams.Items, nextDate, context.Duration);
                context.ItemCount++;
            }
        }

        private static bool ShouldSkipItem(DateTime nextDate, WeeklyRecurrenceParams recurrenceParams, RecurrenceContext context)
        {
            return (recurrenceParams.EndDate != null && nextDate > recurrenceParams.EndDate) || (recurrenceParams.Count != null && context.ItemCount >= recurrenceParams.Count);
        }

        private static void AddScheduleItem(ScheduleItem template, List<ScheduleItem> items, DateTime nextDate, TimeSpan duration)
        {
            var newItem = CloneScheduleItem(template);
            newItem.StartDateTime = nextDate;
            newItem.EndDateTime = nextDate.Add(duration);
            items.Add(newItem);
        }

        private async Task<ServiceResponse<GetScheduleBatchDto>> SaveBatchAndCreateResponse(ScheduleBatch entityBatch, bool isUpdate)
        {
            var response = new ServiceResponse<GetScheduleBatchDto>();
            ScheduleBatch entityResponse;

            entityBatch.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            if (isUpdate)
            {
                entityBatch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityResponse = await _entityRepository.Update(entityBatch);
                response.Message = await base.GetLocalization(
                    "ScheduleBatch_Updated_Key",
                    "Schedule batch updated successfully.");
            }
            else
            {
                entityBatch.CreatedDate = DateHelper.GetDateTimeNowFromUtc();

                entityResponse = await _entityRepository.Create(entityBatch);
                response.Message = await base.GetLocalization(
                    "ScheduleBatch_Created_Key",
                    "Schedule batch created successfully.");
            }

            response.Success = true;
            response.Data = _mapper.Map<GetScheduleBatchDto>(entityResponse);
            return response;
        }
        private static void GenerateMonthlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
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
                        currentDate.Hour, currentDate.Minute, currentDate.Second, DateTimeKind.Utc);
                }
                itemCount++;
            }
        }

        private static void GenerateYearlyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count)
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

        private static ScheduleItem CloneScheduleItem(ScheduleItem source)
        {
            return new ScheduleItem
            {
                MedicalId = source.MedicalId,
                PatientId = source.PatientId,
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

        private static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            if (daysToAdd == 0) // Se for o mesmo dia da semana
            {
                return start;
            }
            return start.AddDays(daysToAdd);
        }

        #endregion Private Methods for Recurrence Generation
    }
}