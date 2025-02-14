using Azure;
using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class MedicalCalendarService : EntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto, IMedicalCalendarRepository>, IMedicalCalendarService
    {

        private readonly IMedicalRepository _medicalRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMedicalCalendarValidators _validators;
        public MedicalCalendarService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IMedicalCalendarValidators medicalCalendarValidators,
            IMedicalCalendarRepository entityRepository,
            IPatientRepositories repositoriesShared
            )
            : base(sharedServices, sharedDependenciesConfig, repositoriesShared.SharedRepositories, entityRepository, medicalCalendarValidators.EntityValidator)
        {
            _medicalRepository = repositoriesShared.MedicalRepository;
            _userRepository = repositoriesShared.SharedRepositories.UserRepository;
            _validators = medicalCalendarValidators;
        }

        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
        {
            ServiceResponse<GetMedicalCalendarDto> response = new ServiceResponse<GetMedicalCalendarDto>();
            try
            {
                var entityAdd = _mapper.Map<MedicalCalendar>(item);
                entityAdd.Enable = true;
                #region Relationship
                entityAdd.CreatedUserId = UserId;
                entityAdd.PatientId = item.PatientId;
                entityAdd.MedicalId = item.MedicalId;
                #endregion Relationship

                entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    if (entityAdd.RecurrenceType != ERecurrenceCalendarType.None)
                    {
                        try
                        {
                            entityAdd.TokenRecurrence = Guid.NewGuid().ToString();
                            await GenerateRecurrenceAsync(entityAdd, false);
                            response.Data = _mapper.Map<GetMedicalCalendarDto>(entityAdd);
                            response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarRegistred, MedicalCalendarMenssageConstants.CalendarRegistred);

                        }
                        catch (Exception ex)
                        {
                            response.Message = ex.Message;
                            response.Success = false;
                        }
                    }
                    else
                    {
                        MedicalCalendar entityResponse = await _entityRepository.Create(entityAdd);
                        response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                        response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarRegistred, MedicalCalendarMenssageConstants.CalendarRegistred);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.Create");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }

            return response;
        }

        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
        {
            ServiceResponse<GetMedicalCalendarDto> response = new ServiceResponse<GetMedicalCalendarDto>();

            try
            {
                var entityUpdate = _mapper.Map<MedicalCalendar>(item);
                entityUpdate.Enable = item.Enable;
                #region Relationship
                entityUpdate.CreatedUserId = UserId;
                entityUpdate.ModifyUserId = UserId;
                entityUpdate.PatientId = item.PatientId;
                entityUpdate.MedicalId = item.MedicalId;
                #endregion Relationship

                var entityListExists = await _entityRepository.FindByCustomWhere(e => e.MedicalId == entityUpdate.MedicalId && e.PatientId == entityUpdate.PatientId && e.StartDateTime == entityUpdate.StartDateTime && e.EndDateTime == entityUpdate.EndDateTime);

                if (entityListExists != null && entityListExists.Count > 0)
                {
                    var entityFirst = entityListExists[0];
                    entityUpdate.CreatedDate = entityFirst.CreatedDate;
                }

                entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    if (entityUpdate.RecurrenceType != ERecurrenceCalendarType.None && (item.UpdateSeries || !string.IsNullOrEmpty(item.TokenRecurrence)))
                    {
                        try
                        {
                            await GenerateRecurrenceAsync(entityUpdate, item.UpdateSeries);
                            response.Data = _mapper.Map<GetMedicalCalendarDto>(entityUpdate);
                            response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarUpdated, MedicalCalendarMenssageConstants.CalendarUpdated);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        MedicalCalendar entityResponse = await _entityRepository.Update(entityUpdate);
                        response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                        response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarUpdated, MedicalCalendarMenssageConstants.CalendarUpdated);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.Update");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }
            return response;
        }

        #region PRIVATE   Create/Update
        private async Task GenerateRecurrenceAsync(MedicalCalendar medicalCalendar, bool updateSeries)
        {
            var events = new List<MedicalCalendar>();
            var validator = new MedicalCalendarRangeValidator(_entityRepository);
            var count = new RefDto<int>(0);

            if (updateSeries || !string.IsNullOrEmpty(medicalCalendar.TokenRecurrence))
            {
                var existingEvents = await _entityRepository.GetByMedicalCalendarAsync(medicalCalendar);
                await _entityRepository.DeleteRangeAsync(existingEvents);
            }

            switch (medicalCalendar.RecurrenceType)
            {
                case ERecurrenceCalendarType.Daily:
                    await GenerateRecurrenceAsync(medicalCalendar, events, validator, count, 1, ETimeUnitCalendarType.Days);
                    break;
                case ERecurrenceCalendarType.Weekly:
                    await GenerateWeeklyRecurrenceAsync(medicalCalendar, events, validator, count);
                    break;
                case ERecurrenceCalendarType.Monthly:
                    await GenerateRecurrenceAsync(medicalCalendar, events, validator, count, 1, ETimeUnitCalendarType.Months);
                    break;
                case ERecurrenceCalendarType.Yearly:
                    await GenerateRecurrenceAsync(medicalCalendar, events, validator, count, 1, ETimeUnitCalendarType.Years);
                    break;
            }
            events = events.OrderBy(e => e.StartDateTime).ToList();
            await _entityRepository.AddRangeAsync(events);
        }
        private static async Task GenerateRecurrenceAsync(MedicalCalendar medicalCalendar, List<MedicalCalendar> events, MedicalCalendarRangeValidator validator, RefDto<int> count, int interval, ETimeUnitCalendarType unit)
        {
            DateTime currentStart = medicalCalendar.StartDateTime;
            DateTime currentEnd = medicalCalendar.EndDateTime.GetValueOrDefault();

            while ((medicalCalendar.RecurrenceEndDate == null || currentStart <= medicalCalendar.RecurrenceEndDate) && (medicalCalendar.RecurrenceCount == null || count.Value < medicalCalendar.RecurrenceCount))
            {
                if (medicalCalendar.RecurrenceDays.Contains(currentStart.DayOfWeek))
                {
                    await AddEventAsync(medicalCalendar, events, validator, count, currentStart, currentEnd);
                }
                currentStart = AddTime(currentStart, interval, unit);
                currentEnd = AddTime(currentEnd, interval, unit);
            }
        }
        private static async Task GenerateWeeklyRecurrenceAsync(MedicalCalendar medicalCalendar, List<MedicalCalendar> events, MedicalCalendarRangeValidator validator, RefDto<int> count)
        {
            DateTime currentStart = medicalCalendar.StartDateTime;
            DateTime currentEnd = medicalCalendar.EndDateTime.GetValueOrDefault();
            var recurrenceCount = medicalCalendar.RecurrenceCount.GetValueOrDefault();

            // Calcula o número total de ocorrências
            int totalOccurrences = medicalCalendar.RecurrenceDays.Length * (recurrenceCount == 0 ? 1 : recurrenceCount);

            DateTime? calculatedEndDate = medicalCalendar.RecurrenceEndDate;

            if (calculatedEndDate == null && medicalCalendar.RecurrenceCount != null)
            {
                calculatedEndDate = CalculateEndDate(medicalCalendar, totalOccurrences, calculatedEndDate);
            }
            medicalCalendar.RecurrenceEndDate = calculatedEndDate;

            while ((calculatedEndDate == null || currentStart <= calculatedEndDate) && (totalOccurrences == 0 || count.Value < totalOccurrences))
            {
                foreach (var day in medicalCalendar.RecurrenceDays)
                {
                    var nextDate = GetNextWeekday(currentStart, day);
                    if (calculatedEndDate != null && nextDate > calculatedEndDate)
                        break;

                    if (medicalCalendar.RecurrenceDays.Contains(nextDate.DayOfWeek))
                    {
                        await AddEventAsync(medicalCalendar, events, validator, count, nextDate, nextDate.Add(currentEnd - currentStart));
                    }
                }
                currentStart = currentStart.AddDays(7);
                currentEnd = currentEnd.AddDays(7);
            }
        }
        private static DateTime CalculateEndDate(MedicalCalendar medicalCalendar, int totalOccurrences, DateTime? calculatedEndDate)
        {
            // Calcula a data final com base no número total de ocorrências
            DateTime tempStart = medicalCalendar.StartDateTime;
            int occurrencesCount = 0;

            while (occurrencesCount < totalOccurrences)
            {
                foreach (var day in medicalCalendar.RecurrenceDays)
                {
                    var nextDate = GetNextWeekday(tempStart, day);
                    occurrencesCount++;
                    if (occurrencesCount == totalOccurrences)
                    {
                        calculatedEndDate = nextDate;
                        break;
                    }
                }
                tempStart = tempStart.AddDays(7);
            }
            var endResultDate = calculatedEndDate ?? (medicalCalendar.EndDateTime ?? medicalCalendar.StartDateTime);
            return endResultDate;
        }
        private static async Task AddEventAsync(MedicalCalendar medicalCalendar, List<MedicalCalendar> events, MedicalCalendarRangeValidator validator, RefDto<int> count, DateTime start, DateTime end)
        {
            var newEvent = new MedicalCalendar
            {
                Title = medicalCalendar.Title,
                Description = medicalCalendar.Description,
                StartDateTime = start,
                EndDateTime = end,
                Location = medicalCalendar.Location,
                IsAllDay = medicalCalendar.IsAllDay,
                RecurrenceDays = medicalCalendar.RecurrenceDays,
                RecurrenceType = medicalCalendar.RecurrenceType,
                TimeZone = medicalCalendar.TimeZone,
                ColorCategoryHexa = medicalCalendar.ColorCategoryHexa,
                CreatedDate = medicalCalendar.CreatedDate,
                CreatedUserId = medicalCalendar.CreatedUserId,
                Enable = medicalCalendar.Enable,
                IsPushedCalendar = medicalCalendar.IsPushedCalendar,
                LastAccessDate = medicalCalendar.LastAccessDate,
                MedicalId = medicalCalendar.MedicalId,
                ModifyDate = medicalCalendar.ModifyDate,
                ModifyUserId = medicalCalendar.ModifyUserId,
                PatientId = medicalCalendar.PatientId,
                RecurrenceCount = medicalCalendar.RecurrenceCount,
                RecurrenceEndDate = medicalCalendar.RecurrenceEndDate,
                Status = medicalCalendar.Status,
                TokenRecurrence = medicalCalendar.TokenRecurrence,
            };

            var validationResult = await validator.ValidateAsync(newEvent);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            events.Add(newEvent);
            count.Value++;
        }
        private static DateTime AddTime(DateTime dateTime, int interval, ETimeUnitCalendarType unit)
        {
            return unit switch
            {
                ETimeUnitCalendarType.Days => dateTime.AddDays(interval),
                ETimeUnitCalendarType.Months => dateTime.AddMonths(interval),
                ETimeUnitCalendarType.Years => dateTime.AddYears(interval),
                _ => dateTime
            };
        }
        private static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
        #endregion PRIVATE   Create/Update

        public async Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
        {
            try
            {
                if (request.DeleteSeries)
                {
                    return await DeleteSeries(request);
                }
                else
                {
                    return await DeleteOne(request);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.DeleteOneOrRecurrence");
                var response = new ServiceResponse<bool>();
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);

                return response;
            }
        }

        #region PRIVATE DELETE 
        private async Task<ServiceResponse<bool>> DeleteSeries(DeleteMedicalCalendarDto request)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            var calendars = await _entityRepository.GetByTokenAsync(request.TokenRecurrence, request.MedicalId, request.PatientId);

            if (calendars.Length < 1)
            {
                response.Success = false;
                response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);

                return response;
            }
            var recordsList = new RecordsList<MedicalCalendar>
            {
                UserIdLogged = UserId,
                Records = calendars.ToList()
            };

            var validationResult = await _validators.MedicalCalendarListValidator.ValidateAsync(recordsList);

            if (validationResult.IsValid)
            {
                await _entityRepository.DeleteRangeAsync(calendars);

                response.Data = true;
                response.Success = true;
                response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully);

            }
            else
            {
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Success = false;
                response.Message = await base.GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
            }
            return response;
        }

        private async Task<ServiceResponse<bool>> DeleteOne(DeleteMedicalCalendarDto request)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();

            if (!await _entityRepository.Exists(request.Id))
            {
                response.Success = false;
                response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);

                return response;

            }
            var calendar = await _entityRepository.FindByID(request.Id);

            var recordsList = new RecordsList<MedicalCalendar>
            {
                UserIdLogged = UserId,
                Records = new List<MedicalCalendar>() { calendar }
            };

            var validationResult = await _validators.MedicalCalendarListValidator.ValidateAsync(recordsList);

            if (validationResult.IsValid)
            {
                response = await base.Delete(request.Id);
            }
            else
            {
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Success = false;
                response.Message = await base.GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
            }
            return response;
        }
        #endregion PRIVATE DELETE

        public async Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
        {
            var response = new ServiceResponse<CalendarDto>();
            try
            {
                criteria.UserIdLogged = UserId;

                if (!await ValidateCriteriaAsync(criteria, response))
                {
                    return response;
                }

                var medical = await GetMedicalAsync(criteria.MedicalId);
                var user = await GetUserAsync(UserId);

                var (startDate, endDate) = GetDateRange(criteria.Year, criteria.Month);

                if (criteria.StartDate.HasValue && criteria.EndDate.HasValue)
                {
                    if (criteria.StartDate.GetValueOrDefault() > DateTime.MinValue)
                    {
                        startDate = criteria.StartDate.Value.Date;
                    }
                    if (criteria.EndDate.GetValueOrDefault() > DateTime.MinValue)
                    {
                        endDate = criteria.EndDate.Value.Date;
                    }
                }

                var interval = TimeSpan.FromMinutes(medical.PatientIntervalTimeMinutes);

                criteria.IntervalInMinutes = medical.PatientIntervalTimeMinutes;

                if (!await ValidateCriteriaAsync(criteria, response))
                {
                    return response;
                }

                var medicalCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(criteria.MedicalId, startDate, endDate);

                if (!await ValidateMedicalCalendarsAsync(medicalCalendars, response))
                {
                    return response;
                }
                var criteriaDays = CreateDaysCalendarCriteria(user, medical, startDate, endDate, interval, medicalCalendars);

                var days = GenerateDaysCalendar(criteriaDays);

                //Filters
                var filteredDays = FilterDaysWithMedicalCalendar(criteria, days);
                filteredDays = FilterDaysByDate(criteria, filteredDays);
                if (criteria.FilterDaysAndTimesWithAppointments)
                {
                    filteredDays = FilterByWorkingDays(medical, filteredDays);
                }

                // Mark non-working days as unavailable
                FillMarkNonWorkingDays(filteredDays, medical.WorkingDays);

                filteredDays = OrdenateDays(filteredDays);

                response.Data = CreateCalendarDto(medical, filteredDays);
                response.Success = true;
                response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarSuccess, MedicalCalendarMenssageConstants.CalendarSuccess);

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.GetMonthlyCalendar");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }

            return response;
        }

        #region PRIVATE  GetMonthlyCalendar
        private DayCalendarDto[] OrdenateDays(DayCalendarDto[] filteredDays)
        {
            return filteredDays.OrderBy(x => x.Date).ToArray();
        }
        private async Task<bool> ValidateCriteriaAsync(CalendarCriteriaDto criteria, ServiceResponse<CalendarDto> response)
        {
             var validator = new CalendarCriteriaValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(criteria);

            if (!validationResult.IsValid)
            {
                await ReturnEmptyResult(new Medical(), response, validationResult);
                return false;
            }

            return true;
        }
        private async Task<bool> ValidateMedicalCalendarsAsync(IEnumerable<MedicalCalendar> medicalCalendars, ServiceResponse<CalendarDto> response)
        {
            var recordsList = new RecordsList<MedicalCalendar>
            {
                UserIdLogged = UserId,
                Records = medicalCalendars.ToList()
            };

            var validator = new MedicalCalendarListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (!validationResult.IsValid)
            {
                await ReturnEmptyResult(new Medical(), response, validationResult);
                return false;
            }

            return true;
        }
        private DaysCalendarCriteriaDto CreateDaysCalendarCriteria(User user, Medical medical, DateTime startDate, DateTime endDate, TimeSpan interval, IEnumerable<MedicalCalendar> medicalCalendars)
        {
            var medicalCalendarsDTO = medicalCalendars.Select(_mapper.Map<GetMedicalCalendarTimeSlotDto>).ToArray();

            return new DaysCalendarCriteriaDto
            {
                StartDate = startDate,
                EndDate = endDate,
                Interval = interval,
                MedicalCalendars = medicalCalendarsDTO,
                StartWorkingTime = medical.StartWorkingTime,
                EndWorkingTime = medical.EndWorkingTime,
                WorkingDays = medical.WorkingDays,
                TimeZone = user?.TimeZone ?? string.Empty
            };
        }
        private static CalendarDto CreateCalendarDto(Medical medical, DayCalendarDto[] days)
        {
            return new CalendarDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = days
            };
        }
        private async Task ReturnEmptyResult(Medical medical, ServiceResponse<CalendarDto> response, ValidationResult validationResult)
        {
            var sDto = new CalendarDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = Array.Empty<DayCalendarDto>()
            };
            response.Success = false;
            response.Data = sDto;
            response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
            var errosValidate = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
            response.Errors = await base.GetLocalizationErros(errosValidate);
        }
        private async Task<Medical> GetMedicalAsync(long medicalId)
        {
            var medical = await _medicalRepository.FindByID(medicalId);
            if (medical == null)
            {
                var valueMenssage = await base.GetLocalization(MedicalKeyConstants.Medical_Not_Found, MedicalMenssageConstants.Medical_Not_Found);
                throw new AppWarningException(valueMenssage);
            }
            return medical;
        }

        private async Task<User> GetUserAsync(long userId)
        {
            var userResult = await _userRepository.FindByID(userId);
            if (userResult == null)
            {
                var valueMenssage = await base.GetLocalization(UserKeyConstants.User_Not_Found, UserMenssageConstants.User_Not_Found);
                throw new AppWarningException(valueMenssage);
            }
            return userResult;
        }

        private static (DateTime startDate, DateTime endDate) GetDateRange(int year, int month)
        {
            var startDate = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            return (startDate, endDate);
        }
        private static DayCalendarDto[] GenerateDaysCalendar(DaysCalendarCriteriaDto criteriaDay)
        {
            var days = new List<DayCalendarDto>();
            var dateActual = DateHelper.GetDateTimeNowWithTimeZone(criteriaDay.TimeZone).Date;

            for (var date = criteriaDay.StartDate; date <= criteriaDay.EndDate; date = date.AddDays(1))
            {
                var timeSlotCriteria = new TimeSlotCriteriaDto
                {
                    Date = date,
                    Interval = criteriaDay.Interval,
                    MedicalCalendars = criteriaDay.MedicalCalendars,
                    StartWorkingTime = criteriaDay.StartWorkingTime,
                    EndWorkingTime = criteriaDay.EndWorkingTime
                };

                var timeSlots = GenerateTimeSlots(criteriaDay, timeSlotCriteria).OrderBy(x => x.StartTime).ToArray();

                var dateAdd = new DayCalendarDto
                {
                    Date = date,
                    IsPast = date.Date < dateActual,
                    TimeSlots = timeSlots
                };
                days.Add(dateAdd);
            }
            return days.ToArray();
        }
        private static TimeSlotDto[] GenerateTimeSlots(DaysCalendarCriteriaDto criteriaDay, TimeSlotCriteriaDto criteria)
        {

            var timeSlots = new List<TimeSlotDto>();
            var startDateTime = criteria.Date.Add(criteria.StartWorkingTime);
            var endDateTime = criteria.Date.Add(criteria.EndWorkingTime);
            var dateActual = DateHelper.GetDateTimeNowWithTimeZone(criteriaDay.TimeZone);

            for (var time = criteria.Date; time < criteria.Date.AddDays(1); time = time.Add(criteria.Interval))
            {
                var endTimeSlot = time.Add(criteria.Interval);
                var medicalCalendar = criteria.MedicalCalendars.ToList().Find(a => a.StartDateTime <= time && a.EndDateTime >= endTimeSlot);

                var isWithinWorkingHours = time >= startDateTime && endTimeSlot <= endDateTime;
                bool isAvailableTime = medicalCalendar == null && isWithinWorkingHours;

                //[Next Feature] add rule min hour to IsAvailable by doctor preset.
                var timeIsPast = time <= dateActual;

                var timeAdd = new TimeSlotDto
                {
                    StartTime = time,
                    EndTime = endTimeSlot,
                    IsAvailable = isAvailableTime,
                    IsPast = timeIsPast,
                    MedicalCalendar = medicalCalendar
                };
                timeSlots.Add(timeAdd);
            }
            return timeSlots.ToArray();
        }

        private static void FillMarkNonWorkingDays(DayCalendarDto[] days, IEnumerable<DayOfWeek> workingDays)
        {
            foreach (var day in days)
            {
                if (!workingDays.Contains(day.Date.DayOfWeek))
                {
                    foreach (var timeSlot in day.TimeSlots)
                    {
                        timeSlot.IsAvailable = false;
                    }
                }
            }
        }

        private static DayCalendarDto[] FilterDaysWithMedicalCalendar(CalendarCriteriaDto criteria, DayCalendarDto[] days)
        {
            if (criteria.FilterDaysAndTimesWithAppointments)
            {
                return days.Select(day => new DayCalendarDto
                {

                    Date = day.Date,
                    TimeSlots = day.TimeSlots.Where(slot => slot.MedicalCalendar != null).ToArray()
                }).Where(day => day.TimeSlots.Length > 0)
                .ToArray();
            }
            return days;
        }
        private static DayCalendarDto[] FilterDaysByDate(CalendarCriteriaDto criteria, DayCalendarDto[] days)
        {
            if (criteria.FilterByDate.HasValue)
            {
                return days.Where(day => day.Date.Date == criteria.FilterByDate.Value.Date).ToArray();
            }
            return days;
        }

        private static DayCalendarDto[] FilterByWorkingDays(Medical medical, DayCalendarDto[] days)
        {
            return days.Where(day => medical.WorkingDays.Contains(day.Date.DayOfWeek)).ToArray();
        }

        #endregion PRIVATE  GetMonthlyCalendar

        public async Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria)
        {
            var response = new ServiceResponse<CalendarDto>();
            try
            {
                criteria.UserIdLogged = UserId;

                var medical = await GetMedicalAsync(criteria.MedicalId);
                var user = await GetUserAsync(UserId);

                var (startDate, endDate) = GetDateRange(criteria.Year, criteria.Month);
                var interval = TimeSpan.FromMinutes(medical.PatientIntervalTimeMinutes);
                var medicalCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(criteria.MedicalId, startDate, endDate);

                var criteriaDays = CreateDaysCalendarCriteria(user, medical, startDate, endDate, interval, medicalCalendars);
                var days = GenerateDaysCalendar(criteriaDays);

                //Filters
                var filteredDays = FilterIsTimeSlotAvailable(startDate, endDate, days);

                if (criteria.FilterDaysAndTimesWithAppointments)
                {
                    filteredDays = FilterByWorkingDays(medical, filteredDays);
                }

                // Mark non-working days as unavailable
                FillMarkNonWorkingDays(filteredDays, medical.WorkingDays);

                filteredDays = OrdenateDays(filteredDays);

                response.Data = CreateCalendarDto(medical, filteredDays);
                response.Success = true;
                response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.CalendarSuccess, MedicalCalendarMenssageConstants.CalendarSuccess);

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.GetAvailableMedicalCalendar");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }

            return response;
        }

        #region PRIVATE GetAvailableTimeSlotsAsync
        private DayCalendarDto[] FilterIsTimeSlotAvailable(DateTime startTime, DateTime endTime, DayCalendarDto[] daysCalendar)
        {
            var dateCurrent = DateHelper.GetDateTimeNowFromUtc();
            var filteredDays = daysCalendar
                .Select(day => new DayCalendarDto
                {
                    Date = day.Date,
                    TimeSlots = day.TimeSlots
                        .Where(slot => !slot.IsPast && slot.IsAvailable && slot.StartTime >= dateCurrent && slot.MedicalCalendar == null && slot.StartTime >= startTime && slot.EndTime <= endTime)
                        .ToArray()
                })
                .Where(day => day.TimeSlots.Any())
                .ToArray();

            return filteredDays;
        }
        #endregion  PRIVATE GetAvailableTimeSlotsAsync

        public async Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                // Validate criteria
                var validationResult = await _validators.ScheduleCriteriaDtoValidator.ValidateAsync(criteria);
                if (!validationResult.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Message = validationResult.Errors.First().ErrorMessage;
                    return response;
                }
                if (criteria.ScheduleType == EScheduleCalendarType.Schedule)
                {
                    response = await ScheduleAppointmentAsync(criteria);
                }
                else if (criteria.ScheduleType == EScheduleCalendarType.Cancellation)
                {
                    // Check if the appointment exists
                    var appointment = await _entityRepository.GetAppointmentAsync(criteria.MedicalId, criteria.AppointmentDateTime, criteria.PatientId);
                    if (appointment == null)
                    {
                        response.Success = false;
                        response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);

                        return response;
                    }
                    response = await CancelAppointmentAsync(criteria);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.RequestAppointment");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }

            return response;
        }

        #region PRIVATE RequestAppointmentAsync
        private async Task<ServiceResponse<bool>> ScheduleAppointmentAsync(ScheduleCriteriaDto criteria)
        {
            var response = new ServiceResponse<bool>();
            if (criteria.ScheduleType == EScheduleCalendarType.Schedule)
            {
                criteria.UserIdLogged = UserId;

                var medical = await GetMedicalAsync(criteria.MedicalId);

                // Create a new appointment with status Pending
                var newAppointment = new MedicalCalendar
                {
                    Title = criteria.Reason,
                    Description = criteria.Reason,
                    RecurrenceType = ERecurrenceCalendarType.None,
                    TimeZone = criteria.TimeZone,
                    StartDateTime = criteria.AppointmentDateTime,
                    EndDateTime = criteria.AppointmentDateTime.AddMinutes(medical.PatientIntervalTimeMinutes),
                    Enable = true,
                    Status = EStatusCalendar.PendingConfirmation,
                };
                #region Relationship
                newAppointment.CreatedUserId = criteria.UserIdLogged;
                newAppointment.PatientId = criteria.PatientId;
                newAppointment.MedicalId = criteria.MedicalId;
                #endregion Relationship 
                newAppointment.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                newAppointment.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                newAppointment.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                var resultCreate = await _entityRepository.Create(newAppointment);

                response.Success = true;
                response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.Schedule_Appointment_Success, MedicalCalendarMenssageConstants.Schedule_Appointment_Success) + $". ({resultCreate.Id})";
            }
            return response;
        }
        private async Task<ServiceResponse<bool>> CancelAppointmentAsync(ScheduleCriteriaDto criteria)
        {
            var response = new ServiceResponse<bool>();

            // Check if the appointment exists
            var appointment = await _entityRepository.GetAppointmentAsync(criteria.MedicalId, criteria.AppointmentDateTime, criteria.PatientId);
            if (appointment == null)
            {
                response.Success = false;
                response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                return response;
            }
            //Se o status tiver sido confirmado nao pode cancelar deve mudar para cancelamento pendente se o status for PendingConfirmation pode cancelar a solicitacao 
            if (appointment.Status == EStatusCalendar.PendingConfirmation)
            {
                appointment.Status = EStatusCalendar.Canceled;
            }
            if (appointment.Status == EStatusCalendar.Confirmed)
            {
                appointment.Status = EStatusCalendar.PendingCancellation;
            }
            // Change the status to Canceled       
            appointment.ReasonCancellation = criteria.Reason;

            var resultCreate = await _entityRepository.Update(appointment);

            response.Success = true; 
            response.Message = await base.GetLocalization(MedicalCalendarKeyConstants.Cancel_Appointment_Success, MedicalCalendarMenssageConstants.Cancel_Appointment_Success) + $". ({resultCreate.Id})";


            return response;
        }
        #endregion PRIVATE RequestAppointmentAsync

        public async Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria)
        {
            var response = new ServiceResponse<AppointmentDto[]>();
            try
            {
                // Validate criteria
                var validationResult = await _validators.AppointmentCriteriaDtoValidator.ValidateAsync(criteria);
                if (!validationResult.IsValid)
                {
                    response.Success = false;
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Message = validationResult.Errors.First().ErrorMessage;
                    return response;
                }
                // Define the start and end dates for the month
                var (startDate, endDate) = GetDateRange(criteria.Year, criteria.Month);

                // Retrieve appointments for the specified period
                var appointments = await _entityRepository.GetAppointmentsForMonthAsync(criteria.MedicalId, criteria.PatientId, startDate, endDate);

                if (appointments.Length == 0)
                {
                    response.Success = false;
                    response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    return response;
                }
                // Map the appointments to the DTO
                var appointmentDtos = _mapper.Map<AppointmentDto[]>(appointments);

                var currentTime = DateHelper.ApplyTimeZone(DateHelper.GetDateTimeNowFromUtc(), appointments[0].TimeZone);

                foreach (var item in appointmentDtos)
                {
                    item.IsPast = item.StartDateTime <= currentTime;
                }
                var filteredAppointmentDtos = appointmentDtos.OrderBy(x => x.StartDateTime).ToArray();
                response.Success = true;
                response.Data = filteredAppointmentDtos;
                response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at MedicalCalendarService.GetAppointments");
                response.Success = false;
                response.Message = await base.GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
            }

            return response;
        }
    }
}