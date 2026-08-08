using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalCalendarValidators.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IMedicalCalendarValidators
    {
        IValidator<MedicalCalendar> EntityValidator { get; }
        IValidator<AppointmentCriteriaDto> AppointmentCriteriaDtoValidator { get; }
        IValidator<RecordsList<MedicalCalendar>> MedicalCalendarListValidator { get; }
        IValidator<ScheduleCriteriaDto> ScheduleCriteriaDtoValidator { get; }
    }
}
