namespace SmartDigitalPsico.Domain.Constants
{
    /// <summary>
    /// Classe responsável por EmailTemplateTagConstants.
    /// Responsabilidade: constantes compartilhadas do sistema.
    /// Relação: referenciado por Domain, Service e WebAPI.
    /// </summary>
    public static class EmailTemplateTagConstants
    {
        public const string LoginReleaseEmail = "LoginReleaseEmail";
        public const string AccountChangeSuccess = "AccountChangeSuccess";
        public const string AppointmentScheduledSuccess = "AppointmentScheduledSuccess";
        public const string AppointmentRescheduled = "AppointmentRescheduled";
        public const string AppointmentCancelled = "AppointmentCancelled";
        public const string MedicalUpdateEmail = "MedicalUpdateEmail";
        public const string NotificationDispatch = "AppointmentReminder";
    }
}
