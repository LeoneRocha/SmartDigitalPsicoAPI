using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por MedicalFileValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class MedicalFileValidator : MedicalBaseValidator<MedicalFile>
    {
        private const string MedicalIdMustErrorCode = "SmartDigitalPsico.MedicalFileValidator.MedicalFile.MedicalId.Must";

        /// <summary>
        /// Método MedicalFileValidator: executa a operação MedicalFileValidator.
        /// </summary>
        public MedicalFileValidator(IConfiguration configuration, IMedicalFileRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {  
            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.MedicalFileValidator.MedicalFile.Description.MaxLength")
                .WithMessage("Description_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithErrorCode("SmartDigitalPsico.MedicalFileValidator.MedicalFile.FilePath.MaxLength")
                .WithMessage("FilePath_MaxLength_Key|File path cannot exceed {0} characters.|2083");

            RuleFor(entity => entity.FileExtension)
                .MaximumLength(3)
                .WithErrorCode("SmartDigitalPsico.MedicalFileValidator.MedicalFile.FileExtension.MaxLength")
                .WithMessage("FileExtension_MaxLength_Key|File extension cannot exceed {0} characters.|3");

            RuleFor(entity => entity.FileContentType)
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.MedicalFileValidator.MedicalFile.FileContentType.MaxLength")
                .WithMessage("FileContentType_MaxLength_Key|File content type cannot exceed {0} characters.|100");

            RuleFor(entity => entity)
                .SetValidator(new FileValidator(configuration));
            #endregion Columns

            #region Relationship
            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalFileValidator.MedicalFile.MedicalId.NotNull")
                .WithMessage("ErrorValidator_MedicalId_Null|Doctor is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("ErrorValidator_MedicalId_NotFound|Doctor not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("ErrorValidator_Medical_Changed|Doctor has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("ErrorValidator_MedicalCreated_Invalid|Doctor creation is invalid.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("ErrorValidator_MedicalModify_Invalid|Doctor modification is invalid.");
            #endregion Relationship
        }
    }
}
