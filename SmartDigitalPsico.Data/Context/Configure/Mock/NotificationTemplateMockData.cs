using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class NotificationTemplateMockData
    {

        public static NotificationTemplate[] GetMocks()
        {

            var mocksInitial = GetMockInitial().ToList();

            List<NotificationTemplate> notificationTemplates = new List<NotificationTemplate>();
            notificationTemplates.AddRange(mocksInitial);
            //notificationTemplates.AddRange(mocksAppointment);

            return notificationTemplates.ToArray();

        }
        public static NotificationTemplate[] GetMockInitial()
        {
            return new NotificationTemplate[]
            {
        new NotificationTemplate
        {
            Id = 1,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Liberar Login",
            Subject = "Acesso Concedido",
            Body = "<p>Seu acesso foi concedido com sucesso.</p>",
            TagApi = EmailTemplateTagConstants.LoginReleaseEmail,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 2,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Alteração de Conta Concluída",
            Subject = "Dados da Conta Atualizados",
            Body = "<p>Seus dados da conta foram atualizados com sucesso.</p>",
            TagApi = EmailTemplateTagConstants.AccountChangeSuccess,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 3,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Consulta Agendada",
            Subject = "Sua Consulta Foi Agendada",
            Body = "<p>Sua consulta foi agendada com sucesso.</p>",
            TagApi = EmailTemplateTagConstants.AppointmentScheduledSuccess,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 4,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Consulta Remarcada",
            Subject = "Sua Consulta Foi Remarcada",
            Body = "<p>Sua consulta foi remarcada com sucesso.</p>",
            TagApi = EmailTemplateTagConstants.AppointmentRescheduled,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 5,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Consulta Cancelada",
            Subject = "Sua Consulta Foi Cancelada",
            Body = "<p>Sua consulta foi cancelada.</p>",
            TagApi = EmailTemplateTagConstants.AppointmentCancelled,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 6,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Atualização de Cadastro Médico",
            Subject = "Dados Médicos Atualizados",
            Body = "<p>Seus dados médicos foram atualizados com sucesso.</p>",
            TagApi = EmailTemplateTagConstants.MedicalUpdateEmail,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        },
        new NotificationTemplate
        {
            Id = 7,
            Enable = true,
            Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
            Description = "Lembrete de Consulta",
            Subject = "Lembrete de Consulta Agendada",
            Body = "<p>Este é um lembrete para sua consulta agendada.</p>",
            TagApi = EmailTemplateTagConstants.NotificationDispatch,
            NotificationTemplateType=  ENotificationServiceType.Email,
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
        }
            };
        }
    }
}