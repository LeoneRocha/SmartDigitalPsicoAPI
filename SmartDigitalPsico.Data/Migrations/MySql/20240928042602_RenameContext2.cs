using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RenameContext2 : Migration
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
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7751), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7957), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7958), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7959), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7965), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7966), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7967), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7968), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7970), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7972), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7973), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7974), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7975), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7976), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7977), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7978), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7980), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7981), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7983), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7984), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7986), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7988), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7992), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7994), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7996), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8001), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8003), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8007), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8008), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8020), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8542), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8543), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8861), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8862), new byte[] { 194, 213, 10, 63, 88, 105, 23, 80, 174, 2, 56, 185, 48, 66, 16, 161, 233, 122, 178, 52, 66, 176, 103, 79, 244, 216, 242, 229, 218, 171, 185, 237, 59, 155, 124, 20, 232, 166, 147, 142, 146, 154, 98, 184, 234, 99, 35, 198, 150, 234, 20, 140, 100, 243, 215, 127, 218, 185, 207, 95, 51, 142, 10, 149 }, new byte[] { 79, 163, 62, 141, 252, 84, 220, 132, 246, 208, 207, 45, 181, 208, 130, 12, 105, 44, 90, 21, 167, 96, 170, 175, 93, 187, 7, 131, 68, 97, 149, 92, 238, 213, 68, 54, 15, 90, 217, 63, 41, 116, 58, 97, 10, 96, 76, 217, 89, 163, 163, 77, 145, 198, 210, 161, 26, 129, 149, 97, 52, 122, 199, 242, 213, 234, 85, 130, 138, 118, 184, 155, 50, 46, 178, 136, 221, 25, 45, 201, 140, 3, 36, 86, 167, 211, 99, 236, 183, 87, 249, 179, 31, 25, 170, 195, 73, 115, 58, 233, 108, 163, 87, 91, 224, 80, 134, 1, 255, 52, 132, 130, 39, 6, 94, 51, 110, 58, 78, 89, 161, 160, 242, 130, 181, 90, 225, 39 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9887), new byte[] { 188, 235, 74, 253, 5, 123, 129, 214, 124, 154, 211, 189, 181, 242, 227, 224, 250, 125, 33, 3, 72, 152, 94, 33, 49, 129, 52, 227, 29, 31, 207, 228, 158, 135, 26, 10, 72, 120, 56, 115, 116, 167, 72, 255, 192, 224, 189, 76, 125, 143, 84, 42, 82, 209, 147, 14, 155, 236, 156, 13, 154, 213, 215, 141 }, new byte[] { 254, 228, 216, 89, 139, 168, 155, 75, 183, 47, 104, 183, 118, 96, 111, 14, 105, 29, 76, 195, 97, 212, 54, 29, 13, 216, 143, 126, 15, 70, 186, 4, 46, 223, 253, 210, 246, 73, 145, 49, 13, 6, 64, 54, 73, 222, 241, 76, 144, 226, 41, 71, 33, 188, 217, 2, 248, 68, 152, 4, 13, 64, 220, 171, 19, 70, 137, 255, 28, 207, 139, 163, 187, 106, 22, 137, 227, 92, 127, 134, 90, 68, 55, 16, 109, 248, 158, 65, 4, 17, 213, 189, 151, 218, 86, 161, 81, 70, 122, 53, 51, 63, 157, 177, 80, 218, 61, 173, 24, 224, 219, 116, 250, 144, 38, 137, 30, 53, 228, 11, 191, 245, 105, 213, 134, 180, 27, 48 } });
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
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3560), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3563), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3756), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3760), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3760), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3762), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3762), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3763), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3766), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3767), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3769), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3769), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3772), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3773), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3774), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3778), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3778), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3778) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3780), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3780), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3783), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3784), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3785), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3786), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3785) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3787) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3791), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3792), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3793), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3796), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3796), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3797), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3798), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3798) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3800), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3801), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3802), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3820), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3824), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4020), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4020), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 9, 27, 22, 28, 47, 997, DateTimeKind.Utc).AddTicks(4555), new byte[] { 81, 131, 71, 210, 89, 13, 210, 107, 24, 224, 145, 154, 194, 83, 50, 79, 137, 246, 150, 24, 91, 152, 119, 71, 210, 9, 88, 68, 202, 27, 247, 22, 81, 34, 200, 245, 46, 0, 90, 222, 143, 181, 43, 77, 175, 218, 15, 135, 23, 243, 116, 190, 144, 220, 230, 174, 151, 245, 42, 106, 79, 79, 217, 207 }, new byte[] { 82, 166, 237, 99, 204, 173, 85, 34, 222, 218, 37, 0, 234, 81, 220, 223, 130, 203, 59, 42, 30, 176, 102, 14, 44, 253, 171, 211, 175, 31, 97, 152, 240, 41, 135, 209, 109, 172, 232, 246, 22, 135, 199, 53, 51, 77, 37, 140, 139, 132, 180, 252, 193, 132, 84, 153, 133, 241, 23, 253, 95, 225, 2, 66, 94, 117, 70, 86, 42, 135, 43, 114, 78, 72, 88, 234, 194, 205, 95, 235, 53, 182, 103, 109, 253, 208, 46, 255, 23, 8, 131, 58, 200, 220, 243, 54, 66, 87, 58, 124, 205, 206, 237, 212, 62, 80, 40, 85, 128, 140, 11, 121, 234, 189, 145, 209, 248, 142, 212, 202, 25, 45, 16, 130, 202, 131, 33, 70 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 22, 28, 47, 999, DateTimeKind.Utc).AddTicks(5563), new DateTime(2024, 9, 27, 22, 28, 47, 999, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 9, 27, 22, 28, 47, 999, DateTimeKind.Utc).AddTicks(5564), new byte[] { 215, 219, 173, 165, 118, 238, 156, 9, 41, 14, 34, 148, 186, 153, 221, 33, 124, 76, 197, 155, 199, 54, 89, 34, 173, 51, 28, 167, 70, 82, 157, 94, 161, 101, 245, 63, 158, 54, 103, 83, 213, 245, 221, 51, 203, 161, 22, 169, 99, 145, 72, 93, 203, 35, 254, 8, 234, 154, 202, 117, 54, 170, 6, 187 }, new byte[] { 201, 217, 67, 75, 119, 25, 199, 77, 57, 157, 57, 168, 72, 162, 170, 106, 12, 31, 197, 216, 111, 123, 250, 157, 89, 146, 104, 193, 86, 246, 176, 228, 91, 57, 167, 43, 73, 238, 194, 221, 46, 232, 66, 56, 140, 119, 66, 147, 35, 200, 235, 214, 113, 224, 61, 227, 90, 52, 33, 254, 35, 223, 191, 160, 31, 200, 250, 18, 147, 244, 253, 140, 239, 9, 93, 255, 54, 107, 177, 192, 154, 42, 133, 100, 232, 35, 8, 163, 159, 21, 134, 73, 51, 190, 112, 10, 2, 76, 38, 208, 131, 237, 12, 183, 109, 244, 159, 160, 58, 221, 165, 85, 221, 147, 123, 242, 230, 171, 125, 149, 86, 199, 28, 28, 1, 99, 198, 153 } });
        }
    }
}
