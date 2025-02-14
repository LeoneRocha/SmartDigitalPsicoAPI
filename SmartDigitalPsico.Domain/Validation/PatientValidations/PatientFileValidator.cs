using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientFileValidator : PatientBaseValidator<PatientFile>
    {
        public PatientFileValidator(IConfiguration configuration, IPatientFileRepository entityRepository, IPatientRepository patientRepository)
           : base(patientRepository, entityRepository)
        {
            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithMessage("FilePath_Validator_MaxLength_Key|FilePath cannot exceed {0} characters.|2083");

            RuleFor(entity => entity.FileExtension)
                .MaximumLength(3)
                .WithMessage("FileExtension_Validator_MaxLength_Key|FileExtension cannot exceed {0} characters.|3");

            RuleFor(entity => entity.FileContentType)
                .MaximumLength(100)
                .WithMessage("FileContentType_Validator_MaxLength_Key|FileContentType cannot exceed {0} characters.|100");

            RuleFor(entity => entity)
                .SetValidator(new FileValidator(configuration));
            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithMessage("PatientId_Validator_IsRequired_Key|Patient ID is required.")
                .MustAsync(async (entity, value, c) => await PatientIdFound(entity))
                .WithMessage("PatientId_Validator_NotFound_Key|Patient not found.")
                .MustAsync(async (entity, value, c) => await PatientIdChanged(entity))
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, entity.CreatedUserId))
                .WithMessage("PatientId_Validator_MedicalCreated_Key|Patient medical record created.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, entity.ModifyUserId))
                .WithMessage("PatientId_Validator_MedicalModify_Key|Patient medical record modified.");
            #endregion Relationship  
        }

    }
}
