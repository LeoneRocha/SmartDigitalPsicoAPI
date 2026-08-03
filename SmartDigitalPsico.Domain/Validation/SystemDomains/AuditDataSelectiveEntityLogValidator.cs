using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class AuditDataSelectiveEntityLogValidator : AbstractValidator<AuditDataSelectiveEntityLog>
    {
        /// <summary>
        /// Método AuditDataSelectiveEntityLogValidator: executa a operação AuditDataSelectiveEntityLogValidator.
        /// </summary>
        public AuditDataSelectiveEntityLogValidator()
        {
            RuleFor(x => x.TableName)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.TableName.NotEmpty")
                .WithMessage("TableName_Validator_IsRequired_Key|TableName is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.TableName.MaxLength")
                .WithMessage("TableName_Validator_MaxLength_Key|TableName cannot exceed {0} characters.|255");

            RuleFor(x => x.Operation)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.Operation.NotEmpty")
                .WithMessage("Operation_Validator_IsRequired_Key|Operation is required.")
                .MaximumLength(20)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.Operation.MaxLength")
                .WithMessage("Operation_Validator_MaxLength_Key|Operation cannot exceed {0} characters.|20");

            RuleFor(x => x.KeyValue)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.KeyValue.NotEmpty")
                .WithMessage("KeyValue_Validator_IsRequired_Key|KeyValue is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.KeyValue.MaxLength")
                .WithMessage("KeyValue_Validator_MaxLength_Key|KeyValue cannot exceed {0} characters.|255");

            RuleFor(x => x.OldValues)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.OldValues.NotEmpty")
                .WithMessage("OldValues_Validator_IsRequired_Key|OldValues is required.")
                .MaximumLength(8000)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.OldValues.MaxLength")
                .WithMessage("OldValues_Validator_MaxLength_Key|OldValues cannot exceed {0} characters.|8000");

            RuleFor(x => x.NewValues)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.NewValues.NotEmpty")
                .WithMessage("NewValues_Validator_IsRequired_Key|NewValues is required.")
                .MaximumLength(8000)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.NewValues.MaxLength")
                .WithMessage("NewValues_Validator_MaxLength_Key|NewValues cannot exceed {0} characters.|8000");

            RuleFor(x => x.UserAuditedLogin)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.UserAuditedLogin.MaxLength")
                .WithMessage("UserAuditedLogin_Validator_MaxLength_Key|UserAuditedLogin cannot exceed {0} characters.|255")
                .When(x => x.UserAuditedLogin != null);

            RuleFor(x => x.RowKey)
                .MaximumLength(40)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.RowKey.MaxLength")
                .WithMessage("RowKey_Validator_MaxLength_Key|RowKey cannot exceed {0} characters.|40")
                .When(x => x.RowKey != null);

            RuleFor(x => x.PartitionKey)
                .MaximumLength(40)
                .WithErrorCode("SmartDigitalPsico.AuditDataSelectiveEntityLogValidator.AuditDataSelectiveEntityLog.PartitionKey.MaxLength")
                .WithMessage("PartitionKey_Validator_MaxLength_Key|PartitionKey cannot exceed {0} characters.|40")
                .When(x => x.PartitionKey != null);
        }
    }
}
