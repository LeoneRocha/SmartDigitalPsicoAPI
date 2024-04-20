using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRolegroup2 : Migration
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
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6739), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6742), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6977), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6979), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6982), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6995), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7001), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7002), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7038), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7041), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7048), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7050), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7052), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7058), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7059), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7060), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7061), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7062), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7064) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7300), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroupUser",
                columns: new[] { "RoleGroupId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7890), new byte[] { 48, 102, 156, 40, 24, 42, 10, 13, 168, 133, 239, 28, 223, 76, 106, 9, 167, 164, 145, 32, 63, 211, 239, 124, 2, 193, 251, 88, 195, 96, 70, 62, 91, 112, 11, 198, 254, 113, 204, 141, 140, 222, 191, 176, 133, 199, 254, 199, 189, 27, 67, 39, 77, 11, 75, 244, 213, 80, 143, 163, 178, 242, 222, 203 }, new byte[] { 80, 116, 215, 198, 74, 250, 129, 182, 21, 91, 53, 7, 249, 131, 141, 134, 62, 79, 74, 102, 129, 164, 5, 216, 85, 200, 240, 230, 144, 3, 164, 197, 171, 18, 2, 185, 61, 104, 23, 160, 152, 94, 195, 101, 40, 240, 134, 88, 168, 121, 186, 161, 39, 150, 3, 59, 13, 216, 63, 231, 166, 249, 142, 165, 106, 247, 200, 57, 123, 96, 207, 245, 212, 145, 241, 49, 34, 184, 175, 67, 190, 49, 227, 23, 121, 200, 4, 12, 1, 156, 77, 240, 197, 32, 123, 175, 29, 212, 81, 185, 242, 124, 4, 34, 212, 1, 236, 150, 237, 219, 54, 214, 28, 22, 141, 71, 34, 124, 128, 15, 244, 243, 144, 71, 40, 174, 218, 220 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8895), new byte[] { 58, 204, 104, 212, 99, 234, 183, 251, 247, 20, 63, 107, 158, 244, 54, 15, 129, 219, 197, 175, 111, 224, 90, 143, 155, 56, 239, 147, 12, 235, 29, 234, 50, 43, 178, 129, 51, 50, 154, 135, 35, 140, 238, 117, 144, 240, 19, 187, 204, 236, 17, 184, 181, 53, 5, 69, 18, 246, 251, 56, 161, 127, 234, 203 }, new byte[] { 159, 235, 88, 217, 15, 119, 14, 38, 64, 79, 111, 251, 167, 117, 7, 242, 1, 53, 208, 185, 227, 255, 134, 81, 15, 41, 222, 135, 161, 37, 238, 64, 239, 14, 205, 209, 32, 127, 40, 24, 25, 133, 121, 76, 92, 160, 159, 60, 250, 69, 255, 236, 119, 115, 62, 184, 242, 247, 190, 207, 14, 77, 38, 209, 9, 168, 91, 113, 116, 74, 193, 29, 50, 236, 153, 25, 150, 165, 96, 162, 239, 141, 124, 14, 159, 112, 65, 80, 124, 231, 102, 27, 30, 47, 45, 62, 176, 229, 144, 0, 203, 156, 227, 16, 212, 97, 117, 39, 199, 233, 239, 20, 174, 156, 190, 227, 138, 76, 225, 242, 210, 242, 190, 205, 4, 27, 248, 146 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "RoleGroupUser",
                keyColumns: new[] { "RoleGroupId", "UserId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(179), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(183), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(431), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(433), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(433), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(438), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(439), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(439), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(439) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(441), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(442), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(451), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(451), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(453), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(453), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(494), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(509), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(513), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(524), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(526), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(527), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(528), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(529), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(530), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(531), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(753), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(753), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1329), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 4, 20, 22, 9, 33, 820, DateTimeKind.Utc).AddTicks(1330), new byte[] { 128, 229, 133, 0, 216, 91, 3, 44, 51, 43, 11, 40, 157, 177, 71, 62, 8, 134, 49, 55, 76, 209, 95, 198, 196, 149, 72, 96, 43, 248, 97, 135, 157, 212, 127, 14, 122, 72, 52, 245, 130, 227, 50, 209, 238, 128, 115, 186, 114, 158, 164, 40, 119, 214, 236, 234, 238, 27, 57, 200, 51, 13, 88, 79 }, new byte[] { 249, 46, 42, 40, 209, 35, 114, 91, 140, 116, 137, 60, 60, 173, 107, 184, 126, 88, 225, 207, 128, 149, 209, 172, 5, 8, 44, 191, 44, 138, 56, 75, 177, 202, 140, 223, 225, 175, 43, 8, 254, 193, 47, 93, 117, 151, 202, 242, 6, 179, 140, 164, 1, 18, 147, 45, 164, 238, 211, 16, 137, 213, 87, 168, 165, 143, 63, 250, 99, 200, 216, 68, 115, 27, 66, 103, 200, 26, 214, 243, 106, 214, 104, 2, 149, 63, 51, 252, 211, 199, 109, 29, 225, 165, 56, 64, 240, 75, 60, 7, 2, 62, 25, 61, 19, 101, 79, 172, 227, 144, 208, 50, 235, 22, 167, 177, 42, 60, 122, 161, 241, 43, 220, 229, 52, 217, 117, 155 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 9, 33, 822, DateTimeKind.Utc).AddTicks(2808), new DateTime(2024, 4, 20, 22, 9, 33, 822, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 4, 20, 22, 9, 33, 822, DateTimeKind.Utc).AddTicks(2815), new byte[] { 113, 251, 231, 102, 184, 85, 65, 184, 150, 29, 92, 141, 184, 119, 61, 133, 140, 246, 173, 151, 225, 248, 58, 123, 167, 92, 11, 116, 59, 39, 81, 58, 218, 0, 175, 182, 57, 90, 250, 196, 41, 166, 23, 249, 216, 42, 53, 212, 82, 112, 150, 39, 109, 160, 38, 100, 239, 124, 25, 59, 40, 127, 119, 189 }, new byte[] { 133, 28, 171, 97, 26, 99, 161, 147, 242, 191, 218, 230, 226, 116, 244, 121, 127, 229, 247, 193, 37, 13, 106, 4, 116, 223, 143, 72, 151, 167, 129, 39, 230, 203, 6, 59, 200, 23, 242, 16, 201, 24, 51, 238, 87, 25, 245, 159, 153, 122, 205, 203, 172, 107, 77, 133, 155, 201, 187, 153, 149, 83, 5, 99, 97, 190, 88, 223, 153, 114, 109, 209, 132, 101, 63, 35, 24, 130, 158, 44, 65, 99, 93, 205, 151, 128, 99, 254, 25, 32, 70, 103, 45, 115, 130, 89, 202, 33, 148, 121, 101, 2, 27, 5, 227, 14, 201, 156, 240, 101, 173, 121, 104, 93, 129, 236, 114, 206, 79, 77, 104, 64, 154, 226, 151, 4, 5, 248 } });
        }
    }
}
