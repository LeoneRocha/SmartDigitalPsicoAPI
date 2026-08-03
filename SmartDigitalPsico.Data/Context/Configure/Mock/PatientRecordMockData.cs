using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por PatientRecordMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientRecordMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Description, string Annotation, DateTime AnnotationDate)[] Templates =
        [
            ("Sessão inicial", "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, DateTimeKind.Utc)),
            ("Acompanhamento", "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, DateTimeKind.Utc)),
            ("Avaliação diagnóstica", "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, DateTimeKind.Utc))
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientRecord[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientRecord>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientRecord
                    {
                        Id = id++,
                        Enable = true,
                        CreatedDate = SeedDate,
                        ModifyDate = SeedDate,
                        LastAccessDate = SeedDate,
                        CreatedUserId = 2,
                        PatientId = patient.Id,
                        Description = $"{t.Description} - {patient.Name}",
                        Annotation = t.Annotation,
                        AnnotationDate = t.AnnotationDate,
                        TableStorageRowKey = string.Empty
                    });
                }
            }

            return [.. list];
        }
    }
}
