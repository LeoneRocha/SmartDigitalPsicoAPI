using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class MedicalCalendarService : EntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto, IMedicalCalendarRepository>, IMedicalCalendarService

    {
        private const string MensageCalendarRegistred = "Calendar registred.";
        private const string MensageCalendarUpdated = "Calendar Updated.";

        private readonly IMedicalRepository _medicalRepository;

        public MedicalCalendarService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IValidator<MedicalCalendar> entityValidator,
            IMedicalCalendarRepository entityRepository,
            IPatientRepositories repositoriesShared
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _medicalRepository = repositoriesShared.MedicalRepository;
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

        #region PRIVATE 

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
        #endregion PRIVATE 

        public async Task<ScheduleDto> GetMonthlySchedule(ScheduleCriteriaDto criteria)
        {
            var medical = await GetMedicalAsync(criteria.MedicalId);

            var (startDate, endDate) = GetDateRange(criteria.Year, criteria.Month);

            var interval = TimeSpan.FromMinutes(criteria.IntervalInMinutes);

            var medicalCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(criteria.MedicalId, startDate, endDate);

            var medicalCalendarsDTO = medicalCalendars.Select(_mapper.Map<GetMedicalCalendarDto>).ToArray();

            var days = GenerateDaysSchedule(startDate, endDate, interval, medicalCalendarsDTO);

            var resultDto = new ScheduleDto()
            {
                MedicalId = medical.Id,
                MedicalName = medical.Name,
                Days = days.ToArray()
            };

            return resultDto;
        }
        #region PRIVATE 

        private async Task<Medical> GetMedicalAsync(long medicalId)
        {
            var medical = await _medicalRepository.FindByID(medicalId);
            if (medical == null)
            {
                throw new Exception("Medical not found.");
            }
            return medical;
        }

        private static (DateTime startDate, DateTime endDate) GetDateRange(int year, int month)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            return (startDate, endDate);
        }

        private static List<DayScheduleDto> GenerateDaysSchedule(DateTime startDate, DateTime endDate, TimeSpan interval, GetMedicalCalendarDto[] medicalCalendarsDTO)
        {
            var days = new List<DayScheduleDto>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var timeSlots = GenerateTimeSlots(date, interval, medicalCalendarsDTO);
                days.Add(new DayScheduleDto { Date = date, TimeSlots = timeSlots });
            }
            return days;
        }

        private static TimeSlotDto[] GenerateTimeSlots(DateTime date, TimeSpan interval, GetMedicalCalendarDto[] medicalCalendars)
        {
            var timeSlots = new List<TimeSlotDto>();
            for (var time = date; time < date.AddDays(1); time = time.Add(interval))
            {
                var endTime = time.Add(interval);
                var medicalCalendar = medicalCalendars.FirstOrDefault(a => a.StartDateTime <= time && a.EndDateTime >= endTime);

                timeSlots.Add(new TimeSlotDto
                {
                    StartTime = time,
                    EndTime = endTime,
                    IsAvailable = medicalCalendar == null,
                    MedicalCalendar = medicalCalendar,
                    PatientName = medicalCalendar?.Patient?.Name ?? string.Empty,
                });
            }
            return timeSlots.ToArray();
        }
        #endregion PRIVATE 
    }
}