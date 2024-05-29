using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfig_04 : Migration
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
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6216), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6219), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6420), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6424), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6427), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6430), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6431), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6439), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6440), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6441), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6442), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6447), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6448), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6454), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6455), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6457), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6458), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6460), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6497), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6504), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6508), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6511), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "MedicalSpecialty",
                columns: new[] { "MedicalId", "SpecialtyId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6945), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7262), new byte[] { 102, 219, 35, 255, 244, 125, 55, 207, 248, 133, 244, 190, 155, 110, 49, 8, 111, 64, 141, 203, 210, 138, 48, 26, 241, 189, 23, 52, 25, 162, 87, 58, 155, 242, 78, 174, 205, 235, 37, 1, 244, 197, 71, 149, 16, 228, 183, 88, 22, 21, 58, 109, 213, 78, 24, 201, 211, 187, 231, 71, 182, 240, 70, 243 }, new byte[] { 55, 75, 165, 123, 90, 250, 116, 199, 236, 141, 166, 93, 250, 170, 248, 60, 149, 37, 151, 111, 0, 53, 68, 158, 57, 241, 235, 80, 48, 241, 215, 0, 98, 172, 114, 148, 152, 233, 172, 233, 28, 129, 51, 213, 144, 78, 26, 149, 133, 77, 197, 152, 255, 74, 127, 100, 194, 99, 113, 225, 250, 177, 80, 204, 3, 181, 167, 156, 243, 134, 89, 24, 76, 158, 1, 80, 137, 237, 111, 214, 246, 113, 6, 93, 226, 231, 72, 178, 66, 72, 90, 188, 137, 104, 20, 226, 9, 174, 1, 8, 233, 152, 140, 156, 40, 165, 111, 197, 118, 61, 223, 24, 124, 251, 210, 219, 23, 58, 106, 156, 64, 156, 186, 55, 86, 253, 189, 109 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8553), new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8553), new byte[] { 35, 195, 133, 204, 115, 91, 149, 1, 190, 162, 188, 250, 124, 138, 214, 128, 186, 228, 129, 180, 105, 198, 152, 9, 185, 0, 96, 106, 52, 140, 151, 246, 180, 180, 156, 113, 157, 86, 117, 144, 77, 98, 18, 223, 237, 194, 5, 32, 122, 254, 10, 108, 129, 19, 160, 226, 179, 216, 191, 169, 237, 166, 248, 22 }, new byte[] { 80, 250, 98, 193, 40, 226, 6, 51, 127, 111, 226, 135, 11, 121, 123, 69, 23, 219, 193, 212, 45, 241, 65, 0, 250, 228, 75, 104, 84, 183, 156, 114, 214, 123, 16, 130, 140, 12, 162, 183, 252, 86, 101, 50, 204, 72, 66, 43, 215, 115, 175, 162, 27, 77, 25, 1, 218, 120, 237, 78, 208, 73, 8, 185, 167, 81, 14, 128, 66, 178, 25, 232, 28, 80, 164, 51, 115, 243, 136, 18, 240, 239, 62, 18, 0, 204, 64, 204, 134, 220, 80, 205, 89, 202, 45, 212, 190, 17, 93, 215, 198, 74, 56, 203, 186, 0, 63, 155, 18, 246, 37, 27, 64, 141, 53, 173, 46, 92, 124, 222, 101, 198, 226, 234, 37, 130, 157, 42 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "MedicalSpecialty",
                keyColumns: new[] { "MedicalId", "SpecialtyId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(763), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(990), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(993), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(995), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1004), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1016), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1017), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1019), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1021), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1021), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1038), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1043), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1046), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1046), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1261), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1262), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1486), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1844), new DateTime(2024, 5, 18, 13, 52, 32, 550, DateTimeKind.Utc).AddTicks(1844), new byte[] { 150, 114, 76, 82, 150, 3, 248, 216, 111, 36, 70, 118, 6, 233, 165, 69, 208, 205, 211, 177, 96, 229, 193, 233, 85, 121, 140, 1, 254, 164, 207, 198, 174, 209, 69, 133, 193, 70, 247, 105, 48, 189, 52, 186, 179, 203, 10, 41, 50, 150, 122, 199, 167, 55, 146, 142, 45, 95, 134, 92, 209, 109, 121, 252 }, new byte[] { 220, 164, 41, 128, 41, 232, 228, 129, 70, 65, 230, 8, 1, 246, 96, 126, 216, 128, 174, 74, 21, 255, 151, 48, 88, 1, 123, 93, 20, 82, 58, 80, 247, 217, 124, 142, 110, 79, 163, 82, 0, 184, 11, 156, 4, 215, 217, 5, 186, 87, 254, 252, 12, 189, 167, 95, 62, 156, 224, 21, 46, 244, 174, 51, 88, 52, 115, 20, 172, 87, 9, 178, 137, 113, 1, 14, 65, 79, 44, 132, 85, 26, 116, 137, 241, 123, 204, 211, 76, 213, 55, 16, 178, 65, 221, 139, 103, 240, 102, 81, 100, 110, 166, 24, 252, 143, 60, 243, 119, 52, 135, 35, 147, 91, 83, 69, 62, 107, 205, 1, 22, 120, 230, 212, 176, 169, 157, 7 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 52, 32, 552, DateTimeKind.Utc).AddTicks(2915), new DateTime(2024, 5, 18, 13, 52, 32, 552, DateTimeKind.Utc).AddTicks(2915), new DateTime(2024, 5, 18, 13, 52, 32, 552, DateTimeKind.Utc).AddTicks(2916), new byte[] { 227, 96, 45, 41, 242, 207, 81, 41, 88, 167, 82, 31, 56, 173, 235, 169, 141, 61, 254, 68, 86, 14, 242, 93, 190, 59, 245, 242, 60, 102, 147, 188, 226, 220, 96, 150, 35, 189, 70, 23, 93, 233, 49, 75, 217, 80, 50, 254, 155, 213, 203, 218, 63, 178, 24, 9, 44, 72, 35, 192, 202, 59, 59, 33 }, new byte[] { 207, 148, 94, 30, 244, 88, 144, 137, 214, 12, 37, 69, 43, 228, 194, 67, 26, 208, 238, 240, 200, 152, 19, 51, 18, 88, 192, 138, 228, 75, 236, 15, 75, 138, 210, 102, 226, 29, 66, 196, 91, 185, 241, 13, 249, 89, 209, 70, 6, 180, 111, 144, 103, 200, 134, 94, 125, 88, 141, 40, 251, 108, 223, 253, 190, 106, 166, 108, 67, 99, 88, 41, 134, 229, 204, 96, 189, 24, 43, 20, 138, 223, 223, 177, 104, 95, 226, 189, 85, 14, 210, 220, 78, 244, 1, 44, 174, 199, 212, 211, 210, 148, 66, 181, 8, 49, 153, 54, 91, 154, 10, 42, 99, 40, 206, 165, 27, 226, 12, 64, 31, 13, 208, 72, 121, 134, 253, 242 } });
        }
    }
}
