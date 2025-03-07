using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class NotificationRulesMockData
    {
        private const string LanguagePtBR = "pt-BR";

        public static NotificationRule[] GetMock()
        {
            return new[]
            {
            // Envio 24 horas antes do agendamento
            new NotificationRule
            {
                Id = 1,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Hours,
                IntervalValue = 24,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Envio 24 horas antes do agendamento",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.BeforeAppointment,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            },
            // Envio 3 dias antes do agendamento
            new NotificationRule
            {
                Id = 2,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Days,
                IntervalValue = 3,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Envio 3 dias antes do agendamento",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.BeforeAppointment,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            },
            // Envio 1 hora antes do agendamento
            new NotificationRule
            {
                Id = 3,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Hours,
                IntervalValue = 1,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Envio 1 hora antes do agendamento",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.BeforeAppointment,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            },
            // Envio 15 minutos antes do agendamento
            new NotificationRule
            {
                Id = 4,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Minutes,
                IntervalValue = 15,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Envio 15 minutos antes do agendamento",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.BeforeAppointment,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            }, 
            // Lembrete de pagamento (3 dias antes do vencimento)
            new NotificationRule
            {
                Id = 5,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Days,
                IntervalValue = 3,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Lembrete de pagamento (3 dias antes do vencimento)",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.PaymentReminder,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            },       
            // Envio 48 horas antes do agendamento
            new NotificationRule
            {
                Id = 6,
                Enable = true,
                MedicalId = 1,
                IsEnabled = true,
                IntervalType = EIntervalNotificationType.Hours,
                IntervalValue = 48,
                IsBefore = true,
                ENotificationServiceType = new [] { ENotificationServiceType.Email },
                Description = "Envio 48 horas antes do agendamento",
                Language = LanguagePtBR,
                NotificationType = ENotificationType.BeforeAppointment,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            },
        };
        }
    }
}
