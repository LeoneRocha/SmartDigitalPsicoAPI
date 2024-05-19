using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalFileValidator : MedicalBaseValidator<MedicalFile>
    { 
        public MedicalFileValidator(IMedicalFileRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        { 

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
            .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
            .WithMessage("ErrorValidator_Medical_Changed")
            .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
            .WithMessage("ErrorValidator_MedicalCreated_Invalid")
            .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
            .WithMessage("ErrorValidator_MedicalModify_Invalid");

            #endregion Relationship
        }

    }
}