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

            RuleFor(x => x.MedicalId).GreaterThan(0);
            RuleFor(x => x.PatientId).GreaterThan(0);
            RuleFor(x => x.Year).InclusiveBetween(2000, 2100);
            RuleFor(x => x.Month).InclusiveBetween(1, 12);

            RuleFor(x => x).MustAsync(BeAValidPatientOfMedical)
                .WithMessage("The patient does not belong to the specified doctor.");
        }

        private async Task<bool> BeAValidPatientOfMedical(AppointmentCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var beValid = (await _patientRepository.FindByCustomWhere(p => p.MedicalId == criteria.MedicalId && p.Id == criteria.PatientId)).Count > 0;

            return beValid;
        }
    }
}
