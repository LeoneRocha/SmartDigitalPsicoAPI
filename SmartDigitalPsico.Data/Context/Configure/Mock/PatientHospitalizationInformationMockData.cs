using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientHospitalizationInformationMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Description, string Cid, string Observation, DateTime Start, DateTime? End)[] Templates =
        [
            ("Internação psiquiátrica breve", "F41.1", "Alta com acompanhamento ambulatorial semanal.", new DateTime(2024, 3, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 3, 20, 0, 0, 0, DateTimeKind.Utc)),
            ("Observação clínica", "F32.1", "Estabilização do humor após ajuste medicamentoso.", new DateTime(2024, 6, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 6, 5, 0, 0, 0, DateTimeKind.Utc)),
            ("Internação para avaliação diagnóstica", "F90.0", "Em avaliação multidisciplinar.", new DateTime(2025, 1, 15, 0, 0, 0, DateTimeKind.Utc), null)
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientHospitalizationInformation[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientHospitalizationInformation>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientHospitalizationInformation
                    {
                        Id = id++,
                        Enable = true,
                        CreatedDate = SeedDate,
                        ModifyDate = SeedDate,
                        LastAccessDate = SeedDate,
                        CreatedUserId = 2,
                        PatientId = patient.Id,
                        Description = $"{t.Description} - {patient.Name}",
                        StartDate = t.Start,
                        EndDate = t.End,
                        CID = t.Cid,
                        Observation = t.Observation
                    });
                }
            }

            return [.. list];
        }
    }
}
