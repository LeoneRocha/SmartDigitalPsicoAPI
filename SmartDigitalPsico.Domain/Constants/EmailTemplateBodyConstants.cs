namespace SmartDigitalPsico.Domain.Constants
{
    /// <summary>
    /// Rich HTML email bodies (card layout). Header color differs per notification type.
    /// </summary>
    public static class EmailTemplateBodyConstants
    {
        // Header colors (one per notification type)
        public const string ColorLoginRelease = "rgba(0, 150, 136, 1)";       // teal
        public const string ColorAccountChange = "rgba(63, 81, 181, 1)";      // indigo
        public const string ColorAppointmentScheduled = "rgba(156, 39, 176, 1)"; // purple
        public const string ColorAppointmentRescheduled = "rgba(255, 152, 0, 1)"; // orange
        public const string ColorAppointmentCancelled = "rgba(244, 67, 54, 1)";  // red
        public const string ColorMedicalUpdate = "rgba(0, 188, 212, 1)";        // cyan
        public const string ColorAppointmentReminder = "rgba(33, 150, 243, 1)"; // blue

        public static string LoginReleaseEmail { get; } = BuildSimpleCard(
            ColorLoginRelease,
            "Acesso Concedido",
            "<p>Olá,</p><p>Seu acesso foi concedido com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string AccountChangeSuccess { get; } = BuildSimpleCard(
            ColorAccountChange,
            "Dados da Conta Atualizados",
            "<p>Olá,</p><p>Seus dados da conta foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string AppointmentScheduledSuccess { get; } = BuildAppointmentCard(
            ColorAppointmentScheduled,
            "Consulta Confirmada",
            "Sua consulta com o(a) médico(a) [{MedicalName}] foi confirmada.",
            "Confira os detalhes e organize-se para comparecer no horário agendado:",
            "Data de Início",
            "Data de Término",
            "Se precisar de mais informações, entre em contato conosco.");

        public static string AppointmentRescheduled { get; } = BuildAppointmentCard(
            ColorAppointmentRescheduled,
            "Consulta Remarcada",
            "Sua consulta com o(a) médico(a) [{MedicalName}] foi remarcada.",
            "Confira os novos detalhes abaixo:",
            "Nova Data de Início",
            "Nova Data de Término",
            "Por favor, confirme sua disponibilidade para o novo horário.");

        public static string AppointmentCancelled { get; } = BuildAppointmentCard(
            ColorAppointmentCancelled,
            "Consulta Cancelada",
            "Informamos que sua consulta com o(a) médico(a) [{MedicalName}] foi cancelada.",
            "Confira os dados da consulta cancelada:",
            "Data de Início",
            "Data de Término",
            "Se desejar reagendar ou obter mais informações, entre em contato conosco.");

        public static string MedicalUpdateEmail { get; } = BuildSimpleCard(
            ColorMedicalUpdate,
            "Dados Médicos Atualizados",
            "<p>Olá,</p><p>Seus dados médicos foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string NotificationDispatch { get; } = BuildAppointmentCard(
            ColorAppointmentReminder,
            "Lembrete de Consulta",
            "Este é um lembrete da sua consulta com o(a) médico(a) [{MedicalName}].",
            "Confira os detalhes e organize-se para comparecer no horário agendado:",
            "Data de Início",
            "Data de Término",
            "Se precisar de mais informações, entre em contato conosco.");

        public static string? TryGetRichBody(string templateKey, string? currentBody)
        {
            if (string.IsNullOrWhiteSpace(templateKey))
                return null;

            var canonical = Resolve(templateKey);
            if (canonical == null)
                return null;

            // Upgrade short/legacy seed bodies, or any body missing tokens / wrong color set.
            var needsUpgrade = string.IsNullOrWhiteSpace(currentBody)
                || currentBody.Length < 200
                || !currentBody.Contains("[{PatientName}]", StringComparison.Ordinal)
                || !currentBody.Contains("border-radius:10px", StringComparison.Ordinal);

            return needsUpgrade ? canonical : null;
        }

        public static string? Resolve(string templateKey) => templateKey switch
        {
            EmailTemplateTagConstants.LoginReleaseEmail => LoginReleaseEmail,
            EmailTemplateTagConstants.AccountChangeSuccess => AccountChangeSuccess,
            EmailTemplateTagConstants.AppointmentScheduledSuccess => AppointmentScheduledSuccess,
            EmailTemplateTagConstants.AppointmentRescheduled => AppointmentRescheduled,
            EmailTemplateTagConstants.AppointmentCancelled => AppointmentCancelled,
            EmailTemplateTagConstants.MedicalUpdateEmail => MedicalUpdateEmail,
            EmailTemplateTagConstants.NotificationDispatch => NotificationDispatch,
            _ => null
        };

        private static string BuildAppointmentCard(
            string headerColor,
            string headerTitle,
            string introLine,
            string detailsLead,
            string startLabel,
            string endLabel,
            string closing)
        {
            var inner =
                $"<p>Olá, [{{PatientName}}],</p>" +
                $"<p>{introLine}</p>" +
                $"<p>{detailsLead}</p>" +
                "<ul>" +
                "<li><strong>Título:</strong> [{Title}]</li>" +
                $"<li><strong>{startLabel}:</strong> [{{StartDateTime}}]</li>" +
                $"<li><strong>{endLabel}:</strong> [{{EndDateTime}}]</li>" +
                "<li><strong>Local:</strong> [{AppointmentLocation}]</li>" +
                "</ul>" +
                "<p><strong>Observação:</strong> [{Description}]</p>" +
                $"<p>{closing}</p>";

            return BuildSimpleCard(headerColor, headerTitle, inner);
        }

        private static string BuildSimpleCard(string headerColor, string headerTitle, string bodyHtml)
        {
            return
                "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\">" +
                "<div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\">" +
                $"<div style=\"background-color:{headerColor};padding:20px;text-align:center;\">" +
                $"<h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">{headerTitle}</h1>" +
                "</div>" +
                $"<div style=\"padding:20px;\">{bodyHtml}</div>" +
                "</div>" +
                "</div>";
        }
    }
}
