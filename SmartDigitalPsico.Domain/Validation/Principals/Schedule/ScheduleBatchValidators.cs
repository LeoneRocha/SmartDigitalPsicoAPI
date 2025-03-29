using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Validation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleBatchValidators : IScheduleBatchValidators
    {
        public IValidator<ScheduleBatch> EntityValidator { get; }
        public IValidator<ScheduleItem> ScheduleItemValidator { get; }
        public IValidator<ScheduleBatch> ScheduleBatchRangeValidator { get; }

        public ScheduleBatchValidators(
            IConfiguration configuration,
            IScheduleBatchRepository entityRepository,
            IMedicalRepository medicalRepository,
            IUserRepository userRepository)
        {
            EntityValidator = new ScheduleBatchValidator(configuration, entityRepository, medicalRepository, userRepository);
            ScheduleItemValidator = new ScheduleItemValidator();
            ScheduleBatchRangeValidator = new ScheduleBatchRangeValidator(entityRepository);
        }
    }
}
