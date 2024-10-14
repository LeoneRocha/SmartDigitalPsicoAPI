using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv5 : Migration
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
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6828), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6830), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6837), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6841), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6845), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6850), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6851), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6852), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6854), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6856), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6861), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6863), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6865), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6866), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6870), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6873), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6877), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6881), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6886), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6894), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6898), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4181), new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4183), new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1050), new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8338), new byte[] { 100, 42, 113, 180, 210, 168, 7, 110, 30, 104, 202, 207, 20, 46, 68, 67, 99, 83, 182, 234, 248, 225, 153, 17, 85, 16, 2, 180, 60, 253, 114, 160, 131, 86, 217, 46, 121, 109, 64, 168, 93, 133, 24, 110, 236, 156, 42, 226, 249, 16, 227, 70, 44, 114, 38, 82, 205, 6, 171, 124, 175, 65, 167, 86 }, new byte[] { 2, 75, 140, 133, 156, 88, 153, 240, 26, 172, 121, 37, 66, 114, 62, 215, 234, 160, 56, 166, 37, 245, 249, 1, 90, 124, 92, 57, 56, 250, 66, 95, 197, 239, 225, 115, 98, 203, 181, 111, 8, 54, 185, 45, 193, 206, 171, 188, 71, 59, 5, 111, 181, 214, 161, 107, 126, 92, 127, 133, 246, 88, 253, 24, 68, 232, 92, 179, 61, 174, 7, 202, 240, 131, 205, 197, 31, 62, 195, 65, 208, 33, 193, 10, 52, 162, 86, 136, 243, 87, 194, 135, 190, 85, 75, 106, 178, 186, 185, 148, 142, 119, 66, 94, 148, 231, 232, 232, 183, 53, 175, 47, 108, 201, 208, 84, 226, 125, 73, 34, 152, 183, 231, 114, 41, 195, 218, 104 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(346), new byte[] { 146, 73, 84, 22, 80, 8, 46, 43, 4, 21, 97, 23, 89, 27, 108, 217, 87, 221, 63, 73, 173, 163, 10, 245, 4, 86, 246, 180, 12, 208, 56, 103, 170, 156, 139, 202, 154, 148, 137, 171, 58, 209, 14, 81, 210, 37, 46, 52, 69, 161, 76, 164, 181, 200, 41, 173, 19, 0, 107, 121, 79, 158, 233, 160 }, new byte[] { 112, 117, 209, 171, 246, 102, 179, 238, 163, 191, 231, 77, 242, 22, 236, 90, 210, 147, 142, 24, 188, 214, 76, 134, 1, 104, 87, 79, 98, 10, 211, 1, 212, 85, 236, 73, 182, 128, 90, 160, 251, 174, 158, 224, 243, 135, 186, 100, 69, 74, 133, 87, 31, 248, 58, 160, 58, 246, 47, 120, 106, 154, 213, 22, 62, 30, 222, 214, 0, 103, 104, 193, 165, 137, 148, 121, 216, 152, 155, 232, 166, 229, 103, 229, 175, 208, 227, 73, 133, 151, 204, 49, 157, 94, 116, 176, 132, 82, 208, 199, 13, 216, 250, 180, 29, 239, 53, 170, 123, 170, 230, 116, 185, 70, 132, 69, 74, 177, 203, 197, 112, 65, 204, 199, 2, 165, 228, 126 } });

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                columns: new[] { "TableName", "Operation", "AuditDate", "UserAuditedId" });

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                columns: new[] { "TableName", "Operation", "AuditDate", "UserAuditedId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2859), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4256), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4257), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4265), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4267), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4268), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4271), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4281), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4285), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4286), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4290), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4295), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4296), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4331), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4333), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4334), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4335), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4336), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4342), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4343), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4344), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6645), new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6646), new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2797), new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3373), new byte[] { 110, 92, 171, 203, 164, 134, 62, 219, 17, 94, 109, 192, 134, 247, 128, 75, 80, 30, 123, 21, 42, 59, 173, 110, 93, 74, 56, 91, 88, 130, 188, 129, 49, 21, 75, 208, 214, 151, 172, 188, 231, 136, 27, 153, 211, 48, 36, 97, 237, 64, 208, 128, 214, 0, 79, 86, 1, 89, 125, 64, 252, 202, 25, 202 }, new byte[] { 54, 114, 188, 27, 130, 156, 87, 63, 252, 70, 114, 217, 219, 238, 135, 104, 79, 243, 127, 10, 72, 70, 180, 253, 25, 222, 200, 58, 115, 244, 76, 126, 56, 91, 176, 104, 128, 179, 39, 113, 195, 217, 248, 164, 26, 41, 51, 106, 122, 153, 30, 249, 114, 57, 122, 196, 147, 39, 2, 0, 116, 118, 191, 225, 95, 148, 156, 160, 24, 29, 168, 183, 231, 174, 140, 60, 99, 166, 187, 174, 151, 109, 213, 167, 34, 112, 145, 63, 203, 12, 37, 194, 149, 189, 155, 186, 65, 151, 154, 9, 238, 106, 199, 116, 254, 76, 169, 124, 83, 177, 180, 210, 105, 123, 220, 175, 30, 112, 55, 20, 149, 3, 16, 209, 15, 27, 143, 87 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4963), new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4964), new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4964), new byte[] { 156, 54, 139, 173, 159, 108, 159, 177, 156, 184, 254, 13, 27, 100, 155, 204, 232, 137, 216, 74, 248, 49, 145, 51, 145, 207, 141, 226, 99, 83, 247, 100, 20, 144, 127, 119, 25, 183, 247, 50, 204, 191, 109, 53, 254, 107, 135, 90, 140, 197, 81, 73, 24, 22, 208, 23, 175, 135, 74, 158, 9, 133, 72, 183 }, new byte[] { 228, 237, 182, 176, 223, 238, 105, 31, 185, 28, 106, 236, 125, 189, 52, 157, 163, 46, 118, 90, 248, 38, 76, 209, 114, 224, 135, 134, 139, 36, 188, 30, 205, 165, 120, 123, 62, 245, 18, 15, 117, 9, 137, 168, 34, 17, 196, 80, 37, 90, 100, 35, 116, 77, 166, 182, 171, 166, 39, 7, 203, 50, 85, 126, 168, 70, 80, 67, 99, 159, 239, 156, 56, 207, 8, 51, 174, 74, 239, 64, 198, 110, 59, 203, 115, 138, 110, 23, 221, 182, 45, 133, 244, 44, 59, 173, 205, 17, 26, 77, 108, 96, 125, 180, 93, 157, 70, 160, 187, 170, 83, 93, 202, 163, 255, 218, 28, 30, 207, 26, 251, 240, 2, 251, 145, 253, 222, 80 } });
        }
    }
}
