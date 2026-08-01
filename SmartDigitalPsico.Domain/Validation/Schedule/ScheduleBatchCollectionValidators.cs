using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Validation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleBatchCollectionValidators : IScheduleBatchCollectionValidators
    {
        public IValidator<ScheduleBatch> ScheduleBatchValidator { get; }
        public IValidator<ScheduleItem> ScheduleItemValidator { get; }
        public IValidator<ScheduleBatch> ScheduleBatchRangeValidator { get; }
        public IValidator<ScheduleItemValidationContext> ScheduleItemValidationContextValidator { get; }
        public IValidator<ScheduleMedicalCalendarCriteriaDto> ScheduleMedicalCalendarCriteriaDtoValidator { get; }  

        public ScheduleBatchCollectionValidators(
            IConfiguration configuration,
            IScheduleBatchRepository entityRepository,
            IMedicalRepository medicalRepository,
            IUserRepository userRepository,
            IValidator<ScheduleMedicalCalendarCriteriaDto> scheduleBatchCalendarDtoValidator)  
        {
            ScheduleBatchValidator = new ScheduleBatchValidator(configuration, entityRepository, medicalRepository, userRepository);
            ScheduleItemValidator = new ScheduleItemValidator(medicalRepository);
            ScheduleBatchRangeValidator = new ScheduleBatchRangeValidator(entityRepository);
            ScheduleItemValidationContextValidator = new ScheduleItemValidationContextValidator();
            ScheduleMedicalCalendarCriteriaDtoValidator = scheduleBatchCalendarDtoValidator; // Atribuição

        }
    }
}
