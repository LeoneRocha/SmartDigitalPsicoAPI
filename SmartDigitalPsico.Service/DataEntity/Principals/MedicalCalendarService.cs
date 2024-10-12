using FluentValidation;
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
        private readonly IUserRepository _userRepository; 

        public MedicalCalendarService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IValidator<MedicalCalendar> entityValidator,
            IMedicalCalendarRepository entityRepository
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        { 
            _userRepository = sharedRepositories.UserRepository; 
        }
        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
        { 
            var entityAdd = _mapper.Map<MedicalCalendar>(item); ;
             
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
                    response.Message = "Calendar registred.";
                }
                else
                {
                    MedicalCalendar entityResponse = await _entityRepository.Create(entityAdd);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                    response.Message = "Calendar registred.";
                }  
            }
            return response; 
        }

        public override async Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
        {
            var entityAdd = _mapper.Map<MedicalCalendar>(item); ;

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
                    response.Message = "Calendar registred.";
                }
                else
                {
                    MedicalCalendar entityResponse = await _entityRepository.Update(entityAdd);
                    response.Data = _mapper.Map<GetMedicalCalendarDto>(entityResponse);
                    response.Message = "Calendar registred.";
                }
            }
            return response;
        }
         
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
    }
}