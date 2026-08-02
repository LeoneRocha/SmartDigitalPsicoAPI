using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleItemValidationContextValidator : AbstractValidator<ScheduleItemValidationContext>
    {
        public ScheduleItemValidationContextValidator()
        {
            RuleFor(context => context)
                .Must(NoTimeSlotOverlap)
                .WithErrorCode("SmartDigitalPsico.ScheduleItemValidationContextValidator.ScheduleItemValidationContext.Entity.Must")
                .WithMessage("ScheduleItem_Validator_Overlap_Key|The schedule item overlaps with an existing item.");
        }

        private static bool NoTimeSlotOverlap(ScheduleItemValidationContext context)
        {
            if (context.ExistingItems == null || context.ExistingItems.Length > 0)
                return true;

            return !context.ExistingItems.Any(item => item.StartDateTime < context.NewItem?.EndDateTime && context.NewItem.StartDateTime < item.EndDateTime);
        }
    } 
}
