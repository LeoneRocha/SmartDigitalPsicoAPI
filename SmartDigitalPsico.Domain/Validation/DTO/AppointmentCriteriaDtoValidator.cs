using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Validation.DTO
{
    public class AppointmentCriteriaDtoValidator : AbstractValidator<AppointmentCriteriaDto>
    {
        private readonly IPatientRepository _patientRepository;
        public AppointmentCriteriaDtoValidator(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;

            RuleFor(x => x.MedicalId)
                .GreaterThan(0)
                .WithErrorCode("SmartDigitalPsico.AppointmentCriteriaDtoValidator.AppointmentCriteriaDto.MedicalId.GreaterThan")
                .WithMessage("MedicalId_Validator_GreaterThan_Key|Medical ID must be greater than {0}.|0");

            RuleFor(x => x.PatientId)
                .GreaterThan(0)
                .WithErrorCode("SmartDigitalPsico.AppointmentCriteriaDtoValidator.AppointmentCriteriaDto.PatientId.GreaterThan")
                .WithMessage("PatientId_Validator_GreaterThan_Key|Patient ID must be greater than {0}.|0");

            RuleFor(x => x.Year)
                .InclusiveBetween(2000, 2100)
                .WithErrorCode("SmartDigitalPsico.AppointmentCriteriaDtoValidator.AppointmentCriteriaDto.Year.InclusiveBetween")
                .WithMessage("Year_Validator_InclusiveBetween_Key|Year must be between {0} and {1}.|2000|2100");

            RuleFor(x => x.Month)
                .InclusiveBetween(1, 12)
                .WithErrorCode("SmartDigitalPsico.AppointmentCriteriaDtoValidator.AppointmentCriteriaDto.Month.InclusiveBetween")
                .WithMessage("Month_Validator_InclusiveBetween_Key|Month must be between {0} and {1}.|1|12");

            RuleFor(x => x)
                .MustAsync(BeAValidPatientOfMedical)
                .WithErrorCode("SmartDigitalPsico.AppointmentCriteriaDtoValidator.AppointmentCriteriaDto.Entity.Must")
                .WithMessage("Patient_Validator_BelongToDoctor_Key|The patient does not belong to the specified doctor.");
        }

        private async Task<bool> BeAValidPatientOfMedical(AppointmentCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var beValid = (await _patientRepository.FindByCustomWhere(p => p.MedicalId == criteria.MedicalId && p.Id == criteria.PatientId)).Count > 0;

            return beValid;
        }
    }
}
