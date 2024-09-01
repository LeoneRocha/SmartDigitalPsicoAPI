using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientRecordValidator : PatientBaseValidator<PatientRecord>
    {

        public PatientRecordValidator(IPatientRecordRepository entityRepository, IPatientRepository patientRepository) : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
              .NotNull()
              .NotEmpty()
              .WithMessage("ErrorValidator_Description_Null")
              .MaximumLength(255)
              .WithMessage("O Description não pode ultrapassar {MaxLength} carateres.");


            RuleFor(entity => entity.Annotation)
                .NotNull()
                .NotEmpty()
                .MaximumLength(4000)
                .WithMessage("ErrorValidator_Annotation_Null");

            RuleFor(entity => entity.AnnotationDate)
             .NotNull()
             .WithMessage("ErrorValidator_AnnotationDate_Null");

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
