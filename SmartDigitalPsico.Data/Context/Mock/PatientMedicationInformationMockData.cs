using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Mock
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientMedicationInformationMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Description, string Dosage, string Posology, string MainDrug, DateTime Start, DateTime? End)[] Templates =
        [
            ("Ansiolítico", "0,5 mg", "1 comprimido à noite", "Clonazepam", new DateTime(2024, 2, 1, 0, 0, 0, DateTimeKind.Utc), null),
            ("Antidepressivo", "50 mg", "1 comprimido pela manhã", "Sertralina", new DateTime(2024, 5, 10, 0, 0, 0, DateTimeKind.Utc), null),
            ("Estimulante", "10 mg", "1 comprimido pela manhã", "Metilfenidato", new DateTime(2025, 1, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 20, 0, 0, 0, DateTimeKind.Utc))
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientMedicationInformation[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientMedicationInformation>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientMedicationInformation
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
                        Dosage = t.Dosage,
                        Posology = t.Posology,
                        MainDrug = t.MainDrug
                    });
                }
            }

            return [.. list];
        }
    }
}
