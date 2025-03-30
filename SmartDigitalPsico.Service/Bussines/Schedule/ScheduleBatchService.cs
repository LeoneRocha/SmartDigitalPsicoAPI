using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
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

        /// <summary>
        /// Cria ou atualiza um lote de agendamentos, gerando recorrências se necessário
        /// </summary>
        /// <param name="item">DTO com os dados do agendamento</param>
        /// <param name="isUpdate">Indica se é uma atualização (true) ou criação (false)</param>
        /// <param name="updateSeries">Indica se deve atualizar toda a série (apenas para atualizações)</param>
        /// <returns>Resposta do serviço com os dados do lote criado/atualizado</returns>
        public async Task<ServiceResponse<GetScheduleBatchDto>> CreateOrUpdateBatchAsync(ScheduleMedicalCalendarCriteriaDto item)
        {
            ServiceResponse<GetScheduleBatchDto> response = new ServiceResponse<GetScheduleBatchDto>();
            try
            {
                // Validar o DTO usando o validador específico
                var validationResultInput = await _validators.ScheduleBatchCalendarDtoValidator.ValidateAsync(item);
                if (!validationResultInput.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResultInput.Errors);
                    response.Message = validationResultInput.Errors.First().ErrorMessage;
                    return response;
                }

                ScheduleBatch? entityBatch;
                string batchToken;

                // Verificar se é atualização ou criação
                if (item.IsUpdate && !string.IsNullOrEmpty(item.TokenRecurrence))
                {
                    // Buscar o batch existente para atualização
                    entityBatch = await _entityRepository.GetByBatchTokenAsync(item.TokenRecurrence);
                    if (entityBatch == null)
                    {
                        response.Success = false;
                        response.Message = await base.GetLocalization(
                            GeneralLanguageKeyConstants.RegisterIsNotFound,
                            GeneralLanguageMenssageConstants.RegisterIsNotFound);
                        return response;
                    }
                    batchToken = entityBatch.BatchToken;

                    // Remover itens existentes se for atualizar a série
                    if (item.UpdateSeries)
                    {
                        // Excluir todos os itens existentes para recriar com o novo padrão
                        await _entityRepository.DeleteRangeAsync(new[] { entityBatch });

                        // Criar um novo batch com o mesmo token
                        entityBatch = new ScheduleBatch
                        {
                            MedicalId = item.MedicalId,
                            PatientId = item.PatientId,
                            BatchToken = batchToken,
                            CreatedUserId = entityBatch.CreatedUserId,
                            CreatedDate = entityBatch.CreatedDate,
                            ModifyUserId = UserId,
                            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                            LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                            Enable = true
                        };
                    }
                    else
                    {
                        // Atualizar apenas os metadados do batch
                        entityBatch.ModifyUserId = UserId;
                        entityBatch.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                        entityBatch.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                        entityBatch.MedicalId = item.MedicalId;
                        entityBatch.PatientId = item.PatientId;

                        // Manter os itens existentes
                        response.Data = _mapper.Map<GetScheduleBatchDto>(entityBatch);
                        response.Success = true;
                        response.Message = await base.GetLocalization(
                            "ScheduleBatch_Updated_Key",
                            "Schedule batch updated successfully.");
                        return response;
                    }
                }
                else
                {
                    // Criar um novo batch
                    batchToken = string.IsNullOrEmpty(item.TokenRecurrence) ?
                        Guid.NewGuid().ToString() : item.TokenRecurrence;

                    entityBatch = new ScheduleBatch
                    {
                        MedicalId = item.MedicalId,
                        PatientId = item.PatientId,
                        BatchToken = batchToken,
                        CreatedUserId = UserId,
                        ModifyUserId = UserId,
                        CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                        ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                        LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                        Enable = true
                    };
                }

                // Criar lista para armazenar itens gerados
                var scheduleItems = new List<ScheduleItem>();

                // Criar o item template a partir do DTO
                var templateItem = new ScheduleItem
                {
                    MedicalId = item.MedicalId,
                    PatientId = item.PatientId ?? 0,
                    Title = item.Title,
                    Description = item.Description,
                    Location = item.Location,
                    StartDateTime = item.StartDateTime,
                    EndDateTime = item.EndDateTime,
                    IsAllDay = item.IsAllDay,
                    Status = item.Status,
                    ColorCategoryHexa = item.ColorCategoryHexa,
                    IsPushedCalendar = item.IsPushedCalendar,
                    TimeZone = item.TimeZone,
                    TokenRecurrence = batchToken,
                    RecurrenceType = item.RecurrenceType,
                    RecurrenceDays = item.RecurrenceDays,
                    RecurrenceEndDate = item.RecurrenceEndDate,
                    RecurrenceCount = item.RecurrenceCount
                };

                // Determinar datas de início e fim para o batch
                DateTime startPeriod = templateItem.StartDateTime;
                DateTime endPeriod = item.RecurrenceEndDate ?? templateItem.StartDateTime.AddYears(1);

                // Gerar itens recorrentes com base no tipo de recorrência
                if (item.RecurrenceType != ERecurrenceCalendarType.None)
                {
                    switch (item.RecurrenceType)
                    {
                        case ERecurrenceCalendarType.Daily:
                            GenerateDailyRecurrence(templateItem, scheduleItems, item.RecurrenceEndDate, item.RecurrenceCount);
                            break;
                        case ERecurrenceCalendarType.Weekly:
                            GenerateWeeklyRecurrence(templateItem, scheduleItems, item.RecurrenceEndDate, item.RecurrenceCount, item.RecurrenceDays);
                            break;
                        case ERecurrenceCalendarType.Monthly:
                            GenerateMonthlyRecurrence(templateItem, scheduleItems, item.RecurrenceEndDate, item.RecurrenceCount);
                            break;
                        case ERecurrenceCalendarType.Yearly:
                            GenerateYearlyRecurrence(templateItem, scheduleItems, item.RecurrenceEndDate, item.RecurrenceCount);
                            break;
                    }
                }
                else
                {
                    // Para ERecurrenceCalendarType.None, apenas adicionar o item original
                    scheduleItems.Add(templateItem);
                }

                if (scheduleItems.Count == 0)
                {
                    response.Success = false;
                    response.Message = "No items were generated";
                    return response;
                }

                // Atualizar o batch com os itens gerados
                entityBatch.ScheduleData = scheduleItems.ToArray();
                entityBatch.StartPeriod = scheduleItems.Min(i => i.StartDateTime);
                entityBatch.EndPeriod = scheduleItems.Max(i => i.EndDateTime ?? i.StartDateTime);

                // Validar o batch antes de salvar
                var validationResultEntity = await _validators.EntityValidator.ValidateAsync(entityBatch);
                if (!validationResultEntity.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResultInput.Errors);
                    response.Message = validationResultEntity.Errors.First().ErrorMessage;
                    return response;
                }

                // Salvar o batch
                ScheduleBatch entityResponse;
                if (item.IsUpdate && !string.IsNullOrEmpty(item.TokenRecurrence))
                {
                    entityResponse = await _entityRepository.Update(entityBatch);
                    response.Message = await base.GetLocalization(
                        "ScheduleBatch_Updated_Key",
                        "Schedule batch updated successfully.");
                }
                else
                {
                    entityResponse = await _entityRepository.Create(entityBatch);
                    response.Message = await base.GetLocalization(
                        "ScheduleBatch_Created_Key",
                        "Schedule batch created successfully.");
                }

                response.Success = true;
                response.Data = _mapper.Map<GetScheduleBatchDto>(entityResponse);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at ScheduleBatchService.CreateOrUpdateBatchAsync");
                response.Success = false;
                response.Message = await base.GetLocalization(
                    ValidatorConstants.GenericErroMessageKey,
                    ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

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

        private static void GenerateWeeklyRecurrence(ScheduleItem template, List<ScheduleItem> items, DateTime? endDate, short? count, DayOfWeek[] days)
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
                        currentDate.Hour, currentDate.Minute, currentDate.Second);
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