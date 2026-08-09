using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Validation;

namespace SmartDigitalPsico.Service
{
                                    /// <summary>
    /// Classe responsável por ServicesDomainValidation.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainValidation
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            // MedicalCalendarRangeValidator is constructed for SoT conflict checks;
            // exclude so it does not compete with MedicalCalendarValidator as IValidator<MedicalCalendar>.
            services.AddValidatorsFromAssemblyContaining<PatientAppointmentCriteriaDtoValidator>(
                lifetime: ServiceLifetime.Scoped,
                filter: result => result.ValidatorType != typeof(MedicalCalendarRangeValidator));
        }
    }
}
