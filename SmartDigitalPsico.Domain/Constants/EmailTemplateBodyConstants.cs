namespace SmartDigitalPsico.Domain.Constants
{
    /// <summary>
    /// Rich HTML email bodies (card layout).
    /// Each notification type has a distinct page background-color and header color.
    /// </summary>
    public static class EmailTemplateBodyConstants
    {
        // Header colors (strong accent)
        public const string HeaderLoginRelease = "rgba(0, 150, 136, 1)";           // teal
        public const string HeaderAccountChange = "rgba(63, 81, 181, 1)";          // indigo
        public const string HeaderAppointmentScheduled = "rgba(156, 39, 176, 1)";  // purple
        public const string HeaderAppointmentRescheduled = "rgba(255, 152, 0, 1)"; // orange
        public const string HeaderAppointmentCancelled = "rgba(244, 67, 54, 1)";   // red
        public const string HeaderMedicalUpdate = "rgba(0, 188, 212, 1)";          // cyan
        public const string HeaderAppointmentReminder = "rgba(33, 150, 243, 1)";   // blue

        // Page background colors (soft tint matching each type — visible in Body column / email chrome)
        public const string BgLoginRelease = "rgba(224, 242, 241, 1)";             // teal tint
        public const string BgAccountChange = "rgba(232, 234, 246, 1)";            // indigo tint
        public const string BgAppointmentScheduled = "rgba(243, 229, 245, 1)";     // purple tint
        public const string BgAppointmentRescheduled = "rgba(255, 243, 224, 1)";   // orange tint
        public const string BgAppointmentCancelled = "rgba(255, 235, 238, 1)";     // red tint
        public const string BgMedicalUpdate = "rgba(224, 247, 250, 1)";            // cyan tint
        public const string BgAppointmentReminder = "rgba(227, 242, 253, 1)";      // blue tint

        public static string LoginReleaseEmail { get; } = BuildSimpleCard(
            BgLoginRelease,
            HeaderLoginRelease,
            "Acesso Concedido",
            "<p>Olá,</p><p>Seu acesso foi concedido com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string AccountChangeSuccess { get; } = BuildSimpleCard(
            BgAccountChange,
            HeaderAccountChange,
            "Dados da Conta Atualizados",
            "<p>Olá,</p><p>Seus dados da conta foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string AppointmentScheduledSuccess { get; } = BuildAppointmentCard(
            BgAppointmentScheduled,
            HeaderAppointmentScheduled,
            "Consulta Confirmada",
            "Sua consulta com o(a) médico(a) [{MedicalName}] foi confirmada.",
            "Confira os detalhes e organize-se para comparecer no horário agendado:",
            "Data de Início",
            "Data de Término",
            "Se precisar de mais informações, entre em contato conosco.");

        public static string AppointmentRescheduled { get; } = BuildAppointmentCard(
            BgAppointmentRescheduled,
            HeaderAppointmentRescheduled,
            "Consulta Remarcada",
            "Sua consulta com o(a) médico(a) [{MedicalName}] foi remarcada.",
            "Confira os novos detalhes abaixo:",
            "Nova Data de Início",
            "Nova Data de Término",
            "Por favor, confirme sua disponibilidade para o novo horário.");

        public static string AppointmentCancelled { get; } = BuildAppointmentCard(
            BgAppointmentCancelled,
            HeaderAppointmentCancelled,
            "Consulta Cancelada",
            "Informamos que sua consulta com o(a) médico(a) [{MedicalName}] foi cancelada.",
            "Confira os dados da consulta cancelada:",
            "Data de Início",
            "Data de Término",
            "Se desejar reagendar ou obter mais informações, entre em contato conosco.");

        public static string MedicalUpdateEmail { get; } = BuildSimpleCard(
            BgMedicalUpdate,
            HeaderMedicalUpdate,
            "Dados Médicos Atualizados",
            "<p>Olá,</p><p>Seus dados médicos foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p>");

        public static string NotificationDispatch { get; } = BuildAppointmentCard(
            BgAppointmentReminder,
            HeaderAppointmentReminder,
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

            var needsUpgrade = string.IsNullOrWhiteSpace(currentBody)
                || currentBody.Length < 200
                || !currentBody.Contains("[{PatientName}]", StringComparison.Ordinal)
                || !currentBody.Contains("border-radius:10px", StringComparison.Ordinal)
                || currentBody.Contains("background-color:rgba(244, 244, 249, 1)", StringComparison.Ordinal);

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
            string pageBackgroundColor,
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

            return BuildSimpleCard(pageBackgroundColor, headerColor, headerTitle, inner);
        }

        private static string BuildSimpleCard(
            string pageBackgroundColor,
            string headerColor,
            string headerTitle,
            string bodyHtml)
        {
            return
                $"<div style=\"font-family:Arial, sans-serif;background-color:{pageBackgroundColor};padding:20px;\">" +
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
