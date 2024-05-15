using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientRecordValidator : AbstractValidator<PatientRecord>
    {
        private readonly IPatientRecordRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientRecordValidator(IPatientRecordRepository entityRepository, IPatientRepository patientRepository)
        {
            _entityRepository = entityRepository;
            _patientRepository = patientRepository;

            #region Columns

            RuleFor(entity => entity.Description)
              .NotNull().NotEmpty()
              .WithMessage("ErrorValidator_Description_Null")
              .MaximumLength(255)
              .WithMessage("O Description não pode ultrapassar {MaxLength} carateres.");


            RuleFor(entity => entity.Annotation)
                .NotNull().NotEmpty()
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
             .MustAsync(async (entity, value, c) => await PatientIdFound(entity, value))
             .WithMessage("ErrorValidator_Patient_NotFound")
             .MustAsync(async (entity, value, c) => await PatientIdChanged(entity, value))
             .WithMessage("ErrorValidator_Patient_Changed");

            #endregion Relationship  
        }

        private async Task<bool> PatientIdFound(PatientRecord entity, long value)
        {
            var entityFind = await _patientRepository.FindByID(entity.PatientId);
            if (entityFind == null)
            {
                return false;
            }
            return true;
        }
        private async Task<bool> PatientIdChanged(PatientRecord entity, long value)
        {
            var entityBefore = await _entityRepository.FindByID(entity.Id);
            if (entityBefore != null)
            {
                if (entityBefore.PatientId != entity.PatientId)
                {
                    return false;
                }
            }
            return true;
        } 
    }
}
