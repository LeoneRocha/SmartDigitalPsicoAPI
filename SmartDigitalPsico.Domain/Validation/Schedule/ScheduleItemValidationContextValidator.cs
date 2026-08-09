using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por ScheduleItemValidationContextValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class ScheduleItemValidationContextValidator : AbstractValidator<ScheduleItemValidationContext>
    {
        /// <summary>
        /// Método ScheduleItemValidationContextValidator: operação de agendamento.
        /// </summary>
        public ScheduleItemValidationContextValidator()
        {
            RuleFor(context => context)
                .Must(NoTimeSlotOverlap)
                .WithErrorCode("SmartDigitalPsico.ScheduleItemValidationContextValidator.ScheduleItemValidationContext.Entity.Must")
                .WithMessage("ScheduleItem_Validator_Overlap_Key|The schedule item overlaps with an existing item.");
        }

        private static bool NoTimeSlotOverlap(ScheduleItemValidationContext context)
        {
            if (context.ExistingItems == null || context.ExistingItems.Length == 0)
                return true;

            var newItem = context.NewItem;
            if (newItem == null)
                return true;

            return !context.ExistingItems.Any(item =>
                item.StartDateTime < newItem.EndDateTime &&
                newItem.StartDateTime < item.EndDateTime);
        }
    }
}
