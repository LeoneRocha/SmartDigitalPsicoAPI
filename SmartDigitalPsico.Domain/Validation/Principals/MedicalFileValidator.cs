using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalFileValidator : MedicalBaseValidator<MedicalFile>
    {
        public MedicalFileValidator(IConfiguration configuration, IMedicalFileRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {  
            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithMessage("Description_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithMessage("FilePath_MaxLength_Key|File path cannot exceed {0} characters.|2083");

            RuleFor(entity => entity.FileExtension)
                .MaximumLength(3)
                .WithMessage("FileExtension_MaxLength_Key|File extension cannot exceed {0} characters.|3");

            RuleFor(entity => entity.FileContentType)
                .MaximumLength(100)
                .WithMessage("FileContentType_MaxLength_Key|File content type cannot exceed {0} characters.|100");

            RuleFor(entity => entity)
                .SetValidator(new FileValidator(configuration));
            #endregion Columns

            #region Relationship
            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithMessage("ErrorValidator_MedicalId_Null|Doctor is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithMessage("ErrorValidator_MedicalId_NotFound|Doctor not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithMessage("ErrorValidator_Medical_Changed|Doctor has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithMessage("ErrorValidator_MedicalCreated_Invalid|Doctor creation is invalid.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithMessage("ErrorValidator_MedicalModify_Invalid|Doctor modification is invalid.");
            #endregion Relationship
        }
    }
}