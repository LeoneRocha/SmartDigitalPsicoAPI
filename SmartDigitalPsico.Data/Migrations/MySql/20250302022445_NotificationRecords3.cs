using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecords3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(654), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(661), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5893), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5896), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5901), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5903), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5907), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5912), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5914), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5915), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5919), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5921), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5925), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5926), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5927), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5928), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5929), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5933), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5936), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5941), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5943), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5945), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5946), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6529), new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1787), new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1789), new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5006), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5011), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5012), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5016), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5017), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8402), new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9816), new byte[] { 101, 28, 205, 33, 105, 31, 2, 35, 233, 112, 158, 52, 95, 50, 37, 230, 27, 125, 226, 196, 17, 241, 90, 213, 27, 31, 62, 137, 116, 141, 245, 175, 67, 225, 35, 201, 10, 57, 114, 172, 41, 116, 50, 25, 114, 107, 2, 68, 150, 127, 42, 115, 175, 115, 17, 113, 34, 72, 102, 234, 160, 7, 40, 247 }, new byte[] { 177, 208, 124, 38, 158, 216, 196, 101, 72, 143, 191, 120, 242, 118, 176, 131, 154, 17, 38, 38, 168, 26, 151, 222, 125, 147, 230, 35, 107, 96, 238, 255, 186, 112, 61, 63, 185, 178, 147, 170, 142, 216, 94, 21, 226, 8, 220, 132, 249, 166, 164, 168, 175, 1, 58, 239, 223, 55, 236, 156, 135, 165, 146, 253, 191, 122, 183, 238, 227, 0, 197, 37, 239, 204, 76, 85, 216, 37, 153, 145, 117, 237, 254, 61, 12, 242, 30, 51, 195, 67, 39, 200, 33, 35, 8, 61, 177, 137, 111, 183, 211, 32, 6, 132, 199, 161, 228, 50, 52, 129, 189, 85, 102, 180, 127, 104, 161, 151, 242, 150, 41, 210, 10, 54, 11, 60, 157, 90 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(807), new byte[] { 212, 9, 212, 213, 133, 60, 137, 141, 189, 57, 98, 13, 36, 98, 145, 89, 251, 170, 202, 19, 184, 255, 68, 214, 207, 81, 201, 172, 228, 98, 121, 11, 241, 177, 49, 220, 252, 251, 2, 219, 51, 224, 171, 50, 166, 154, 151, 95, 179, 231, 159, 153, 134, 19, 31, 38, 137, 231, 236, 241, 131, 158, 185, 151 }, new byte[] { 4, 241, 240, 72, 32, 238, 61, 33, 242, 84, 76, 37, 166, 210, 150, 50, 123, 127, 72, 213, 116, 242, 141, 162, 3, 52, 32, 38, 61, 87, 10, 11, 166, 210, 25, 22, 169, 39, 30, 150, 186, 43, 148, 16, 230, 45, 73, 109, 101, 29, 176, 219, 50, 101, 227, 115, 45, 75, 69, 254, 241, 118, 149, 72, 16, 137, 129, 166, 98, 106, 123, 123, 144, 121, 84, 171, 134, 46, 57, 21, 48, 249, 54, 40, 138, 0, 35, 186, 133, 165, 202, 107, 249, 29, 80, 214, 126, 255, 248, 216, 108, 2, 180, 193, 179, 138, 24, 202, 84, 204, 151, 67, 115, 206, 69, 143, 111, 99, 234, 91, 127, 190, 182, 87, 72, 100, 90, 173 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4296), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9310), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9315), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9317), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9321), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9322), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9324), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9325), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9327), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9328), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9332), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9333), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9334), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9335), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9336), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9338), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9339), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9362), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9363), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9364), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9365), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9371), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9372), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9373), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9374), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9375), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9377), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9378), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9382), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9383), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9384), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9385), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9386), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9387), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9391), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9392), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9393), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9394), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9395), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9396), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9397), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9398), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9402), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9403), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9866), new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 675, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 675, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9023), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9025), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9027), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9028), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9030), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9031), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9035), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9036), new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3140), new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4309), new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4310), new byte[] { 248, 215, 166, 152, 200, 97, 247, 123, 212, 133, 140, 153, 167, 22, 66, 44, 83, 240, 153, 93, 240, 72, 141, 106, 137, 157, 47, 188, 232, 89, 161, 57, 250, 60, 221, 196, 14, 137, 196, 6, 133, 79, 205, 184, 90, 209, 103, 126, 204, 20, 120, 187, 52, 31, 242, 87, 186, 130, 228, 218, 21, 153, 12, 218 }, new byte[] { 54, 52, 96, 189, 74, 211, 173, 221, 215, 245, 132, 166, 70, 102, 145, 91, 87, 245, 78, 158, 26, 61, 226, 243, 108, 99, 116, 232, 17, 34, 187, 200, 53, 216, 54, 242, 69, 221, 49, 81, 172, 116, 79, 171, 49, 48, 113, 96, 187, 67, 151, 152, 55, 194, 241, 225, 221, 96, 114, 57, 55, 177, 85, 52, 246, 106, 88, 124, 255, 101, 111, 45, 182, 102, 86, 26, 72, 48, 5, 42, 84, 127, 104, 166, 130, 26, 231, 4, 107, 13, 99, 126, 41, 213, 13, 61, 37, 186, 77, 7, 42, 176, 122, 199, 121, 64, 131, 144, 130, 144, 155, 127, 23, 61, 44, 78, 72, 63, 194, 244, 29, 233, 97, 152, 65, 10, 30, 17 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5486), new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5487), new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5487), new byte[] { 245, 209, 76, 152, 252, 196, 44, 94, 9, 129, 5, 57, 151, 144, 132, 135, 154, 12, 120, 183, 89, 237, 31, 241, 17, 92, 221, 146, 118, 121, 205, 226, 20, 58, 27, 224, 21, 84, 77, 46, 239, 78, 225, 241, 166, 0, 33, 108, 75, 58, 27, 48, 183, 80, 157, 140, 17, 233, 85, 17, 102, 10, 242, 1 }, new byte[] { 197, 202, 109, 206, 36, 25, 83, 145, 66, 246, 202, 199, 245, 189, 94, 70, 174, 143, 44, 171, 169, 211, 171, 203, 228, 28, 39, 159, 93, 36, 6, 91, 211, 221, 43, 208, 242, 180, 105, 212, 226, 9, 12, 204, 159, 165, 93, 101, 12, 4, 176, 115, 3, 247, 77, 130, 170, 62, 79, 100, 118, 107, 217, 94, 181, 234, 95, 77, 145, 224, 40, 42, 246, 152, 216, 98, 243, 142, 158, 226, 255, 112, 91, 215, 10, 186, 98, 53, 50, 233, 204, 8, 203, 7, 232, 124, 44, 42, 232, 253, 196, 228, 124, 153, 250, 146, 190, 69, 101, 112, 117, 116, 2, 154, 254, 217, 19, 173, 204, 78, 168, 164, 141, 225, 229, 177, 77, 228 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id");
        }
    }
}
