using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientAdditionalInformationValidator : AbstractValidator<PatientAdditionalInformation>
    {
        private readonly IPatientAdditionalInformationRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

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
        private async Task<bool> PatientIdFound(PatientAdditionalInformation entity)
        {
            try
            {
                await _patientRepository.FindExistsByID(entity.PatientId);
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }
        private async Task<bool> PatientIdChanged(PatientAdditionalInformation entity)
        {
            try
            {
                var entityBefore = await _entityRepository.FindByID(entity.Id);
                if (entityBefore.PatientId != entity.PatientId)
                {
                    return false;
                } 
            }
            catch (Exception)
            { 
                return false;
            } 
            return true;
        }
    }
}
