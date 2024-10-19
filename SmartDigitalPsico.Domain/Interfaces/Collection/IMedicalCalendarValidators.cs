using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.DTO;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface IMedicalCalendarValidators
    {
        IValidator<MedicalCalendar> EntityValidator { get; }
        IValidator<AppointmentCriteriaDto> AppointmentCriteriaDtoValidator { get; }
        IValidator<RecordsList<MedicalCalendar>> MedicalCalendarListValidator { get; }
        IValidator<ScheduleCriteriaDto> ScheduleCriteriaDtoValidator { get; }
    }
}