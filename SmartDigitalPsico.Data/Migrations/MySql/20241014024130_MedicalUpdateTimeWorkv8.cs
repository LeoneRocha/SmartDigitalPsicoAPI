using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(5534), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6841), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6845), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6847), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6848), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6886), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6890), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6890), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6894), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6898), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6904), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6905), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6907), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6908), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6909), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6910), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6912), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6913), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6918), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6919), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6920), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6922), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6932), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6937), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6938), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6940), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6945), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6945), new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 949, DateTimeKind.Utc).AddTicks(9585), new DateTime(2024, 10, 14, 2, 41, 29, 949, DateTimeKind.Utc).AddTicks(9586), new DateTime(2024, 10, 14, 2, 41, 29, 949, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 931, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(2822), new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(2824), new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 938, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 941, DateTimeKind.Utc).AddTicks(5852), new DateTime(2024, 10, 14, 2, 41, 29, 941, DateTimeKind.Utc).AddTicks(5853), new DateTime(2024, 10, 14, 2, 41, 29, 941, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 41, 29, 943, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 944, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 10, 14, 2, 41, 29, 944, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 10, 14, 2, 41, 29, 944, DateTimeKind.Utc).AddTicks(1244), new byte[] { 15, 38, 17, 132, 106, 213, 35, 5, 133, 0, 107, 21, 33, 230, 2, 224, 88, 88, 226, 161, 89, 192, 202, 171, 151, 217, 252, 212, 163, 140, 8, 144, 47, 100, 25, 189, 8, 88, 51, 43, 220, 45, 76, 101, 83, 193, 117, 58, 107, 134, 131, 252, 225, 103, 31, 140, 100, 110, 195, 41, 208, 13, 151, 101 }, new byte[] { 208, 206, 74, 40, 220, 121, 61, 78, 9, 10, 89, 12, 40, 82, 83, 216, 34, 41, 132, 23, 188, 0, 250, 57, 156, 161, 63, 9, 37, 52, 230, 117, 5, 223, 173, 161, 212, 170, 38, 9, 89, 108, 221, 50, 192, 46, 85, 195, 4, 196, 139, 97, 168, 50, 56, 213, 79, 241, 251, 251, 219, 21, 18, 232, 49, 206, 92, 37, 40, 53, 178, 102, 116, 142, 227, 8, 67, 213, 87, 175, 126, 115, 226, 149, 252, 200, 155, 157, 121, 144, 233, 79, 20, 1, 79, 18, 249, 103, 183, 98, 140, 28, 102, 180, 149, 51, 72, 209, 68, 59, 129, 128, 168, 253, 18, 149, 169, 87, 216, 252, 17, 137, 75, 136, 17, 227, 155, 182 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 41, 29, 946, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 10, 14, 2, 41, 29, 946, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 10, 14, 2, 41, 29, 946, DateTimeKind.Utc).AddTicks(2538), new byte[] { 34, 46, 50, 107, 201, 50, 31, 170, 229, 127, 182, 227, 83, 229, 34, 176, 100, 123, 154, 213, 93, 90, 84, 170, 75, 192, 206, 56, 55, 156, 7, 101, 77, 169, 28, 178, 41, 57, 109, 12, 50, 64, 172, 19, 213, 107, 236, 234, 233, 165, 44, 157, 194, 15, 210, 106, 225, 152, 50, 231, 93, 253, 114, 96 }, new byte[] { 151, 62, 164, 253, 2, 252, 254, 151, 251, 23, 199, 128, 209, 213, 155, 148, 164, 101, 54, 41, 163, 34, 157, 112, 18, 162, 17, 235, 37, 21, 145, 210, 151, 218, 182, 113, 28, 105, 152, 110, 241, 31, 101, 45, 115, 81, 114, 185, 108, 233, 36, 138, 236, 206, 72, 61, 169, 197, 142, 245, 151, 70, 103, 233, 146, 189, 58, 68, 61, 212, 203, 13, 120, 32, 237, 139, 18, 94, 141, 104, 21, 136, 245, 143, 139, 84, 133, 194, 51, 0, 17, 40, 55, 238, 11, 144, 172, 182, 239, 102, 143, 16, 61, 154, 94, 165, 247, 89, 22, 148, 93, 68, 217, 239, 194, 189, 79, 90, 30, 16, 210, 7, 250, 91, 233, 239, 95, 30 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1324), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2542), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2554), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2555), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2557), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2558), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2559), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2561), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2564), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2565), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2567), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2568), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2569), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2570), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2576), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2578), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2579), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2585), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2593), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2595), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2601), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2603), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7258), new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(741), new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6091), new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6093), new byte[] { 140, 78, 186, 17, 87, 169, 164, 128, 96, 132, 8, 81, 143, 78, 99, 29, 214, 212, 227, 109, 54, 20, 237, 166, 213, 101, 246, 104, 7, 116, 62, 135, 181, 44, 26, 54, 61, 138, 75, 160, 28, 142, 215, 227, 63, 101, 120, 17, 138, 49, 39, 219, 252, 237, 51, 169, 65, 19, 86, 186, 73, 168, 239, 221 }, new byte[] { 53, 239, 48, 211, 19, 66, 100, 90, 116, 82, 172, 148, 247, 35, 253, 249, 66, 69, 5, 15, 169, 75, 74, 212, 196, 111, 66, 86, 174, 194, 250, 140, 235, 255, 181, 81, 120, 196, 52, 164, 182, 121, 159, 217, 56, 70, 204, 6, 247, 200, 20, 124, 75, 159, 24, 71, 138, 115, 245, 184, 170, 67, 72, 206, 232, 161, 197, 166, 144, 80, 67, 68, 89, 247, 104, 59, 24, 237, 119, 250, 43, 28, 78, 146, 237, 233, 51, 231, 164, 100, 51, 52, 136, 124, 50, 35, 192, 216, 209, 74, 133, 220, 255, 10, 125, 180, 150, 109, 179, 139, 231, 75, 244, 161, 30, 74, 78, 52, 214, 83, 121, 216, 93, 1, 238, 253, 156, 60 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7101), new byte[] { 231, 80, 112, 249, 54, 192, 158, 187, 121, 161, 121, 109, 52, 155, 89, 48, 140, 1, 240, 188, 59, 196, 87, 208, 33, 57, 114, 33, 198, 231, 19, 28, 127, 66, 198, 7, 52, 86, 244, 252, 164, 114, 59, 103, 6, 58, 244, 26, 80, 158, 142, 30, 120, 138, 20, 96, 82, 219, 21, 198, 230, 245, 139, 250 }, new byte[] { 65, 95, 185, 184, 183, 27, 55, 59, 103, 236, 50, 60, 179, 53, 76, 182, 53, 109, 173, 67, 4, 25, 164, 224, 189, 3, 6, 90, 79, 77, 185, 85, 174, 195, 212, 230, 93, 92, 32, 141, 47, 34, 81, 88, 224, 132, 180, 225, 131, 236, 221, 18, 6, 15, 40, 15, 143, 185, 227, 186, 99, 117, 83, 249, 62, 8, 41, 201, 129, 21, 95, 117, 215, 147, 239, 201, 151, 224, 98, 61, 145, 103, 104, 193, 159, 208, 118, 151, 36, 91, 166, 241, 158, 78, 5, 172, 4, 168, 133, 92, 235, 31, 41, 97, 34, 72, 227, 244, 86, 46, 253, 240, 234, 253, 100, 221, 105, 205, 0, 120, 52, 165, 11, 100, 236, 44, 209, 59 } });
        }
    }
}
