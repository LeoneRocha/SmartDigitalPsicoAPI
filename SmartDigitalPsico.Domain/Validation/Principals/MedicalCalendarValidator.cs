using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalCalendarValidator : MedicalBaseValidator<MedicalCalendar>
    {
        private readonly IMedicalCalendarRepository _repository;
        public MedicalCalendarValidator(IConfiguration configuration, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {
            _repository = entityRepository;

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

            RuleFor(e => e.TokenRecurrence)
             .MaximumLength(40).WithMessage("Token Recurrence cannot exceed 40 characters.");

            RuleFor(e => e.TimeZone)
                .NotEmpty().WithMessage("Time zone is required.")
                .MaximumLength(150).WithMessage("Time zone cannot exceed 150 characters.");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays).When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
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

            RuleFor(x => x)
                .MustAsync(NoScheduleConflict)
                .WithMessage("There is a scheduling conflict for the specified time.");
        }

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
        {
            return recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(typeof(DayOfWeek), day));
        }

        private async Task<bool> NoScheduleConflict(MedicalCalendar calendar, CancellationToken cancellationToken)
        {
            return await MedicalCalendarRangeValidator.ValidCOnflict(calendar, _repository);
        } 
    } 
    public class MedicalCalendarRangeValidator : AbstractValidator<MedicalCalendar>
    {
        private readonly IMedicalCalendarRepository _entityRepository;

        public MedicalCalendarRangeValidator(IMedicalCalendarRepository entityRepository)
        {
            _entityRepository = entityRepository;

            RuleFor(m => m)
                .MustAsync(NoDateConflict).WithMessage("There is a date and time conflict for the same doctor.");
        }

        private async Task<bool> NoDateConflict(MedicalCalendar calendar, CancellationToken cancellationToken)
        {
            return await ValidCOnflict(calendar, _entityRepository);
        }

        public static async Task<bool> ValidCOnflict(MedicalCalendar calendar, IMedicalCalendarRepository _entityRepository)
        {
            var existingCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(
                 calendar.MedicalId, calendar.StartDateTime, calendar.EndDateTime.GetValueOrDefault());

            var existsDates = existingCalendars.ToList().Exists(c => c.Id != calendar.Id &&
                                               c.StartDateTime < calendar.EndDateTime &&
                                               c.EndDateTime > calendar.StartDateTime);
            return !existsDates;
        } 
    } 
}