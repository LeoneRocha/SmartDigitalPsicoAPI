using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientAdditionalInformationValidator : PatientBaseValidator<PatientAdditionalInformation>
    {
        public PatientAdditionalInformationValidator(IPatientAdditionalInformationRepository entityRepository,
                                                      IPatientRepository patientRepository)
             : base(patientRepository, entityRepository)
        {
            #region Columns
            RuleFor(entity => entity.FollowUp_Psychiatric)
                .MaximumLength(2000)
                .WithMessage("FollowUp_Psychiatric_MaxLength_Key|FollowUp_Psychiatric cannot exceed {0} characters.|2000");

            RuleFor(entity => entity.FollowUp_Neurological)
                .MaximumLength(2000)
                .WithMessage("FollowUp_Neurological_MaxLength_Key|FollowUp_Neurological cannot exceed {0} characters.|2000");
            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }

    }
}
