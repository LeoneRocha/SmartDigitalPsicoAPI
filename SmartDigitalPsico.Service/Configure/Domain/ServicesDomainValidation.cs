using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Validation;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainValidation
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<AppointmentCriteriaDtoValidator>();
            
            // Register the ScheduleBatchCollectionValidators
            services.AddScoped<IScheduleBatchCollectionValidators, ScheduleBatchCollectionValidators>();
             
        }
    }
}
