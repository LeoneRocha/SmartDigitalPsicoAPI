﻿using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalValidator : AbstractValidator<Medical>
    {
        private IMedicalRepository _entityRepository;
        public MedicalValidator(IMedicalRepository entityRepository)
        {
            _entityRepository = entityRepository;

            #region Columns

            RuleFor(entity => entity.Name)
                .NotNull().NotEmpty() 
                .WithMessage("ErrorValidator_Name_Null");

            RuleFor(entity => entity.Accreditation)
                .NotNull().NotEmpty() 
                .WithMessage("ErrorValidator_Accreditation_Null")
                .MaximumLength(10)
                .WithMessage("O Accreditation não pode ultrapassar {MaxLength} carateres.")
                .MustAsync(async (entity, value, c) => await IsUniqueAccreditation(entity, value)) 
               .WithMessage("ErrorValidator_Accreditation_Unique"); 

            RuleFor(entity => entity.Email)
               .NotNull().NotEmpty() 
               .WithMessage("ErrorValidator_Email_Null")
               .EmailAddress() 
                .WithMessage("ErrorValidator_Email_Invalid")
               .MaximumLength(100)
               .WithMessage("O Email não pode ultrapassar {MaxLength} carateres.")
               .MustAsync(async (entity, value, c) => await IsUniqueEmail(entity, value)) 
               .WithMessage("ErrorValidator_Email_Unique");

            RuleFor(p => p.SecurityKey)
                .MaximumLength(255)
               .WithMessage("O SecurityKey não pode ultrapassar {MaxLength} carateres.");

            #endregion

            #region Relationship

            RuleFor(entity => entity.CreatedUser)
              .NotNull() 
              .WithMessage("ErrorValidator_CreatedUser_Invalid");

            #endregion Relationship 
        }

        private async Task<bool> IsUniqueAccreditation(Medical entity, string value)
        {
            var entityActual = await _entityRepository.FindByID(entity.Id);
            bool isNewEnity = entityActual == null;

            var existingEnity = await _entityRepository.FindByAccreditation(value);

            if (isNewEnity && existingEnity != null)
            {
                return false;
            }
            bool changingProp = entityActual != null && entityActual.Accreditation != value;
            if (changingProp)
            {
                return false;
            }
            return true;
        }

        private async Task<bool> IsUniqueEmail(Medical entity, string value)
        {
            var entityActual = await _entityRepository.FindByID(entity.Id);
            bool isNewEnity = entityActual == null;
            var existingEnity = await _entityRepository.FindByEmail(value);
            if (isNewEnity && existingEnity != null)
            {
                return false;
            }
            bool changingProp = entityActual != null && entityActual.Email != value;
            if (changingProp)
            {
                return false;
            }
            return true;
        }
    }
}
