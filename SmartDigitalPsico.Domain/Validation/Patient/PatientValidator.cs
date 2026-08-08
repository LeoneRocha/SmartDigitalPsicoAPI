using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientValidator : MedicalBaseValidator<Patient>
    {
        private const string MedicalIdMustErrorCode = "SmartDigitalPsico.PatientValidator.Patient.MedicalId.Must";

        private new readonly IPatientRepository _entityRepository;
        /// <summary>
        /// Método PatientValidator: executa a operação PatientValidator.
        /// </summary>
        public PatientValidator(IPatientRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository)
           : base(medicalRepository, entityRepository, userRepository)
        {
            _entityRepository = entityRepository;

            #region Columns

            RuleFor(entity => entity.Name)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Name.NotNull")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Name.NotEmpty")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.");

            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Profession.MaxLength")
                .WithMessage("Profession_Validator_MaxLength_Key|Profession cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Email)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Email.NotNull")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Email.NotEmpty")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .EmailAddress()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Email.EmailAddress")
                .WithMessage("Email_Validator_Invalid_Key|Invalid email address.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Email.MaxLength")
                .WithMessage("Email_Validator_MaxLength_Key|Email cannot exceed {0} characters.|100")
                .MustAsync(async (entity, value, c) => await UniqueEmail(entity, value))
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Email.Must")
                .WithMessage("Email_Validator_Unique_Key|Email must be unique.");

            RuleFor(p => p.DateOfBirth)
                .Must(beValidAge)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.DateOfBirth.Must")
                .WithMessage("DateOfBirth_Validator_Invalid_Key|Invalid date of birth.");

            RuleFor(p => p.Rg)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Rg.NotNull")
                .WithMessage("RG_Validator_IsRequired_Key|RG is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Rg.NotEmpty")
                .WithMessage("RG_Validator_IsRequired_Key|RG is required.")
                .Length(10, 15)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Rg.Length")
                .WithMessage("RG_Validator_Length_Key|RG must be between {0} and {1} characters long.|10|15");

            RuleFor(p => p.Cpf)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Cpf.NotNull")
                .WithMessage("CPF_Validator_IsRequired_Key|CPF is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Cpf.NotEmpty")
                .WithMessage("CPF_Validator_IsRequired_Key|CPF is required.")
                .Length(10, 15)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Cpf.Length")
                .WithMessage("CPF_Validator_Length_Key|CPF must be between {0} and {1} characters long.|10|15");

            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Profession.MaxLength")
                .WithMessage("Profession_Validator_MaxLength_Key|Profession cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Education)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.Education.MaxLength")
                .WithMessage("Education_Validator_MaxLength_Key|Education cannot exceed {0} characters.|255");

            RuleFor(entity => entity.PhoneNumber)
                .MaximumLength(20)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.PhoneNumber.MaxLength")
                .WithMessage("PhoneNumber_Validator_MaxLength_Key|PhoneNumber cannot exceed {0} characters.|20")
                .Length(8, 20)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.PhoneNumber.Length")
                .WithMessage("PhoneNumber_Validator_Length_Key|PhoneNumber must be between {0} and {1} characters long.|8|20");

            RuleFor(entity => entity.AddressStreet)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressStreet.MaxLength")
                .WithMessage("AddressStreet_Validator_MaxLength_Key|AddressStreet cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressNeighborhood)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressNeighborhood.MaxLength")
                .WithMessage("AddressNeighborhood_Validator_MaxLength_Key|AddressNeighborhood cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressCity)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressCity.MaxLength")
                .WithMessage("AddressCity_Validator_MaxLength_Key|AddressCity cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressState)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressState.MaxLength")
                .WithMessage("AddressState_Validator_MaxLength_Key|AddressState cannot exceed {0} characters.|255");

            RuleFor(entity => entity.AddressCep)
                .MaximumLength(20)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressCep.MaxLength")
                .WithMessage("AddressCep_Validator_MaxLength_Key|AddressCep cannot exceed {0} characters.|20")
                .Length(8, 20)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.AddressCep.Length")
                .WithMessage("AddressCep_Validator_Length_Key|AddressCep must be between {0} and {1} characters long.|8|20");

            RuleFor(entity => entity.EmergencyContactName)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.EmergencyContactName.MaxLength")
                .WithMessage("EmergencyContactName_Validator_MaxLength_Key|EmergencyContactName cannot exceed {0} characters.|255");

            RuleFor(entity => entity.EmergencyContactPhoneNumber)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.EmergencyContactPhoneNumber.MaxLength")
                .WithMessage("EmergencyContactPhoneNumber_Validator_MaxLength_Key|EmergencyContactPhoneNumber cannot exceed {0} characters.|255");

            #endregion

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.CreatedUserId.NotNull")
                .WithMessage("CreatedUserId_Validator_IsRequired_Key|Created user ID is required.");

            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.PatientValidator.Patient.MedicalId.NotNull")
                .WithMessage("MedicalId_Validator_IsRequired_Key|Medical ID is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("MedicalId_Validator_NotFound_Key|Medical ID not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("Medical_Validator_Changed_Key|Medical ID has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithErrorCode(MedicalIdMustErrorCode)
                .WithMessage("Medical_Validator_Created_Invalid_Key|Invalid medical record created.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithErrorCode(MedicalIdMustErrorCode)
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
            int currentYear = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 130))
            {
                return true;
            }
            return false;
        }
    }
}
