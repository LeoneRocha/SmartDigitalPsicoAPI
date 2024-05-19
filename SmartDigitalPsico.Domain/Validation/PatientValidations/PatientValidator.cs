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
        public PatientValidator(IPatientRepository entityRepository, IMedicalRepository medicalRepository) : base(medicalRepository, entityRepository)
        {
            _entityRepository = entityRepository; 

            #region Columns

            RuleFor(entity => entity.Name)
             .NotNull().NotEmpty()
          .WithMessage("ErrorValidator_Description_Null");

            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithMessage("O Profession não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.Email)
               .NotNull().NotEmpty()
               .WithMessage("ErrorValidator_Email_Null")
               .EmailAddress()
               .WithMessage("ErrorValidator_Email_Invalid")
               .MaximumLength(100)
               .WithMessage("O Email não pode ultrapassar {MaxLength} carateres.")
               .MustAsync(async (entity, value, c) => await UniqueEmail(entity, value))
              .WithMessage("ErrorValidator_Email_Unique");

            RuleFor(p => p.DateOfBirth).Must(beAValidAge)
                .WithMessage("ErrorValidator_DateOfBirth_Invalid");

            RuleFor(p => p.Rg)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_RG_Null")
                .Length(10, 15)
               .WithMessage("Rg must be between 10 and {MaxLength} characters long");


            RuleFor(p => p.Cpf)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_CPF_Null")
                .Length(10, 15)
               .WithMessage("Rg must be between 10 and {MaxLength} characters long");


            RuleFor(entity => entity.Profession)
                .MaximumLength(255)
                .WithMessage("O Profession não pode ultrapassar {MaxLength} carateres.");


            RuleFor(entity => entity.Education)
                .MaximumLength(255)
                .WithMessage("O Education não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.PhoneNumber)
                .MaximumLength(20)
                .WithMessage("O PhoneNumber não pode ultrapassar {MaxLength} carateres.")
                .Length(8, 20)
               .WithMessage("PhoneNumber must be between 8 and {MaxLength} characters long");

            RuleFor(entity => entity.AddressStreet)
                .MaximumLength(255)
                .WithMessage("O AddressStreet não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.AddressNeighborhood)
                .MaximumLength(255)
                .WithMessage("O AddressNeighborhood não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.AddressCity)
              .MaximumLength(255)
              .WithMessage("O AddressCity não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.AddressState)
                .MaximumLength(255)
                .WithMessage("O AddressState não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.AddressCep)
                .MaximumLength(20)
                .WithMessage("O AddressCep não pode ultrapassar {MaxLength} carateres.")
                .Length(8, 20)
               .WithMessage("AddressCep must be between 8 and {MaxLength} characters long");

            RuleFor(entity => entity.EmergencyContactName)
             .MaximumLength(255)
             .WithMessage("O EmergencyContactName não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.EmergencyContactPhoneNumber)
             .MaximumLength(255)
             .WithMessage("O EmergencyContactPhoneNumber não pode ultrapassar {MaxLength} carateres.");

            #endregion

            #region Relationship

            RuleFor(entity => entity.CreatedUserId)
              .NotNull()
              .WithMessage("ErrorValidator_CreatedUserId_Null");

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

        private async Task<bool> UniqueEmail(Patient entity, string value)
        {
            try
            {
                var entityActual = await _entityRepository.FindByID(entity.Id);
                bool isNewEnity = entityActual == null;
                var existingEnity = await _entityRepository.FindByEmail(value);
                if (isNewEnity && existingEnity != null)
                {
                    return false;
                }
                if (entityActual != null && entityActual.Email != value)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        private static bool beAValidAge(DateTime date)
        {
            int currentYear = DataHelper.GetDateTimeNow().Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 130))
            {
                return true;
            }
            return false;
        }
    }
}
