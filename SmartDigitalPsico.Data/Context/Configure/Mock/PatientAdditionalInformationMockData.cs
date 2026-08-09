using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientAdditionalInformationMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Psychiatric, string Neurological)[] Templates =
        [
            ("Acompanhamento psiquiátrico mensal em andamento.", "Sem intercorrências neurológicas relatadas."),
            ("Histórico de crise de ansiedade; em estabilização.", "Avaliação neurológica prévia sem alterações."),
            ("Orientado sobre adesão medicamentosa e sono.", "Encaminhado para reavaliação se houver cefaleia persistente.")
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientAdditionalInformation[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientAdditionalInformation>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientAdditionalInformation
                    {
                        Id = id++,
                        Enable = true,
                        CreatedDate = SeedDate,
                        ModifyDate = SeedDate,
                        LastAccessDate = SeedDate,
                        CreatedUserId = 2,
                        PatientId = patient.Id,
                        FollowUp_Psychiatric = $"{t.Psychiatric} ({patient.Name})",
                        FollowUp_Neurological = $"{t.Neurological} ({patient.Name})"
                    });
                }
            }

            return [.. list];
        }
    }
}
