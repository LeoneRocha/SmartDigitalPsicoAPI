using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientHospitalizationInformationValidator : PatientBaseValidator<PatientHospitalizationInformation>
    {

        public PatientHospitalizationInformationValidator(IPatientHospitalizationInformationRepository entityRepository,
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

            RuleFor(entity => entity.CID)
            .NotNull().NotEmpty()
            .WithMessage("A CID não pode ser vazia.")
            .MaximumLength(20)
            .WithMessage("O CID não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.Observation)
                .NotNull().NotEmpty()
                .WithMessage("A Observation não pode ser vazia.")
                .MaximumLength(2000)
                .WithMessage("O Observation não pode ultrapassar {MaxLength} carateres.");

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
