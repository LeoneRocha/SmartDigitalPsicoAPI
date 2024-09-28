using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RenameContext4 : Migration
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
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(728), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(934), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(935), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(936), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(941), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1038), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1043), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1045), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1046), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1827), new byte[] { 36, 53, 47, 95, 113, 28, 8, 202, 68, 45, 120, 114, 78, 67, 55, 187, 207, 124, 41, 21, 5, 238, 251, 125, 79, 31, 184, 186, 88, 124, 33, 65, 243, 17, 180, 78, 192, 41, 244, 241, 203, 2, 188, 138, 243, 68, 75, 75, 222, 33, 47, 159, 99, 144, 238, 195, 12, 51, 101, 197, 244, 243, 76, 198 }, new byte[] { 24, 37, 160, 188, 215, 204, 82, 59, 183, 100, 225, 252, 21, 80, 121, 203, 82, 105, 203, 64, 17, 15, 146, 97, 212, 213, 137, 126, 136, 98, 82, 76, 188, 223, 157, 10, 170, 225, 150, 9, 139, 216, 172, 85, 7, 225, 13, 249, 131, 1, 57, 26, 236, 64, 204, 234, 91, 134, 146, 225, 232, 241, 108, 78, 160, 8, 214, 85, 0, 142, 46, 121, 214, 204, 186, 33, 160, 109, 131, 74, 159, 169, 72, 223, 138, 51, 143, 217, 21, 104, 132, 32, 162, 233, 51, 177, 238, 179, 131, 207, 173, 236, 66, 207, 112, 65, 170, 62, 232, 121, 201, 218, 148, 50, 166, 56, 17, 178, 251, 127, 36, 144, 51, 181, 88, 92, 98, 11 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3193), new byte[] { 33, 39, 26, 96, 154, 1, 17, 195, 134, 14, 81, 38, 197, 157, 163, 13, 152, 31, 46, 205, 23, 222, 81, 158, 51, 125, 70, 73, 241, 5, 22, 15, 73, 229, 245, 49, 82, 23, 192, 152, 139, 92, 28, 4, 100, 117, 164, 227, 199, 206, 108, 40, 246, 66, 45, 146, 255, 227, 37, 11, 209, 81, 44, 80 }, new byte[] { 227, 97, 242, 4, 228, 168, 164, 65, 216, 33, 100, 154, 232, 86, 111, 206, 247, 229, 255, 32, 62, 202, 66, 253, 255, 18, 205, 104, 57, 60, 205, 186, 40, 92, 211, 114, 79, 205, 22, 153, 123, 231, 18, 7, 220, 71, 141, 19, 58, 120, 70, 75, 22, 44, 151, 204, 116, 92, 132, 100, 203, 43, 179, 85, 55, 253, 120, 18, 86, 207, 140, 237, 21, 27, 200, 56, 89, 63, 53, 197, 244, 91, 22, 169, 69, 32, 97, 83, 122, 50, 72, 29, 34, 137, 217, 27, 97, 62, 167, 244, 23, 0, 193, 66, 183, 9, 225, 0, 86, 197, 237, 84, 12, 182, 5, 221, 184, 144, 214, 230, 31, 198, 28, 70, 34, 249, 63, 162 } });
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
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8182), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8381), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8383), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8385), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8386), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8392), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8393), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8396), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8399), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8401), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8445), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8446), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8446) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8447), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8448), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8449), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8452), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8458), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8459), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8461), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8465), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8466), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8467), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8468), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8469), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8470), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8474), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8475), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8476), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8477), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8478), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8479), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8707), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9254), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9254), new byte[] { 194, 241, 54, 112, 95, 142, 135, 13, 217, 151, 161, 111, 21, 123, 35, 175, 166, 168, 110, 237, 177, 115, 217, 43, 76, 241, 153, 110, 177, 127, 27, 15, 111, 216, 149, 138, 14, 141, 93, 161, 206, 39, 66, 12, 212, 146, 222, 239, 175, 129, 163, 71, 221, 223, 195, 39, 72, 44, 36, 120, 145, 188, 76, 157 }, new byte[] { 198, 96, 252, 48, 134, 194, 48, 61, 4, 97, 246, 111, 26, 142, 15, 197, 176, 253, 94, 164, 228, 111, 114, 44, 4, 202, 79, 255, 90, 175, 131, 218, 7, 14, 146, 238, 239, 254, 105, 255, 111, 140, 118, 176, 95, 124, 154, 115, 147, 215, 101, 75, 157, 185, 139, 136, 138, 31, 178, 15, 115, 247, 224, 17, 253, 35, 187, 105, 157, 135, 254, 115, 249, 224, 90, 189, 68, 131, 134, 177, 255, 250, 201, 68, 152, 54, 186, 78, 88, 180, 240, 106, 157, 127, 194, 232, 193, 234, 82, 76, 76, 159, 93, 124, 73, 128, 252, 241, 151, 1, 240, 133, 146, 169, 58, 246, 33, 153, 16, 223, 126, 204, 22, 89, 165, 53, 24, 110 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(494), new byte[] { 36, 188, 236, 53, 69, 205, 202, 159, 31, 91, 142, 60, 71, 19, 110, 48, 252, 210, 26, 217, 135, 189, 128, 232, 180, 124, 157, 253, 208, 65, 26, 251, 9, 223, 203, 126, 217, 44, 129, 97, 26, 248, 52, 21, 228, 107, 151, 254, 111, 15, 39, 131, 196, 198, 137, 220, 150, 91, 137, 53, 242, 217, 104, 9 }, new byte[] { 138, 46, 140, 57, 64, 209, 181, 236, 165, 91, 113, 6, 172, 79, 184, 171, 199, 61, 204, 4, 82, 205, 21, 200, 239, 188, 12, 38, 115, 176, 232, 224, 65, 141, 32, 181, 237, 180, 38, 52, 180, 68, 79, 19, 236, 65, 189, 80, 78, 98, 122, 82, 145, 6, 230, 42, 189, 92, 118, 214, 225, 10, 81, 10, 4, 4, 158, 214, 25, 85, 148, 119, 121, 36, 229, 122, 197, 193, 119, 89, 45, 174, 79, 59, 206, 97, 120, 107, 57, 237, 241, 68, 120, 2, 103, 179, 251, 35, 21, 150, 250, 109, 217, 81, 205, 250, 35, 42, 201, 137, 213, 24, 221, 179, 89, 107, 61, 202, 132, 54, 73, 178, 252, 118, 241, 118, 240, 45 } });
        }
    }
}
