using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientMedicationInformationValidator : AbstractValidator<PatientMedicationInformation>
    {
        private readonly IPatientMedicationInformationRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;
        public PatientMedicationInformationValidator(IPatientMedicationInformationRepository entityRepository,
            IPatientRepository patientRepository)
        {
            _entityRepository = entityRepository;
            _patientRepository = patientRepository;

            #region Columns

            RuleFor(entity => entity.Description)
              .NotNull().NotEmpty()
              .WithMessage("A Description não pode ser vazia.")
              .MaximumLength(255)
              .WithMessage("O Description não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.StartDate)
                .NotNull()
               .WithMessage("A StartDate não pode ser vazia.");

            RuleFor(entity => entity.Dosage)
                .MaximumLength(255)
                .WithMessage("O Dosage não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.Posology)
              .MaximumLength(255)
              .WithMessage("O Dosage não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.MainDrug)
            .MaximumLength(255)
            .WithMessage("O Dosage não pode ultrapassar {MaxLength} carateres.");

            #endregion Columns 

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                 .NotNull()
                 .WithMessage("ErrorValidator_CreatedUserId_Null");

            RuleFor(entity => entity.PatientId)
              .NotNull()
              .WithMessage("ErrorValidator_Patient_Null")
              .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
              .WithMessage("ErrorValidator_Patient_NotFound")
              .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
              .WithMessage("ErrorValidator_Patient_Changed");

            #endregion Relationship  
        }

        private async Task<bool> PatientIdFound(PatientMedicationInformation entity)
        {
            try
            {
                await _patientRepository.FindExistsByID(entity.PatientId);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        private async Task<bool> PatientIdChanged(PatientMedicationInformation entity)
        {
            try
            {
                var entityBefore = await _entityRepository.FindByID(entity.Id);
                if (entityBefore.PatientId != entity.PatientId)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            } 
            return true;
        }
    }
}
