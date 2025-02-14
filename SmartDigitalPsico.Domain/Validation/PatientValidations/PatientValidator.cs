using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientValidator : MedicalBaseValidator<Patient>
    {
        private new readonly IPatientRepository _entityRepository;
        public PatientValidator(IPatientRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository)
           : base(medicalRepository, entityRepository, userRepository)
        {
            _entityRepository = entityRepository;

            #region Columns

            RuleFor(entity => entity.Name)
                .NotNull().NotEmpty()
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.");

            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithMessage("Profession_Validator_MaxLength_Key|Profession cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Email)
                .NotNull().NotEmpty()
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .EmailAddress()
                .WithMessage("Email_Validator_Invalid_Key|Invalid email address.")
                .MaximumLength(100)
                .WithMessage("Email_Validator_MaxLength_Key|Email cannot exceed {0} characters.|100")
                .MustAsync(async (entity, value, c) => await UniqueEmail(entity, value))
                .WithMessage("Email_Validator_Unique_Key|Email must be unique.");

            RuleFor(p => p.DateOfBirth)
                .Must(beValidAge)
                .WithMessage("DateOfBirth_Validator_Invalid_Key|Invalid date of birth.");

            RuleFor(p => p.Rg)
                .NotNull().NotEmpty()
                .WithMessage("RG_Validator_IsRequired_Key|RG is required.")
                .Length(10, 15)
                .WithMessage("RG_Validator_Length_Key|RG must be between {0} and {1} characters long.|10|15");

            RuleFor(p => p.Cpf)
                .NotNull().NotEmpty()
                .WithMessage("CPF_Validator_IsRequired_Key|CPF is required.")
                .Length(10, 15)
                .WithMessage("CPF_Validator_Length_Key|CPF must be between {0} and {1} characters long.|10|15");

            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithMessage("Profession_Validator_MaxLength_Key|Profession cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Education)
                .MaximumLength(255)
                .WithMessage("Education_Validator_MaxLength_Key|Education cannot exceed {0} characters.|255");

            RuleFor(entity => entity.PhoneNumber)
                .MaximumLength(20)
                .WithMessage("PhoneNumber_Validator_MaxLength_Key|PhoneNumber cannot exceed {0} characters.|20")
                .Length(8, 20)
                .WithMessage("PhoneNumber_Validator_Length_Key|PhoneNumber must be between {0} and {1} characters long.|8|20");

            RuleFor(entity => entity.AddressStreet)
                .MaximumLength(255)
                .WithMessage("AddressStreet_Validator_MaxLength_Key|AddressStreet cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressNeighborhood)
                .MaximumLength(255)
                .WithMessage("AddressNeighborhood_Validator_MaxLength_Key|AddressNeighborhood cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressCity)
                .MaximumLength(255)
                .WithMessage("AddressCity_Validator_MaxLength_Key|AddressCity cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressState)
                .MaximumLength(255)
                .WithMessage("AddressState_Validator_MaxLength_Key|AddressState cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressCep)
                .MaximumLength(20)
                .WithMessage("AddressCep_Validator_MaxLength_Key|AddressCep cannot exceed {0} characters.|20")
                .Length(8, 20)
                .WithMessage("AddressCep_Validator_Length_Key|AddressCep must be between {0} and {1} characters long.|8|20");

            RuleFor(entity => entity.EmergencyContactName)
                .MaximumLength(255)
                .WithMessage("EmergencyContactName_Validator_MaxLength_Key|EmergencyContactName cannot exceed {0} characters.|255");

            RuleFor(entity => entity.EmergencyContactPhoneNumber)
                .MaximumLength(255)
                .WithMessage("EmergencyContactPhoneNumber_Validator_MaxLength_Key|EmergencyContactPhoneNumber cannot exceed {0} characters.|255");

            #endregion

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithMessage("MedicalId_Validator_IsRequired_Key|Medical ID is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithMessage("MedicalId_Validator_NotFound_Key|Medical ID not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithMessage("Medical_Validator_Changed_Key|Medical ID has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithMessage("Medical_Validator_Created_Invalid_Key|Invalid medical record created.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithMessage("Medical_Validator_Modify_Invalid_Key|Invalid medical record modified.");

            #endregion Relationship 
        }

        private async Task<bool> UniqueEmail(Patient entity, string value)
        {
            try
            { 
                if (!await _entityRepository.Exists(entity.Id))
                {

                    var existingEnity = await _entityRepository.FindByEmail(value);

                    if (existingEnity == null)
                    {
                        return true;
                    }
                }
                else
                {
                    var existingEnity = await _entityRepository.FindByID(entity.Id);
                    bool changingProp = !existingEnity.Email.Equals(value, StringComparison.OrdinalIgnoreCase);
                    if (changingProp)
                    {
                        return false;
                    }
                } 
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
         
        private static bool beValidAge(DateTime date)
        {
            int currentYear = DateHelper.GetDateTimeNowFromUtc().Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 130))
            {
                return true;
            }
            return false;
        }
    }
}
