using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainValidation
    {
        public static void AddDependencies(IServiceCollection services)
        {
            // MedicalCalendarRangeValidator is constructed for SoT conflict checks;
            // exclude so it does not compete with MedicalCalendarValidator as IValidator<MedicalCalendar>.
            services.AddValidatorsFromAssemblyContaining<AppointmentCriteriaDtoValidator>(
                lifetime: ServiceLifetime.Scoped,
                filter: result => result.ValidatorType != typeof(MedicalCalendarRangeValidator));
        }
    }
}
