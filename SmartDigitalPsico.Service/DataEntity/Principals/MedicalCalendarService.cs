using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.AppException;
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
                    await GenerateRecurrenceAsync(entityAdd, false);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityAdd);
                    response.Message = MensageCalendarRegistred;
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
            var entityAdd = _mapper.Map<MedicalCalendar>(item);
            entityAdd.Enable = item.Enable;

            #region Relationship
            entityAdd.ModifyUserId = UserId;
            #endregion Relationship 

            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetMedicalCalendarDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                if (entityAdd.RecurrenceType != ERecurrenceCalendarType.None)
                {
                    await GenerateRecurrenceAsync(entityAdd, false);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityAdd);
                    response.Message = MensageCalendarUpdated;
                }
                else
                {
                    MedicalCalendar entityResponse = await _entityRepository.Update(entityAdd);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                    response.Message = MensageCalendarUpdated;
                }
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
                Status = medicalCalendar.Status
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

        public async Task<ServiceResponse<ScheduleDto>> GetMonthlyCalendar(ScheduleCriteriaDto criteria)
        {
            var response = new ServiceResponse<ScheduleDto>();
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

            response.Data = CreateScheduleDto(medical, filteredDays);
            response.Success = true;
            response.Message = MensageCalendarSuccess;

            return response;
        }

        #region PRIVATE  GetMonthlyCalendar
        private async Task<bool> ValidateCriteriaAsync(ScheduleCriteriaDto criteria, ServiceResponse<ScheduleDto> response)
        {
            var validator = new ScheduleCriteriaValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(criteria);

            if (!validationResult.IsValid)
            {
                ReturnEmptyResult(new Medical(), response, validationResult);
                return false;
            }

            return true;
        }

        private async Task<bool> ValidateMedicalCalendarsAsync(IEnumerable<MedicalCalendar> medicalCalendars, ServiceResponse<ScheduleDto> response)
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
        private static ScheduleDto CreateScheduleDto(Medical medical, DayScheduleDto[] days)
        {
            return new ScheduleDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = days
            };
        }
        private static void ReturnEmptyResult(Medical medical, ServiceResponse<ScheduleDto> response, ValidationResult validationResult)
        {
            var sDto = new ScheduleDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = Array.Empty<DayScheduleDto>()
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
        private static DayScheduleDto[] GenerateDaysCalendar(DaysCalendarCriteriaDto criteria)
        {
            var days = new List<DayScheduleDto>();
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

                var timeSlots = GenerateTimeSlots(timeSlotCriteria);
                days.Add(new DayScheduleDto { Date = date, TimeSlots = timeSlots });
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
                    MedicalCalendar = medicalCalendar,
                    PatientName = medicalCalendar?.PatientName ?? string.Empty,
                });
            }
            return timeSlots.ToArray();
        }

        private static DayScheduleDto[] FilterDaysWithMedicalCalendar(ScheduleCriteriaDto criteria, DayScheduleDto[] days)
        {
            if (criteria.FilterDaysAndTimesWithAppointments)
            {
                return days.Select(day => new DayScheduleDto
                {
                    Date = day.Date,
                    TimeSlots = day.TimeSlots.Where(slot => slot.MedicalCalendar != null).ToArray()
                }).Where(day => day.TimeSlots.Length > 0)
                .ToArray();
            }
            return days;
        }
        private static DayScheduleDto[] FilterDaysByDate(ScheduleCriteriaDto criteria, DayScheduleDto[] days)
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