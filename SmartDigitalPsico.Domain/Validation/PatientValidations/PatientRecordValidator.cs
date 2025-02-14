using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientRecordValidator : PatientBaseValidator<PatientRecord>
    {
        public PatientRecordValidator(IPatientRecordRepository entityRepository, IPatientRepository patientRepository)
            : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Annotation)
                .NotNull()
                .NotEmpty()
                .WithMessage("Annotation_Validator_IsRequired_Key|Annotation is required.")
                .MaximumLength(4000)
                .WithMessage("Annotation_Validator_MaxLength_Key|Annotation cannot exceed {0} characters.|4000");

            RuleFor(entity => entity.AnnotationDate)
                .NotNull()
                .WithMessage("AnnotationDate_Validator_IsRequired_Key|AnnotationDate is required.");

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
