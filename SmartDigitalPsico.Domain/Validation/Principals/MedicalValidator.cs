using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    /// <summary>
    /// Classe responsável por MedicalValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class MedicalValidator : AbstractValidator<Medical>
    {
        private readonly IMedicalRepository _entityRepository;
        /// <summary>
        /// Método MedicalValidator: executa a operação MedicalValidator.
        /// </summary>
        public MedicalValidator(IMedicalRepository entityRepository)
        {
            _entityRepository = entityRepository;

            #region Columns

            RuleFor(entity => entity.Name)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Name.NotNull")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Name.NotEmpty")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.");

            RuleFor(entity => entity.Accreditation)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Accreditation.NotNull")
                .WithMessage("Accreditation_Validator_IsRequired_Key|Accreditation is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Accreditation.NotEmpty")
                .WithMessage("Accreditation_Validator_IsRequired_Key|Accreditation is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Accreditation.MaxLength")
                .WithMessage("Accreditation_Validator_MaxLength_Key|Accreditation cannot exceed {0} characters.|10")
                .MustAsync(async (entity, value, c) => await IsUniqueAccreditation(entity, value))
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Accreditation.Must")
                .WithMessage("Accreditation_Validator_Unique_Key|Accreditation must be unique.");

            RuleFor(entity => entity.Email)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Email.NotNull")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Email.NotEmpty")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .EmailAddress()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Email.EmailAddress")
                .WithMessage("Email_Validator_Invalid_Key|Invalid email address.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Email.MaxLength")
                .WithMessage("Email_Validator_MaxLength_Key|Email cannot exceed {0} characters.|100")
                .MustAsync(async (entity, value, c) => await IsUniqueEmail(entity, value))
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.Email.Must")
                .WithMessage("Email_Validator_Unique_Key|Email must be unique.");

            RuleFor(p => p.SecurityKey)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.SecurityKey.MaxLength")
                .WithMessage("SecurityKey_Validator_MaxLength_Key|SecurityKey cannot exceed {0} characters.|255");

            RuleFor(m => m.StartWorkingTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.StartWorkingTime.NotEmpty")
                .WithMessage("StartWorkingTime_Validator_IsRequired_Key|Start working time is required.")
                .LessThan(m => m.EndWorkingTime)
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.StartWorkingTime.LessThan")
                .WithMessage("StartWorkingTime_Validator_BeforeEnd_Key|Start working time must be before end working time.");

            RuleFor(m => m.EndWorkingTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.EndWorkingTime.NotEmpty")
                .WithMessage("EndWorkingTime_Validator_IsRequired_Key|End working time is required.");

            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalValidator.Medical.CreatedUserId.NotNull")
                .WithMessage("ErrorValidator_CreatedUserId_Invalid_Key|Invalid created user ID.");

            #endregion Relationship
        }

        private async Task<bool> IsUniqueAccreditation(Medical entity, string value)
        {
            try
            {
                if (!await _entityRepository.Exists(entity.Id))
                {

                    var existingEnity = await _entityRepository.FindByAccreditation(value);

                    if (existingEnity != null)
                    {
                        return false;
                    } 
                }
                else
                {
                    var existingEnity = await _entityRepository.FindByID(entity.Id);
                    bool changingProp = !existingEnity.Accreditation.Equals(value, StringComparison.OrdinalIgnoreCase);
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

        private async Task<bool> IsUniqueEmail(Medical entity, string value)
        {
            try
            {
                if (!await _entityRepository.Exists(entity.Id))
                {
                    var existingEnity = await _entityRepository.FindByEmail(value);

                    if (existingEnity != null)
                    {
                        return false;
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
    }
}
