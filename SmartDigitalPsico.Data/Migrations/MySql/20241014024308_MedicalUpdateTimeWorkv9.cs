using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "tinyint unsigned",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(957), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(988), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(990), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(995), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(882), new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8993), new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9472), new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1765), new byte[] { 149, 89, 225, 167, 74, 183, 225, 174, 101, 42, 43, 239, 83, 104, 142, 181, 187, 152, 20, 11, 37, 118, 239, 91, 33, 123, 126, 183, 106, 13, 169, 175, 153, 101, 141, 213, 158, 70, 183, 217, 72, 206, 228, 114, 186, 85, 90, 156, 60, 148, 119, 145, 132, 206, 29, 85, 191, 52, 182, 36, 240, 78, 151, 127 }, new byte[] { 179, 169, 80, 111, 194, 103, 208, 155, 20, 13, 255, 90, 48, 216, 220, 78, 69, 162, 95, 182, 8, 141, 90, 116, 100, 187, 8, 189, 214, 40, 176, 54, 41, 123, 51, 196, 192, 248, 203, 12, 207, 188, 30, 130, 173, 118, 195, 240, 101, 162, 41, 231, 236, 22, 115, 42, 233, 33, 151, 87, 171, 66, 53, 3, 116, 69, 71, 171, 152, 130, 71, 173, 1, 234, 253, 23, 91, 98, 245, 150, 1, 118, 196, 95, 193, 215, 94, 184, 96, 17, 204, 223, 32, 145, 1, 141, 219, 42, 183, 21, 129, 202, 228, 225, 89, 50, 157, 62, 98, 153, 55, 82, 3, 148, 11, 235, 77, 166, 153, 71, 105, 149, 189, 113, 79, 173, 168, 161 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4910), new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4911), new byte[] { 141, 146, 242, 37, 130, 252, 22, 199, 151, 176, 249, 106, 45, 144, 246, 191, 190, 6, 126, 165, 22, 245, 90, 12, 229, 44, 1, 236, 170, 202, 69, 52, 243, 245, 56, 69, 56, 46, 211, 234, 177, 156, 12, 239, 25, 131, 85, 207, 133, 221, 177, 165, 41, 73, 132, 53, 255, 188, 68, 93, 41, 119, 97, 103 }, new byte[] { 50, 144, 221, 215, 106, 167, 15, 159, 155, 47, 198, 73, 134, 217, 92, 172, 19, 140, 165, 180, 12, 17, 122, 16, 2, 30, 110, 204, 66, 231, 139, 38, 0, 183, 57, 15, 102, 112, 216, 117, 111, 247, 49, 97, 148, 126, 94, 147, 169, 128, 46, 235, 103, 82, 236, 222, 6, 210, 25, 77, 63, 60, 156, 153, 44, 229, 78, 152, 237, 99, 115, 46, 190, 244, 99, 201, 151, 175, 165, 236, 169, 83, 32, 127, 49, 123, 224, 179, 214, 64, 8, 19, 24, 154, 113, 252, 6, 136, 193, 251, 180, 28, 60, 150, 220, 242, 113, 132, 206, 212, 24, 69, 112, 128, 95, 91, 187, 66, 61, 127, 211, 56, 205, 180, 231, 99, 86, 63 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned",
                oldNullable: true);

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
    }
}
