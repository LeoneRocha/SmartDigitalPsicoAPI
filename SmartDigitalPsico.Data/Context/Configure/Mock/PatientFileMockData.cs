using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por PatientFileMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class PatientFileMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        private static readonly (string Description, string FileName, string Extension, string ContentType, long SizeKb)[] Templates =
        [
            ("Termo de consentimento", "termo-consentimento.pdf", "pdf", "application/pdf", 120),
            ("Exame laboratorial", "exame-lab.pdf", "pdf", "application/pdf", 340),
            ("Documento de identificação", "identificacao.png", "png", "image/png", 85)
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static PatientFile[] GetMock()
        {
            var patients = PatientMockData.GetMock();
            var list = new List<PatientFile>(patients.Length * Templates.Length);
            long id = 1;

            foreach (var patient in patients)
            {
                for (var i = 0; i < Templates.Length; i++)
                {
                    var t = Templates[i];
                    list.Add(new PatientFile
                    {
                        Id = id++,
                        Enable = true,
                        CreatedDate = SeedDate,
                        ModifyDate = SeedDate,
                        LastAccessDate = SeedDate,
                        CreatedUserId = 2,
                        PatientId = patient.Id,
                        Description = $"{t.Description} - {patient.Name}",
                        FileName = $"p{patient.Id}-{t.FileName}",
                        FilePath = $"/mock/patient/{patient.Id}/{t.FileName}",
                        FileData = [],
                        FileExtension = t.Extension,
                        FileContentType = t.ContentType,
                        FileSizeKB = t.SizeKb,
                        TypeLocationSaveFile = ETypeLocationSaveFiles.Disk,
                        FileCloudContainer = string.Empty,
                        FileBlobName = string.Empty
                    });
                }
            }

            return [.. list];
        }
    }
}
