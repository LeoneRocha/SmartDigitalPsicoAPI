using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por EMaritalStatus.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum EMaritalStatus
    {
        [Description("Single")]
        Single = 0,

        [Description("Married")]
        Married = 1,

        [Description("Divorced")]
        Divorced = 2,

        [Description("Other")]
        Other = 10,
    }
}
