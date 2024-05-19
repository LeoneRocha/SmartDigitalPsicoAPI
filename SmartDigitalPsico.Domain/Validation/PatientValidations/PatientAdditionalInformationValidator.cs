using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientAdditionalInformationValidator : PatientBaseValidator<PatientAdditionalInformation>
    {
        public PatientAdditionalInformationValidator(IPatientAdditionalInformationRepository entityRepository,
           IPatientRepository patientRepository) : base(patientRepository, entityRepository)
        {
            #region Columns
            RuleFor(entity => entity.FollowUp_Psychiatric)
                .MaximumLength(2000)
                .WithMessage("O FollowUp_Psychiatric não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FollowUp_Neurological)
               .MaximumLength(2000)
               .WithMessage("O FollowUp_Neurological não pode ultrapassar {MaxLength} carateres.");
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
