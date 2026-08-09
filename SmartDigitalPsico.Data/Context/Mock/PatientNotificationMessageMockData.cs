using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Mock
{
    /// <summary>
    /// Classe responsável por PatientNotificationMessageMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientNotificationMessageMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Message, bool IsReaded, bool Notified)[] Templates =
        [
            ("Lembrete: sua consulta está agendada para amanhã às 10h.", true, true),
            ("Por favor, confirme a presença na sessão da próxima semana.", false, true),
            ("Nova mensagem do seu profissional de saúde disponível.", false, false)
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientNotificationMessage[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientNotificationMessage>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientNotificationMessage
                    {
                        Id = id++,
                        Enable = true,
                        CreatedDate = SeedDate,
                        ModifyDate = SeedDate,
                        LastAccessDate = SeedDate,
                        CreatedUserId = 2,
                        PatientId = patient.Id,
                        MessagePatient = $"{t.Message} ({patient.Name})",
                        IsReaded = t.IsReaded,
                        ReadingDate = t.IsReaded ? SeedDate : null,
                        Notified = t.Notified,
                        NotifiedDate = t.Notified ? SeedDate : null
                    });
                }
            }

            return [.. list];
        }
    }
}
