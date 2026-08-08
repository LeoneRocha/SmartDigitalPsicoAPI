using FluentValidation;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientMedicationInformationValidator : PatientBaseValidator<PatientMedicationInformation>
    {
        /// <summary>
        /// Método PatientMedicationInformationValidator: executa a operação PatientMedicationInformationValidator.
        /// </summary>
        public PatientMedicationInformationValidator(IPatientMedicationInformationRepository entityRepository,
                                                     IPatientRepository patientRepository)
            : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.StartDate)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.StartDate.NotNull")
                .WithMessage("StartDate_Validator_IsRequired_Key|StartDate is required.");

            RuleFor(entity => entity.Dosage)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.Dosage.MaxLength")
                .WithMessage("Dosage_Validator_MaxLength_Key|Dosage cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Posology)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.Posology.MaxLength")
                .WithMessage("Posology_Validator_MaxLength_Key|Posology cannot exceed {0} characters.|255");

            RuleFor(entity => entity.MainDrug)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.MainDrug.MaxLength")
                .WithMessage("MainDrug_Validator_MaxLength_Key|MainDrug cannot exceed {0} characters.|255");

            #endregion Columns 

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationValidator.PatientMedicationInformation.PatientId.Must")
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }
    }
}
