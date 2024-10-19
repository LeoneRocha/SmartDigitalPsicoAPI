using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.DTO;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class MedicalCalendarValidators : IMedicalCalendarValidators
    {
        public IValidator<MedicalCalendar> EntityValidator { get; }
        public IValidator<AppointmentCriteriaDto> AppointmentCriteriaDtoValidator { get; }
        public IValidator<RecordsList<MedicalCalendar>> MedicalCalendarListValidator { get; }
        public IValidator<ScheduleCriteriaDto> ScheduleCriteriaDtoValidator { get; }
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