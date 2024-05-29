using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6035), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6039), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6043), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6045), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6046), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6052), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6052), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6053), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6054), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6056), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6059), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6065), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6065), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6067), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6070), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6072), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6073), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6075), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6077), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6078), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6081), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6087), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6088), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6091), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6127), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6128), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6130), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6132), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6134), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6135), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6136), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6136), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6138), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6138), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6139), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6356), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6357), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "MedicalSpecialty",
                columns: new[] { "MedicalId", "SpecialtyId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 2L },
                    { 3L, 3L }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6575), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6576), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 5, 29, 16, 9, 17, 333, DateTimeKind.Utc).AddTicks(6903), new byte[] { 188, 183, 123, 48, 169, 65, 199, 185, 144, 129, 114, 154, 26, 171, 211, 144, 88, 94, 58, 164, 192, 164, 149, 13, 209, 113, 164, 174, 116, 132, 165, 8, 87, 239, 185, 215, 195, 6, 92, 64, 197, 75, 20, 189, 104, 36, 82, 13, 240, 178, 200, 200, 217, 92, 180, 222, 45, 227, 189, 29, 229, 53, 16, 20 }, new byte[] { 77, 122, 159, 138, 223, 170, 150, 233, 88, 209, 114, 244, 92, 250, 245, 28, 123, 111, 250, 127, 188, 6, 157, 225, 177, 49, 232, 253, 49, 236, 109, 221, 163, 36, 148, 224, 87, 122, 182, 88, 0, 55, 113, 36, 22, 6, 40, 122, 25, 20, 178, 151, 228, 181, 229, 128, 179, 69, 216, 58, 205, 252, 63, 102, 197, 211, 238, 227, 201, 126, 68, 75, 162, 8, 110, 159, 50, 63, 70, 227, 165, 136, 230, 110, 64, 97, 28, 174, 227, 187, 204, 85, 96, 102, 167, 39, 103, 119, 130, 48, 99, 176, 247, 19, 5, 185, 39, 147, 123, 118, 107, 88, 101, 85, 9, 116, 192, 91, 32, 65, 126, 43, 210, 171, 29, 147, 194, 171 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 9, 17, 335, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 5, 29, 16, 9, 17, 335, DateTimeKind.Utc).AddTicks(8592), new DateTime(2024, 5, 29, 16, 9, 17, 335, DateTimeKind.Utc).AddTicks(8593), new byte[] { 151, 78, 130, 87, 72, 92, 247, 3, 7, 83, 48, 47, 54, 126, 32, 146, 108, 255, 195, 178, 47, 79, 56, 41, 195, 231, 75, 189, 245, 88, 39, 121, 129, 84, 51, 240, 209, 114, 174, 37, 241, 85, 224, 200, 64, 234, 184, 89, 131, 36, 122, 110, 176, 238, 52, 155, 74, 26, 47, 168, 192, 98, 2, 184 }, new byte[] { 178, 34, 251, 51, 220, 29, 46, 214, 166, 147, 66, 26, 23, 127, 249, 8, 64, 255, 91, 253, 205, 113, 112, 196, 143, 151, 154, 19, 226, 8, 105, 198, 231, 126, 81, 224, 115, 183, 105, 223, 89, 245, 98, 90, 72, 182, 119, 93, 164, 204, 202, 55, 45, 52, 170, 166, 109, 73, 121, 185, 136, 146, 53, 5, 244, 108, 86, 89, 66, 15, 203, 36, 130, 20, 245, 230, 144, 223, 191, 114, 18, 29, 248, 239, 80, 129, 34, 117, 188, 197, 33, 120, 69, 17, 83, 124, 158, 185, 89, 186, 116, 243, 97, 8, 109, 247, 69, 126, 60, 205, 211, 253, 138, 139, 97, 162, 230, 91, 90, 66, 138, 139, 107, 197, 25, 78, 11, 161 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "MedicalSpecialty",
                keyColumns: new[] { "MedicalId", "SpecialtyId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "MedicalSpecialty",
                keyColumns: new[] { "MedicalId", "SpecialtyId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "MedicalSpecialty",
                keyColumns: new[] { "MedicalId", "SpecialtyId" },
                keyValues: new object[] { 3L, 3L });

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
