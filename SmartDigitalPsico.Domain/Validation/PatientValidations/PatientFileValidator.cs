using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientFileValidator : AbstractValidator<PatientFile>
    {
        private readonly IPatientFileRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientFileValidator(IPatientFileRepository entityRepository,
            IPatientRepository patientRepository)
        {
            _entityRepository = entityRepository;
            _patientRepository = patientRepository;

            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithMessage("O Description não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithMessage("O FilePath não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FileExtension)
             .MaximumLength(3)
             .WithMessage("O FileExtension não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FileContentType)
             .MaximumLength(100)
             .WithMessage("O FileContentType não pode ultrapassar {MaxLength} carateres.");

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
              .WithMessage("ErrorValidator_Patient_Changed")
              .MustAsync(async (entity, value, c) => await MedicalCreated(entity))
              .WithMessage("ErrorValidator_Patient_Medical_Created")
              .MustAsync(async (entity, value, c) => await MedicalModify(entity))
              .WithMessage("ErrorValidator_Patient_Medical_Modify");

            #endregion Relationship  
        }

        private async Task<bool> PatientIdFound(PatientFile entity)
        {
            try
            {
                await _patientRepository.FindExistsByID(entity.PatientId);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private async Task<bool> PatientIdChanged(PatientFile entity)
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
        private async Task<bool> MedicalCreated(PatientFile entity)
        {
            long idUser = entity.CreatedUserId.GetValueOrDefault();
            try
            {
                var patient = await _patientRepository.FindByID(entity.PatientId);
                if (patient.Medical != null && patient.Medical.UserId != idUser)
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
        private async Task<bool> MedicalModify(PatientFile entity)
        {
            long idUser = entity.ModifyUserId.GetValueOrDefault();
            try
            {
                var patient = await _patientRepository.FindByID(entity.PatientId);
                if (patient.Medical != null && patient.Medical.UserId != idUser)
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
