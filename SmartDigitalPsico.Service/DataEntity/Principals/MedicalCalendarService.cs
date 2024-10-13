using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Contracts;
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
            DateTime currentStart = medicalCalendar.StartDateTime;
            DateTime currentEnd = medicalCalendar.EndDateTime.GetValueOrDefault();
            int count = 0;

            if (updateSeries)
            {
                var existingEvents = await _entityRepository.GetByMedicalCalendarAsync(medicalCalendar);
                await _entityRepository.DeleteRangeAsync(existingEvents);
            }

            while ((medicalCalendar.RecurrenceEndDate == null || currentStart <= medicalCalendar.RecurrenceEndDate) &&
                   (medicalCalendar.RecurrenceCount == null || count < medicalCalendar.RecurrenceCount))
            {
                var newEvent = new MedicalCalendar
                {
                    Title = medicalCalendar.Title,
                    Description = medicalCalendar.Description,
                    StartDateTime = currentStart,
                    EndDateTime = currentEnd,
                    Location = medicalCalendar.Location,
                    IsAllDay = medicalCalendar.IsAllDay,
                    RecurrenceDays = medicalCalendar.RecurrenceDays,
                    RecurrenceType = medicalCalendar.RecurrenceType,
                    TimeZone = medicalCalendar.TimeZone
                };

                events.Add(newEvent);

                switch (medicalCalendar.RecurrenceType)
                {
                    case ERecurrenceCalendarType.Daily:
                        currentStart = currentStart.AddDays(1);
                        currentEnd = currentEnd.AddDays(1);
                        break;
                    case ERecurrenceCalendarType.Weekly:
                        currentStart = currentStart.AddDays(7);
                        currentEnd = currentEnd.AddDays(7);
                        break;
                    case ERecurrenceCalendarType.Monthly:
                        currentStart = currentStart.AddMonths(1);
                        currentEnd = currentEnd.AddMonths(1);
                        break;
                    case ERecurrenceCalendarType.Yearl:
                        currentStart = currentStart.AddYears(1);
                        currentEnd = currentEnd.AddYears(1);
                        break;
                }

                count++;
            }
            await _entityRepository.AddRangeAsync(events);
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
            response.Data = CreateScheduleDto(medical, days);
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
            var medicalCalendarsDTO = medicalCalendars.Select(_mapper.Map<GetMedicalCalendarDto>).ToArray();

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
        private static ScheduleDto CreateScheduleDto(Medical medical, IEnumerable<DayScheduleDto> days)
        {
            return new ScheduleDto
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = days.ToArray()
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
        private static List<DayScheduleDto> GenerateDaysCalendar(DaysCalendarCriteriaDto criteria)
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
            return days;
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
                    PatientName = medicalCalendar?.Patient?.Name ?? string.Empty,
                });
            }
            return timeSlots.ToArray();
        }
        #endregion PRIVATE  GetMonthlyCalendar
    }
}