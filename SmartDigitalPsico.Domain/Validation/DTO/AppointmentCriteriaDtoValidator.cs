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
                .WithMessage("MedicalId_Validator_GreaterThan_Key|Medical ID must be greater than {0}.|0");

            RuleFor(x => x.PatientId)
                .GreaterThan(0)
                .WithMessage("PatientId_Validator_GreaterThan_Key|Patient ID must be greater than {0}.|0");

            RuleFor(x => x.Year)
                .InclusiveBetween(2000, 2100)
                .WithMessage("Year_Validator_InclusiveBetween_Key|Year must be between {0} and {1}.|2000|2100");

            RuleFor(x => x.Month)
                .InclusiveBetween(1, 12)
                .WithMessage("Month_Validator_InclusiveBetween_Key|Month must be between {0} and {1}.|1|12");

            RuleFor(x => x)
                .MustAsync(BeAValidPatientOfMedical)
                .WithMessage("Patient_Validator_BelongToDoctor_Key|The patient does not belong to the specified doctor.");
        }

        private async Task<bool> BeAValidPatientOfMedical(AppointmentCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var beValid = (await _patientRepository.FindByCustomWhere(p => p.MedicalId == criteria.MedicalId && p.Id == criteria.PatientId)).Count > 0;

            return beValid;
        }
    }
}
