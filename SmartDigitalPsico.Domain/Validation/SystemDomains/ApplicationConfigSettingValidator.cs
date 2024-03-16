﻿using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class ApplicationConfigSettingValidator : AbstractValidator<ApplicationConfigSetting>
    {
        public ApplicationConfigSettingValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull().NotEmpty()
              .WithMessage("ErrorValidator_Description_Null");

            RuleFor(entity => entity.Language)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_Language_Null")
                .MaximumLength(10)
                .WithMessage("O Language não pode ultrapassar {MaxLength} carateres.");
        }
    }
}
