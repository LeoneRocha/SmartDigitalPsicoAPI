using DocumentFormat.OpenXml.Spreadsheet;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalCalendarValidator : MedicalBaseValidator<MedicalCalendar>
    {
        private readonly IMedicalCalendarRepository _repository;
        private readonly IMedicalRepository _repositoryMedical;

        public MedicalCalendarValidator(IConfiguration configuration, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {
            _repository = entityRepository;
            _repositoryMedical = medicalRepository;

            #region Columns
            RuleFor(e => e.Title)
                .NotEmpty()
                .WithMessage("Title is required.")
                .MaximumLength(100)
                .WithMessage("Title cannot exceed 100 characters.");

            RuleFor(e => e.StartDateTime)
                .NotEmpty()
                .WithMessage("Start date and time is required.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), startDateTime))
                .WithMessage("Start date and time must be in the future.")
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithMessage("Start time must be before end time.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, startDateTime))
                .WithMessage("Start date and time must be on a working day for the doctor.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, startDateTime))
                .WithMessage("Start time must be within the doctor's working hours.");

            RuleFor(e => e.EndDateTime)
                .NotEmpty()
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), endDateTime))
                .When(e => e.EndDateTime.HasValue)
                .WithMessage("End date and time must be in the future.")
                .GreaterThan(e => e.StartDateTime)
                .WithMessage("End date and time must be after start date and time.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithMessage("End date and time must be on a working day for the doctor.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithMessage("End time must be within the doctor's working hours.");

            RuleFor(e => e.Status)
                .IsInEnum()
                .WithMessage("Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50)
                .WithMessage("Color category cannot exceed 50 characters.");

            RuleFor(e => e.TokenRecurrence)
                .MaximumLength(40)
                .WithMessage("Token Recurrence cannot exceed 40 characters.");

            RuleFor(e => e.TimeZone)
                .NotEmpty()
                .WithMessage("Time zone is required.")
                .MaximumLength(150)
                .WithMessage("Time zone cannot exceed 150 characters.");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays)
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithMessage("Invalid recurrence days.")
                .MustAsync(async (e, recurrenceDays, cancellationToken) => await BeInWorkingDays(e.MedicalId, recurrenceDays))
                .WithMessage("Recurrence days must be on working days for the doctor.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum()
                .WithMessage("Invalid recurrence type.");

            // Validação para RecurrenceCount
            RuleFor(e => e.RecurrenceCount)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("RecurrenceCount is required.")
                .InclusiveBetween((short)0, (short)999)
                .WithMessage("RecurrenceCount must be between 0 and 999.");

            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithMessage("ErrorValidator_PatientId_Null");

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

            RuleFor(x => x)
                .MustAsync(NoScheduleConflict)
                .WithMessage("There is a scheduling conflict for the specified time.");
        }

        private async Task<bool> BeFutureDateTime(long userId, DateTime dateTime)
        {
            var user = await _userRepository.FindByID(userId);
            var dateCurrent = DateHelper.ApplyTimeZone(DateTime.UtcNow, user.TimeZone);

            return dateTime > dateCurrent;
        }

        private async Task<bool> BeFutureDateTime(long userId, DateTime? dateTime)
        {
            var user = await _userRepository.FindByID(userId);
            var dateCurrent = DateHelper.ApplyTimeZone(DateTime.UtcNow, user.TimeZone);
            return dateTime.HasValue && dateTime.Value > dateCurrent;
        }

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
        {
            return recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(typeof(DayOfWeek), day));
        }

        private async Task<bool> BeInWorkingDays(long medicalId, DateTime dateTime)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            return medical.WorkingDays.Contains(dateTime.DayOfWeek);
        }

        private async Task<bool> BeInWorkingDays(long medicalId, DayOfWeek[] recurrenceDays)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            return recurrenceDays.All(day => medical.WorkingDays.Contains(day));
        }

        private async Task<bool> BeInWorkingHours(long medicalId, DateTime dateTime)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            var timeOfDay = dateTime.TimeOfDay;
            return timeOfDay >= medical.StartWorkingTime && timeOfDay <= medical.EndWorkingTime;
        }

        private async Task<bool> NoScheduleConflict(MedicalCalendar calendar, CancellationToken cancellationToken)
        {
            return await MedicalCalendarRangeValidator.ValidConflict(calendar, _repository);
        }
    }
}
