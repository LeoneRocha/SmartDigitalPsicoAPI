using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientMedicationInformationValidator : PatientBaseValidator<PatientMedicationInformation>
    { 
        public PatientMedicationInformationValidator(IPatientMedicationInformationRepository entityRepository,
            IPatientRepository patientRepository) : base(patientRepository, entityRepository)
        {  
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
    }
}
