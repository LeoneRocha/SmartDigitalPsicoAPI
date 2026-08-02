using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientNotificationMessageValidator : PatientBaseValidator<PatientNotificationMessage>
    {
        public PatientNotificationMessageValidator(IPatientNotificationMessageRepository entityRepository, IPatientRepository patientRepository)
         : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.MessagePatient)
                .NotNull().NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.MessagePatient.NotEmpty")
                .WithMessage("MessagePatient_Validator_IsRequired_Key|MessagePatient is required.")
                .MaximumLength(2000)
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.MessagePatient.MaxLength")
                .WithMessage("MessagePatient_Validator_MaxLength_Key|MessagePatient cannot exceed {0} characters.|2000");

            #endregion Columns 

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.PatientId.Must")
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageValidator.PatientNotificationMessage.PatientId.Must")
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }
    }
}
