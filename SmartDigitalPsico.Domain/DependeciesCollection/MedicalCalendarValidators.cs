using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por MedicalCalendarValidators.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class MedicalCalendarValidators : IMedicalCalendarValidators
    {
        public IValidator<MedicalCalendar> EntityValidator { get; }
        public IValidator<AppointmentCriteriaDto> AppointmentCriteriaDtoValidator { get; }
        public IValidator<RecordsList<MedicalCalendar>> MedicalCalendarListValidator { get; }
        public IValidator<ScheduleCriteriaDto> ScheduleCriteriaDtoValidator { get; }
        /// <summary>
        /// Método MedicalCalendarValidators: executa a operação MedicalCalendarValidators.
        /// </summary>
        public MedicalCalendarValidators(
            IValidator<MedicalCalendar> entityValidator,
            IValidator<AppointmentCriteriaDto> appointmentCriteriaDtoValidator,
            IValidator<RecordsList<MedicalCalendar>> medicalCalendarListValidator,
            IValidator<ScheduleCriteriaDto> scheduleCriteriaDtoValidator
            )
        {
            EntityValidator = entityValidator;
            AppointmentCriteriaDtoValidator = appointmentCriteriaDtoValidator;
            MedicalCalendarListValidator = medicalCalendarListValidator;
            ScheduleCriteriaDtoValidator = scheduleCriteriaDtoValidator;
        }
    }
}
