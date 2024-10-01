using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class AuditDataSelectiveEntityLogValidator : AbstractValidator<AuditDataSelectiveEntityLog>
    {
        public AuditDataSelectiveEntityLogValidator()
        {
            RuleFor(x => x.TableName)
            .NotEmpty()
            .WithMessage("TableName is required.")
            .MaximumLength(255)
            .WithMessage("TableName cannot exceed 255 characters.");

            RuleFor(x => x.Operation)
                .NotEmpty()
                .WithMessage("Operation is required.")
                .MaximumLength(20)
                .WithMessage("Operation cannot exceed 20 characters.");

            RuleFor(x => x.KeyValue)
                .NotEmpty()
                .WithMessage("KeyValue is required.")
                .MaximumLength(255)
                .WithMessage("KeyValue cannot exceed 255 characters.");

            RuleFor(x => x.OldValues)
                .NotEmpty()
                .WithMessage("OldValues is required.")
                .MaximumLength(8000)
                .WithMessage("OldValues cannot exceed 8000 characters.");

            RuleFor(x => x.NewValues)
                .NotEmpty()
                .WithMessage("NewValues is required.")
                .MaximumLength(8000)
                .WithMessage("NewValues cannot exceed 8000 characters.");

            RuleFor(x => x.UserAuditedLogin)
                .MaximumLength(255)
                .WithMessage("UserAuditedLogin cannot exceed 255 characters.")
                .When(x => x.UserAuditedLogin != null);

            RuleFor(x => x.RowKey)
                .MaximumLength(40)
                .WithMessage("RowKey cannot exceed 40 characters.")
                .When(x => x.RowKey != null);

            RuleFor(x => x.PartitionKey)
                .MaximumLength(40)
                .WithMessage("PartitionKey cannot exceed 40 characters.")
                .When(x => x.PartitionKey != null);
        }
    }
}