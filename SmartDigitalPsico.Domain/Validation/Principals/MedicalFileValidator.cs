using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalFileValidator : AbstractValidator<MedicalFile>
    {
        private readonly IMedicalFileRepository _entityRepository;
        private readonly IMedicalRepository _medicalRepository;
        public MedicalFileValidator(IMedicalFileRepository entityRepository, IMedicalRepository medicalRepository)
        {
            _entityRepository = entityRepository;
            _medicalRepository = medicalRepository;

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
            RuleFor(entity => entity.MedicalId)
            .NotNull()
            .WithMessage("ErrorValidator_MedicalId_Null")
            .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
            .WithMessage("ErrorValidator_MedicalId_NotFound")
            .MustAsync(async (entity, value, c) => await MedicalChanged(entity, value))
            .WithMessage("ErrorValidator_Medical_Changed")
            .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value))
            .WithMessage("ErrorValidator_MedicalCreated_Invalid")
            .MustAsync(async (entity, value, c) => await MedicalModify(entity, value))
            .WithMessage("ErrorValidator_MedicalModify_Invalid");

            #endregion Relationship
        }
        private async Task<bool> MedicalIdFound(MedicalFile entity)
        {
            var entityFind = await _medicalRepository.FindByID(entity.MedicalId);
            if (entityFind == null)
            {
                return false;
            }
            return true;
        }

        private async Task<bool> MedicalChanged(MedicalFile entity, long value)
        {
            var entityBefore = await _entityRepository.FindByID(value);
            if (entityBefore != null && entityBefore.MedicalId != entity.MedicalId)
            {
                return false;
            }
            return true;
        }

        private async Task<bool> MedicalCreated(MedicalFile entity, long value)
        {
            long idUser = entity.CreatedUserId.GetValueOrDefault();
            var medical = await _medicalRepository.FindByID(value);
            if (medical == null || medical.UserId != idUser)
            {
                return false;
            }
            return true;
        }

        private async Task<bool> MedicalModify(MedicalFile entity, long value)
        {
            long idUser = entity.ModifyUserId.GetValueOrDefault();

            var medical = await _medicalRepository.FindByID(value);
            if (medical == null || medical.UserId != idUser)
            {
                return false;
            }
            return true;
        }
    }
}