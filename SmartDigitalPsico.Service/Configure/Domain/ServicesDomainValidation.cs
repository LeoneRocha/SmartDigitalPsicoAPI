using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Validation;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainValidation
    {
        public static void AddDependencies(IServiceCollection services)
        {
            // MedicalCalendarRangeValidator is constructed manually (SoT or obsolete MC repo);
            // exclude so it does not compete with MedicalCalendarValidator as IValidator<MedicalCalendar>.
            services.AddValidatorsFromAssemblyContaining<AppointmentCriteriaDtoValidator>(
                lifetime: ServiceLifetime.Scoped,
                filter: result => result.ValidatorType != typeof(MedicalCalendarRangeValidator));

            // Register the ScheduleBatchCollectionValidators
            services.AddScoped<IScheduleBatchCollectionValidators, ScheduleBatchCollectionValidators>();
        }
    }
}
