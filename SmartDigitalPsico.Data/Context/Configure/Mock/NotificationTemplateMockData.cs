using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using EmailTemplateBodyConstants = SmartDigitalPsico.Domain.Constants.EmailTemplateBodyConstants;
using EmailTemplateTagConstants = SmartDigitalPsico.Domain.Constants.EmailTemplateTagConstants;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por NotificationTemplateMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class NotificationTemplateMockData
    {
        /// <summary>
        /// Método GetMocks: consulta e retorna dados.
        /// </summary>
        public static NotificationTemplate[] GetMocks()
        {
            var mocksInitial = GetMockInitial().ToList();
            List<NotificationTemplate> notificationTemplates = new List<NotificationTemplate>();
            notificationTemplates.AddRange(mocksInitial);
            return notificationTemplates.ToArray();
        }

        /// <summary>
        /// Método GetMockInitial: consulta e retorna dados.
        /// </summary>
        public static NotificationTemplate[] GetMockInitial()
        {
            return
            [
                Build(
                    id: 1,
                    description: "Liberar Login",
                    subject: "Acesso Concedido",
                    body: EmailTemplateBodyConstants.LoginReleaseEmail,
                    templateKey: EmailTemplateTagConstants.LoginReleaseEmail),
                Build(
                    id: 2,
                    description: "Alteração de Conta Concluída",
                    subject: "Dados da Conta Atualizados",
                    body: EmailTemplateBodyConstants.AccountChangeSuccess,
                    templateKey: EmailTemplateTagConstants.AccountChangeSuccess),
                Build(
                    id: 3,
                    description: "Consulta Agendada",
                    subject: "Sua Consulta Foi Agendada",
                    body: EmailTemplateBodyConstants.AppointmentScheduledSuccess,
                    templateKey: EmailTemplateTagConstants.AppointmentScheduledSuccess),
                Build(
                    id: 4,
                    description: "Consulta Remarcada",
                    subject: "Sua Consulta Foi Remarcada",
                    body: EmailTemplateBodyConstants.AppointmentRescheduled,
                    templateKey: EmailTemplateTagConstants.AppointmentRescheduled),
                Build(
                    id: 5,
                    description: "Consulta Cancelada",
                    subject: "Sua Consulta Foi Cancelada",
                    body: EmailTemplateBodyConstants.AppointmentCancelled,
                    templateKey: EmailTemplateTagConstants.AppointmentCancelled),
                Build(
                    id: 6,
                    description: "Atualização de Cadastro Médico",
                    subject: "Dados Médicos Atualizados",
                    body: EmailTemplateBodyConstants.MedicalUpdateEmail,
                    templateKey: EmailTemplateTagConstants.MedicalUpdateEmail),
                Build(
                    id: 7,
                    description: "Lembrete de Consulta",
                    subject: "Lembrete de Consulta Agendada",
                    body: EmailTemplateBodyConstants.NotificationDispatch,
                    templateKey: EmailTemplateTagConstants.NotificationDispatch)
            ];
        }

        private static NotificationTemplate Build(long id, string description, string subject, string body, string templateKey)
            => new()
            {
                Id = id,
                Enable = true,
                Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
                Description = description,
                Subject = subject,
                Body = body,
                TemplateKey = templateKey,
                NotificationTemplateType = ENotificationServiceType.Email,
                CreatedDate = MockSeedDates.SeedUtc,
                ModifyDate = MockSeedDates.SeedUtc,
                LastAccessDate = MockSeedDates.SeedUtc
            };
    }
}
