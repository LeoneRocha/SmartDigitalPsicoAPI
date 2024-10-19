using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Validation.DTO;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainValidation
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<AppointmentCriteriaDtoValidator>();
        }
    }
}
