using Azure;
using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class MedicalCalendarService : EntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto, IMedicalCalendarRepository>, IMedicalCalendarService
    {
        private const string MensageCalendarRegistred = "Calendar registred.";
        private const string MensageCalendarUpdated = "Calendar Updated.";
        private const string MensageCalendarSuccess = "Calendar Success.";
        private readonly IMedicalRepository _medicalRepository;
        private readonly IUserRepository _userRepository;

        public MedicalCalendarService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IValidator<MedicalCalendar> entityValidator,
            IMedicalCalendarRepository entityRepository,
            IPatientRepositories repositoriesShared
            )
            : base(sharedServices, sharedDependenciesConfig, repositoriesShared.SharedRepositories, entityRepository, entityValidator)
        {
            _medicalRepository = repositoriesShared.MedicalRepository;
            _userRepository = repositoriesShared.SharedRepositories.UserRepository;
        }
        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
        {
            var entityAdd = _mapper.Map<MedicalCalendar>(item);
            entityAdd.Enable = true;
            #region Relationship
            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;
            entityAdd.MedicalId = item.MedicalId;
            #endregion Relationship

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetMedicalCalendarDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                if (entityAdd.RecurrenceType != ERecurrenceCalendarType.None)
                {
                    try
                    {
                        entityAdd.TokenRecurrence = Guid.NewGuid().ToString();
                        await GenerateRecurrenceAsync(entityAdd, false);
                        response.Data = _mapper.Map<GetMedicalCalendarDto>(entityAdd);
                        response.Message = MensageCalendarRegistred;
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
                    response.Message = MensageCalendarRegistred;
                }
            }
            return response;
        }

        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
        {
            var entityUpdate = _mapper.Map<MedicalCalendar>(item);
            entityUpdate.Enable = item.Enable;

            #region Relationship
            entityUpdate.ModifyUserId = UserId;
            #endregion Relationship 

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetMedicalCalendarDto> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                if (entityUpdate.RecurrenceType != ERecurrenceCalendarType.None && item.UpdateSeries)
                {
                    try
                    {
                        await GenerateRecurrenceAsync(entityUpdate, item.UpdateSeries);
                        response.Data = _mapper.Map<GetMedicalCalendarDto>(entityUpdate);
                        response.Message = MensageCalendarUpdated;
                    }
                    catch (Exception ex)
                    {
                        response.Message = ex.Message;
                        response.Success = false;
                    }
                }
                else
                {
                    MedicalCalendar entityResponse = await _entityRepository.Update(entityUpdate);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                    response.Message = MensageCalendarUpdated;
                }
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> DeleteOneOrRecurrenceAsync(DeleteMedicalCalendarDto request)
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

        private async Task<ServiceResponse<bool>> DeleteSeries(DeleteMedicalCalendarDto request)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            var calendars = await _entityRepository.GetByTokenAsync(request.TokenRecurrence, request.MedicalId, request.PatientId);

            if (calendars.Length < 1)
            {
                response.Success = false;
                response.Message = "No schedules found for the given criteria.";
                return response;
            }
            var recordsList = new RecordsList<MedicalCalendar>
            {
                UserIdLogged = UserId,
                Records = calendars.ToList()
            };

            var validator = new MedicalCalendarListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (validationResult.IsValid)
            {
                await _entityRepository.DeleteRangeAsync(calendars);

                response.Data = true;
                response.Success = true;
                response.Message = "Schedules deleted successfully.";
            }
            else
            {
                response.Errors = HelperValidation.GetMapErros(validationResult.Errors);
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        private async Task<ServiceResponse<bool>> DeleteOne(DeleteMedicalCalendarDto request)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            var calendar = await _entityRepository.FindByID(request.Id);

            var recordsList = new RecordsList<MedicalCalendar>
            {
                UserIdLogged = UserId,
                Records = new List<MedicalCalendar>() { calendar }
            };

            var validator = new MedicalCalendarListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (validationResult.IsValid)
            {
                response = await base.Delete(request.Id);
            }
            else
            {
                response.Errors = HelperValidation.GetMapErros(validationResult.Errors);
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }


        #region PRIVATE   Create/Update
        private async Task GenerateRecurrenceAsync(MedicalCalendar medicalCalendar, bool updateSeries)
        {
            var events = new List<MedicalCalendar>();
            var validator = new MedicalCalendarRangeValidator(_entityRepository);
            var count = new RefDto<int>(0);

            if (updateSeries)
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
                await AddEventAsync(medicalCalendar, events, validator, count, currentStart, currentEnd);
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

                    await AddEventAsync(medicalCalendar, events, validator, count, nextDate, nextDate.Add(currentEnd - currentStart));
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

        public async Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
        {
            var response = new ServiceResponse<CalendarDto>();
            criteria.UserIdLogged = UserId;

            if (!await ValidateCriteriaAsync(criteria, response))
            {
                return response;
            }

            var medical = await GetMedicalAsync(criteria.MedicalId);
            var (startDate, endDate) = GetDateRange(criteria.Year, criteria.Month);
            var interval = TimeSpan.FromMinutes(criteria.IntervalInMinutes);
            var medicalCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(criteria.MedicalId, startDate, endDate);

            if (!await ValidateMedicalCalendarsAsync(medicalCalendars, response))
            {
                return response;
            }

            var days = GenerateDaysCalendar(CreateDaysCalendarCriteria(medical, startDate, endDate, interval, medicalCalendars));

            //Filters
            var filteredDays = FilterDaysWithMedicalCalendar(criteria, days);
            filteredDays = FilterDaysByDate(criteria, filteredDays);

            filteredDays = OrdenateDays(filteredDays);

            response.Data = CreateCalendarDto(medical, filteredDays);
            response.Success = true;
            response.Message = MensageCalendarSuccess;

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
                ReturnEmptyResult(new Medical(), response, validationResult);
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
                ReturnEmptyResult(new Medical(), response, validationResult);
                return false;
            }

            return true;
        }
        private DaysCalendarCriteriaDto CreateDaysCalendarCriteria(Medical medical, DateTime startDate, DateTime endDate, TimeSpan interval, IEnumerable<MedicalCalendar> medicalCalendars)
        {
            var medicalCalendarsDTO = medicalCalendars.Select(_mapper.Map<GetMedicalCalendarTimeSlotDto>).ToArray();

            return new DaysCalendarCriteriaDto
            {
                StartDate = startDate,
                EndDate = endDate,
                Interval = interval,
                MedicalCalendars = medicalCalendarsDTO,
                StartWorkingTime = medical.StartWorkingTime,
                EndWorkingTime = medical.EndWorkingTime
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
        private static void ReturnEmptyResult(Medical medical, ServiceResponse<CalendarDto> response, ValidationResult validationResult)
        {
            var sDto = new CalendarDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = Array.Empty<DayCalendarDto>()
            };
            response.Success = false;
            response.Data = sDto;
            response.Message = MensageCalendarSuccess;
            response.Errors = HelperValidation.GetMapErros(validationResult.Errors);
        }
        private async Task<Medical> GetMedicalAsync(long medicalId)
        {
            var medical = await _medicalRepository.FindByID(medicalId);
            if (medical == null)
            {
                throw new AppWarningException("Medical not found.");
            }
            return medical;
        }
        private static (DateTime startDate, DateTime endDate) GetDateRange(int year, int month)
        {
            var startDate = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            return (startDate, endDate);
        }
        private static DayCalendarDto[] GenerateDaysCalendar(DaysCalendarCriteriaDto criteria)
        {
            var days = new List<DayCalendarDto>();
            for (var date = criteria.StartDate; date <= criteria.EndDate; date = date.AddDays(1))
            {
                var timeSlotCriteria = new TimeSlotCriteriaDto
                {
                    Date = date,
                    Interval = criteria.Interval,
                    MedicalCalendars = criteria.MedicalCalendars,
                    StartWorkingTime = criteria.StartWorkingTime,
                    EndWorkingTime = criteria.EndWorkingTime
                };

                var timeSlots = GenerateTimeSlots(timeSlotCriteria).OrderBy(x => x.StartTime).ToArray();
                days.Add(new DayCalendarDto { Date = date, TimeSlots = timeSlots });
            }
            return days.ToArray();
        }
        private static TimeSlotDto[] GenerateTimeSlots(TimeSlotCriteriaDto criteria)
        {
            var timeSlots = new List<TimeSlotDto>();
            var startDateTime = criteria.Date.Add(criteria.StartWorkingTime);
            var endDateTime = criteria.Date.Add(criteria.EndWorkingTime);

            for (var time = criteria.Date; time < criteria.Date.AddDays(1); time = time.Add(criteria.Interval))
            {
                var endTimeSlot = time.Add(criteria.Interval);
                var medicalCalendar = criteria.MedicalCalendars.ToList().Find(a => a.StartDateTime <= time && a.EndDateTime >= endTimeSlot);

                var isWithinWorkingHours = time >= startDateTime && endTimeSlot <= endDateTime;

                timeSlots.Add(new TimeSlotDto
                {
                    StartTime = time,
                    EndTime = endTimeSlot,
                    IsAvailable = medicalCalendar == null && isWithinWorkingHours,
                    IsPast = time <= DataHelper.GetDateTimeNow(),
                    MedicalCalendar = medicalCalendar
                });
            }
            return timeSlots.ToArray();
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


        #endregion PRIVATE  GetMonthlyCalendar
    }
}