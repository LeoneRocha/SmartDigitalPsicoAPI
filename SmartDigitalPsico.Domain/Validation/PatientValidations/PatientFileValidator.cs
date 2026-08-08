using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Base;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    /// <summary>
    /// Classe responsável por PatientFileValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientFileValidator : PatientBaseValidator<PatientFile>
    {
        private const string PatientIdMustErrorCode = "SmartDigitalPsico.PatientFileValidator.PatientFile.PatientId.Must";

        /// <summary>
        /// Método PatientFileValidator: executa a operação PatientFileValidator.
        /// </summary>
        public PatientFileValidator(IConfiguration configuration, IPatientFileRepository entityRepository, IPatientRepository patientRepository)
           : base(patientRepository, entityRepository)
        {
            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.FilePath.MaxLength")
                .WithMessage("FilePath_Validator_MaxLength_Key|FilePath cannot exceed {0} characters.|2083");

            RuleFor(entity => entity.FileExtension)
                .MaximumLength(3)
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.FileExtension.MaxLength")
                .WithMessage("FileExtension_Validator_MaxLength_Key|FileExtension cannot exceed {0} characters.|3");

            RuleFor(entity => entity.FileContentType)
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.FileContentType.MaxLength")
                .WithMessage("FileContentType_Validator_MaxLength_Key|FileContentType cannot exceed {0} characters.|100");

            RuleFor(entity => entity)
                .SetValidator(new FileValidator(configuration));
            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientFileValidator.PatientFile.PatientId.NotNull")
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithErrorCode(PatientIdMustErrorCode)
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithErrorCode(PatientIdMustErrorCode)
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, entity.CreatedUserId))
                .WithErrorCode(PatientIdMustErrorCode)
                .WithMessage("PatientId_Validator_MedicalCreated_Key|Patient medical record created.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, entity.ModifyUserId))
                .WithErrorCode(PatientIdMustErrorCode)
                .WithMessage("PatientId_Validator_MedicalModify_Key|Patient medical record modified.");
            #endregion Relationship  
        }

    }
}
