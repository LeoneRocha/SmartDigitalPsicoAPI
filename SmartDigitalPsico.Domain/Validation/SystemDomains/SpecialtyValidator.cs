using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class SpecialtyValidator : AbstractValidator<Specialty>
    {
        public SpecialtyValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage("ErrorValidator_Description_Null")
                .MaximumLength(255)
                .WithMessage("O descrição não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.Language)
                .NotNull()
                .NotEmpty()
                .WithMessage("ErrorValidator_Language_Null")
                .MaximumLength(10)
                .WithMessage("O Language não pode ultrapassar {MaxLength} carateres.");
        }
    }
}
