using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    /// <summary>
    /// Classe responsável por PatientRecordValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientRecordValidator : PatientBaseValidator<PatientRecord>
    {
        /// <summary>
        /// Método PatientRecordValidator: executa a operação PatientRecordValidator.
        /// </summary>
        public PatientRecordValidator(IPatientRecordRepository entityRepository, IPatientRepository patientRepository)
            : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Annotation)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Annotation.NotNull")
                .WithMessage("Annotation_Validator_IsRequired_Key|Annotation is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Annotation.NotEmpty")
                .WithMessage("Annotation_Validator_IsRequired_Key|Annotation is required.")
                .MaximumLength(4000)
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.Annotation.MaxLength")
                .WithMessage("Annotation_Validator_MaxLength_Key|Annotation cannot exceed {0} characters.|4000");

            RuleFor(entity => entity.AnnotationDate)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.AnnotationDate.NotNull")
                .WithMessage("AnnotationDate_Validator_IsRequired_Key|AnnotationDate is required.");

            #endregion Columns 

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.PatientId.Must")
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.PatientRecordValidator.PatientRecord.PatientId.Must")
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }
    }
}
