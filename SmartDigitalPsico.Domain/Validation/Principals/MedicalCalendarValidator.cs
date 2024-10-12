using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalCalendarValidator : MedicalBaseValidator<MedicalCalendar>
    { 
        public MedicalCalendarValidator(IConfiguration configuration, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {
            #region Columns 
            RuleFor(e => e.Title)
           .NotEmpty()
           .WithMessage("Title is required.")
           .MaximumLength(100)
           .WithMessage("Title cannot exceed 100 characters.");

            RuleFor(e => e.StartDateTime)
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithMessage("Start time must be before end time.");

            RuleFor(e => e.Status)
                .IsInEnum().WithMessage("Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50).WithMessage("Color category cannot exceed 50 characters.");

            RuleFor(e => e.TimeZone)
                .NotEmpty().WithMessage("Time zone is required.")
                .MaximumLength(150).WithMessage("Time zone cannot exceed 150 characters.");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays).When(e => e.RecurrenceDays != null && e.RecurrenceDays.Any())
                .WithMessage("Invalid recurrence days.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum().WithMessage("Invalid recurrence type."); 
             
        #endregion Columns

        #region Relationship
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

            //A FAZER DO PACIENTE 
            #endregion Relationship
        }

        private bool BeValidDays(DayOfWeek[] recurrenceDays)
        {
            return recurrenceDays.All(day => Enum.IsDefined(typeof(DayOfWeek), day));
        }

    }
}