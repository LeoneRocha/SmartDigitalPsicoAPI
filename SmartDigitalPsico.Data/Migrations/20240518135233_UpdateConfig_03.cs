using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfig_03 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2687), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2689), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2692), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2697), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2700), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2716), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2718), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2719), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2721), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2723), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2725), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2727), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2728), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2731), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2732), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2734), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2735), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2736), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2738), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2739), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2741), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2744), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2745), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2746), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2748), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3048), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3048), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3598), new byte[] { 106, 12, 103, 208, 61, 207, 37, 127, 191, 56, 40, 60, 206, 150, 6, 99, 205, 101, 193, 13, 208, 67, 141, 99, 81, 235, 129, 84, 153, 48, 109, 22, 207, 176, 197, 4, 72, 137, 97, 180, 217, 71, 4, 203, 0, 123, 137, 183, 91, 117, 182, 46, 178, 48, 99, 96, 172, 168, 172, 121, 25, 33, 190, 20 }, new byte[] { 23, 111, 165, 77, 17, 177, 148, 119, 154, 188, 209, 182, 83, 128, 99, 191, 64, 171, 93, 233, 122, 178, 9, 148, 233, 128, 74, 36, 58, 156, 154, 175, 153, 152, 101, 95, 204, 202, 93, 15, 108, 128, 123, 58, 163, 171, 210, 32, 9, 117, 138, 179, 144, 135, 58, 93, 155, 240, 65, 56, 59, 198, 248, 155, 185, 120, 120, 227, 22, 186, 250, 127, 42, 249, 11, 129, 175, 237, 191, 249, 107, 92, 153, 200, 235, 19, 19, 156, 112, 220, 132, 55, 58, 121, 111, 214, 117, 186, 210, 58, 110, 84, 233, 13, 106, 142, 205, 252, 17, 230, 151, 145, 219, 105, 165, 40, 162, 10, 205, 235, 219, 116, 3, 105, 211, 27, 41, 224 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4842), new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4842), new byte[] { 140, 222, 209, 74, 3, 198, 76, 182, 168, 68, 49, 72, 12, 31, 134, 45, 153, 123, 85, 241, 87, 175, 251, 42, 135, 184, 200, 211, 70, 176, 204, 226, 112, 195, 219, 216, 172, 175, 109, 65, 175, 88, 160, 205, 90, 53, 68, 132, 23, 106, 140, 98, 168, 150, 147, 25, 145, 112, 74, 7, 26, 169, 223, 247 }, new byte[] { 79, 236, 173, 231, 37, 152, 52, 74, 246, 161, 220, 240, 222, 16, 162, 72, 58, 108, 251, 71, 222, 88, 167, 201, 4, 148, 11, 230, 221, 96, 244, 124, 124, 94, 19, 172, 210, 111, 162, 36, 193, 249, 152, 136, 125, 13, 164, 120, 145, 68, 110, 125, 136, 54, 177, 149, 52, 251, 248, 164, 62, 125, 71, 192, 26, 205, 230, 187, 132, 63, 186, 21, 150, 216, 207, 217, 200, 243, 9, 25, 202, 54, 117, 168, 115, 27, 94, 230, 206, 154, 19, 31, 176, 232, 5, 74, 20, 75, 122, 145, 7, 252, 3, 0, 122, 231, 120, 251, 23, 254, 9, 225, 232, 161, 1, 161, 24, 36, 34, 224, 157, 252, 95, 240, 77, 247, 93, 61 } });
        }
    }
}
