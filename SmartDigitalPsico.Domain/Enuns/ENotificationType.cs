namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ENotificationType.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum ENotificationType
    {
        BeforeAppointment, // Aviso antes do agendamento
        AfterAppointment,  // Lembrete pós-agendamento
        PaymentReminder    // Notificação relacionada a pagamentos
    }

}
