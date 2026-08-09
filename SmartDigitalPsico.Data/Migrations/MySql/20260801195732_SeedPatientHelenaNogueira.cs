using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por SeedPatientHelenaNogueira.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class SeedPatientHelenaNogueira : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 8L, "30130-010", "Belo Horizonte", "Funcionários", "Minas Gerais", "Rua da Bahia, 1200", "321.654.987-00", new DateTime(2026, 8, 1, 12, 0, 0, 0, DateTimeKind.Utc), 2L, new DateTime(1995, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Superior Completo", "helena.nogueira@example.com", "Paulo Nogueira", "(31) 98765-4321", true, 2L, new DateTime(2026, 8, 1, 12, 0, 0, 0, DateTimeKind.Utc), (byte)0, 1L, new DateTime(2026, 8, 1, 12, 0, 0, 0, DateTimeKind.Utc), null, "Helena Beatriz Nogueira", "(31) 3222-1100", "Psicóloga", "MG-12.345.678" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientAdditionalInformation",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Enable", "FollowUp_Neurological", "FollowUp_Psychiatric", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId" },
                values: new object[,]
                {
                    { 22L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Helena Beatriz Nogueira)", "Acompanhamento psiquiátrico mensal em andamento. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L },
                    { 23L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Helena Beatriz Nogueira)", "Histórico de crise de ansiedade; em estabilização. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L },
                    { 24L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Helena Beatriz Nogueira)", "Orientado sobre adesão medicamentosa e sono. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientFile",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "Enable", "FileBlobName", "FileCloudContainer", "FileContentType", "FileData", "FileExtension", "FileName", "FilePath", "FileSizeKB", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId", "TypeLocationSaveFile" },
                values: new object[,]
                {
                    { 22L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Helena Beatriz Nogueira", true, "", "", "application/pdf", new byte[0], "pdf", "p8-termo-consentimento.pdf", "/mock/patient/8/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, (byte)1 },
                    { 23L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Helena Beatriz Nogueira", true, "", "", "application/pdf", new byte[0], "pdf", "p8-exame-lab.pdf", "/mock/patient/8/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, (byte)1 },
                    { 24L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Helena Beatriz Nogueira", true, "", "", "image/png", new byte[0], "png", "p8-identificacao.png", "/mock/patient/8/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, (byte)1 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                columns: new[] { "Id", "CID", "CreatedDate", "CreatedUserId", "Description", "Enable", "EndDate", "LastAccessDate", "ModifyDate", "ModifyUserId", "Observation", "PatientId", "StartDate" },
                values: new object[,]
                {
                    { 22L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Helena Beatriz Nogueira", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 8L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Helena Beatriz Nogueira", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 8L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Helena Beatriz Nogueira", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 8L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientInfoTag",
                columns: new[] { "InfoTagId", "PatientId" },
                values: new object[,]
                {
                    { 1L, 8L },
                    { 2L, 8L },
                    { 3L, 8L }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientMedicationInformation",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "Dosage", "Enable", "EndDate", "LastAccessDate", "MainDrug", "ModifyDate", "ModifyUserId", "PatientId", "Posology", "StartDate" },
                values: new object[,]
                {
                    { 22L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Helena Beatriz Nogueira", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Helena Beatriz Nogueira", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Helena Beatriz Nogueira", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientNotificationMessage",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Enable", "IsReaded", "LastAccessDate", "MessagePatient", "ModifyDate", "ModifyUserId", "Notified", "NotifiedDate", "PatientId", "ReadingDate" },
                values: new object[,]
                {
                    { 22L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 8L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 23L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 8L, null },
                    { 24L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Helena Beatriz Nogueira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 8L, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientRecord",
                columns: new[] { "Id", "Annotation", "AnnotationDate", "CreatedDate", "CreatedUserId", "Description", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId", "TableStorageRowKey" },
                values: new object[,]
                {
                    { 22L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Helena Beatriz Nogueira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "" },
                    { 23L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Helena Beatriz Nogueira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "" },
                    { 24L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Helena Beatriz Nogueira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 8L, "" }
                });
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientAdditionalInformation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientAdditionalInformation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientAdditionalInformation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientInfoTag",
                keyColumns: new[] { "InfoTagId", "PatientId" },
                keyValues: new object[] { 1L, 8L });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientInfoTag",
                keyColumns: new[] { "InfoTagId", "PatientId" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientInfoTag",
                keyColumns: new[] { "InfoTagId", "PatientId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientMedicationInformation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientMedicationInformation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientMedicationInformation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientNotificationMessage",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientNotificationMessage",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientNotificationMessage",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientRecord",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientRecord",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PatientRecord",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
