namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por EMedicalCalendarActionType.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum EMedicalCalendarActionType
    {
        Add,
        Update,
        Delete,
        Cancelled,
        Rescheduled,
        Scheduled,
        Refused,
        NotificationDispatch,
    }

}
