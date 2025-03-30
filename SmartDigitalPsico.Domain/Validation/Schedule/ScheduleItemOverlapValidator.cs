using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleItemOverlapValidator : AbstractValidator<ScheduleItemValidationContext>
    {
        public ScheduleItemOverlapValidator()
        {
            RuleFor(context => context)
                .Must(NoTimeSlotOverlap)
                .WithMessage("ScheduleItem_Validator_Overlap_Key|The schedule item overlaps with an existing item.");
        }

        private static bool NoTimeSlotOverlap(ScheduleItemValidationContext context)
        {
            if (context.ExistingItems == null || context.ExistingItems.Length > 0)
                return true;

            return !context.ExistingItems.Any(item => item.StartDateTime < context.NewItem?.EndDateTime && context.NewItem.StartDateTime < item.EndDateTime);
        }
    }

    public class ScheduleItemValidationContext
    {
        public ScheduleItem? NewItem { get; set; }
        public ScheduleItem[] ExistingItems { get; set; } = [];
        public long MedicalId { get; set; }
    }
}
