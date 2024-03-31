using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientAdditionalInformationValidator : AbstractValidator<PatientAdditionalInformation>
    {
        private IPatientAdditionalInformationRepository _entityRepository;
        private IPatientRepository _patientRepository;

        public PatientAdditionalInformationValidator(IPatientAdditionalInformationRepository entityRepository,
            IPatientRepository patientRepository)
        {
            _entityRepository = entityRepository;
            _patientRepository = patientRepository;

            #region Columns
            RuleFor(entity => entity.FollowUp_Psychiatric)
                .MaximumLength(2000)
                .WithMessage("O FollowUp_Psychiatric não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FollowUp_Neurological)
               .MaximumLength(2000)
               .WithMessage("O FollowUp_Neurological não pode ultrapassar {MaxLength} carateres.");
            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUser)
              .NotNull()
              .WithMessage("ErrorValidator_CreatedUser_Null");

            RuleFor(entity => entity.PatientId)
              .NotNull()
              .WithMessage("ErrorValidator_Patient_Null")
              .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
              .WithMessage("ErrorValidator_Patient_NotFound")
              .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
              .WithMessage("ErrorValidator_Patient_Changed");


            #endregion Relationship  
        }
        private async Task<bool> PatientIdFound(PatientAdditionalInformation entity)
        {
            var entityFind = await _patientRepository.FindByID(entity.PatientId);
            if (entityFind == null)
            {
                return false;
            }
            return true;
        }
        private async Task<bool> PatientIdChanged(PatientAdditionalInformation entity)
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
