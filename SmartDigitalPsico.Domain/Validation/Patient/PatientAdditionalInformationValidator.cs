using FluentValidation;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Patient;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientAdditionalInformationValidator : PatientBaseValidator<PatientAdditionalInformation>
    {
        /// <summary>
        /// Método PatientAdditionalInformationValidator: executa a operação PatientAdditionalInformationValidator.
        /// </summary>
        public PatientAdditionalInformationValidator(IPatientAdditionalInformationRepository entityRepository,
                                                      IPatientRepository patientRepository)
             : base(patientRepository, entityRepository)
        {
            #region Columns
            RuleFor(entity => entity.FollowUp_Psychiatric)
                .MaximumLength(2000)
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.FollowUp_Psychiatric.MaxLength")
                .WithMessage("FollowUp_Psychiatric_MaxLength_Key|FollowUp_Psychiatric cannot exceed {0} characters.|2000");

            RuleFor(entity => entity.FollowUp_Neurological)
                .MaximumLength(2000)
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.FollowUp_Neurological.MaxLength")
                .WithMessage("FollowUp_Neurological_MaxLength_Key|FollowUp_Neurological cannot exceed {0} characters.|2000");
            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationValidator.PatientAdditionalInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }

    }
}
