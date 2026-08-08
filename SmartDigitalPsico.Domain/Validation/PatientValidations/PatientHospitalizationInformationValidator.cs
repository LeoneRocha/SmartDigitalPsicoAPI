using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Base;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientHospitalizationInformationValidator : PatientBaseValidator<PatientHospitalizationInformation>
    {

        /// <summary>
        /// Método PatientHospitalizationInformationValidator: executa a operação PatientHospitalizationInformationValidator.
        /// </summary>
        public PatientHospitalizationInformationValidator(IPatientHospitalizationInformationRepository entityRepository,
                                                         IPatientRepository patientRepository)
            : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.StartDate)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.StartDate.NotNull")
                .WithMessage("StartDate_Validator_IsRequired_Key|StartDate is required.");

            RuleFor(entity => entity.CID)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.CID.NotNull")
                .WithMessage("CID_Validator_IsRequired_Key|CID is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.CID.NotEmpty")
                .WithMessage("CID_Validator_IsRequired_Key|CID is required.")
                .MaximumLength(20)
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.CID.MaxLength")
                .WithMessage("CID_Validator_MaxLength_Key|CID cannot exceed {0} characters.|20");

            RuleFor(entity => entity.Observation)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Observation.NotNull")
                .WithMessage("Observation_Validator_IsRequired_Key|Observation is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Observation.NotEmpty")
                .WithMessage("Observation_Validator_IsRequired_Key|Observation is required.")
                .MaximumLength(2000)
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.Observation.MaxLength")
                .WithMessage("Observation_Validator_MaxLength_Key|Observation cannot exceed {0} characters.|2000");

            #endregion Columns 

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationValidator.PatientHospitalizationInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }
    }
}
