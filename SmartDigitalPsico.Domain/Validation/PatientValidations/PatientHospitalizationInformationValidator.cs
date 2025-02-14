using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientHospitalizationInformationValidator : PatientBaseValidator<PatientHospitalizationInformation>
    {

        public PatientHospitalizationInformationValidator(IPatientHospitalizationInformationRepository entityRepository,
                                                         IPatientRepository patientRepository)
            : base(patientRepository, entityRepository)
        {
            #region Columns

            RuleFor(entity => entity.Description)
                .NotNull().NotEmpty()
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.StartDate)
                .NotNull()
                .WithMessage("StartDate_Validator_IsRequired_Key|StartDate is required.");

            RuleFor(entity => entity.CID)
                .NotNull().NotEmpty()
                .WithMessage("CID_Validator_IsRequired_Key|CID is required.")
                .MaximumLength(20)
                .WithMessage("CID_Validator_MaxLength_Key|CID cannot exceed {0} characters.|20");

            RuleFor(entity => entity.Observation)
                .NotNull().NotEmpty()
                .WithMessage("Observation_Validator_IsRequired_Key|Observation is required.")
                .MaximumLength(2000)
                .WithMessage("Observation_Validator_MaxLength_Key|Observation cannot exceed {0} characters.|2000");

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
                .WithMessage("PatientId_Validator_Changed_Key|Patient has changed.");

            #endregion Relationship  
        }
    }
}
