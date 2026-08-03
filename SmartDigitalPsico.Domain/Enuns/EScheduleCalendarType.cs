using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por EScheduleCalendarType.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum EScheduleCalendarType
    {
        [Description("Schedule")]
        Schedule = 0,

        [Description("Cancellation")]
        Cancellation = 1
    }
}
