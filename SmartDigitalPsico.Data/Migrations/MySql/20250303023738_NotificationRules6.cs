using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRules6 : Migration
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
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8765), new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8768), new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3978), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3982), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3983), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3984), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3985), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3986), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3987), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3995), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4000), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4002), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4003), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4009), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4011), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4015), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4016), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4018), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4019), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4020), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4022), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4024), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4025), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4026), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4027), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4031), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4032), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4033), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4034), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4046), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5136), new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5138), new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9534), new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9535), new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(6997), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7002), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7003), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7006), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7013), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1715), new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4309), new byte[] { 201, 177, 3, 181, 61, 126, 159, 177, 151, 37, 63, 16, 177, 176, 32, 141, 166, 136, 46, 217, 152, 62, 222, 40, 220, 50, 178, 230, 212, 136, 51, 254, 177, 151, 243, 149, 16, 158, 197, 212, 97, 238, 222, 92, 201, 197, 46, 252, 114, 147, 14, 6, 117, 174, 150, 58, 166, 73, 172, 242, 24, 248, 50, 137 }, new byte[] { 142, 10, 186, 83, 210, 212, 135, 86, 64, 131, 222, 3, 163, 61, 59, 65, 198, 192, 228, 169, 184, 77, 114, 235, 219, 8, 5, 15, 109, 62, 12, 96, 26, 224, 99, 85, 179, 153, 213, 103, 68, 220, 83, 88, 77, 87, 51, 157, 193, 190, 56, 154, 22, 64, 95, 95, 253, 64, 179, 212, 80, 90, 121, 60, 56, 94, 11, 176, 122, 11, 170, 57, 113, 159, 66, 163, 65, 83, 238, 27, 233, 158, 156, 143, 73, 181, 127, 93, 245, 196, 112, 94, 87, 52, 242, 165, 87, 113, 193, 46, 35, 151, 220, 83, 91, 13, 167, 199, 178, 34, 249, 166, 252, 255, 24, 71, 24, 136, 109, 254, 208, 19, 237, 111, 221, 135, 1, 37 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6380), new byte[] { 7, 184, 208, 237, 231, 156, 227, 29, 104, 143, 15, 201, 211, 254, 223, 150, 116, 8, 245, 30, 69, 45, 133, 198, 251, 69, 171, 5, 249, 231, 102, 156, 107, 161, 17, 149, 203, 209, 222, 63, 100, 230, 142, 50, 64, 252, 61, 210, 200, 231, 192, 182, 172, 178, 4, 202, 161, 42, 152, 36, 90, 219, 251, 126 }, new byte[] { 246, 168, 236, 41, 179, 238, 137, 163, 10, 187, 235, 217, 183, 57, 203, 185, 158, 83, 17, 69, 104, 64, 25, 185, 212, 152, 45, 69, 175, 204, 143, 244, 33, 128, 178, 88, 124, 201, 76, 210, 211, 204, 30, 149, 164, 227, 222, 44, 19, 243, 56, 172, 85, 169, 111, 112, 231, 83, 64, 221, 93, 146, 249, 28, 152, 167, 168, 242, 99, 61, 205, 127, 86, 190, 144, 158, 96, 193, 155, 45, 30, 200, 221, 65, 99, 209, 147, 174, 241, 237, 90, 206, 86, 14, 178, 1, 96, 219, 70, 138, 170, 187, 176, 151, 136, 231, 93, 91, 145, 247, 142, 192, 254, 51, 90, 138, 11, 127, 250, 60, 156, 111, 108, 52, 75, 169, 36, 76 } });
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
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6274), new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1402), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1411), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1412), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1414), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1415), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1416), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1417), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1418), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1419), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1420), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1425), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1426), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1427), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1428), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1429), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1433), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1434), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1435), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1436), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1437), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1438), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1444), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1445), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1446), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1447), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1448), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1449), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1451), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1454), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1455), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1456), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1457), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1465), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1468), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1469), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1486), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1487), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1488), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1489), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1490), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1491), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2130), new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7451), new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4967), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4969), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4974), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4979), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4981), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4982), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4983), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9659), new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(849), new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(851), new byte[] { 185, 38, 212, 49, 159, 6, 233, 150, 6, 141, 190, 65, 32, 195, 212, 89, 100, 12, 140, 209, 119, 211, 15, 98, 206, 63, 133, 82, 135, 172, 95, 241, 133, 132, 90, 142, 28, 38, 56, 32, 17, 23, 24, 193, 18, 71, 239, 103, 215, 252, 18, 183, 106, 67, 18, 193, 25, 250, 58, 251, 38, 11, 164, 77 }, new byte[] { 162, 77, 225, 177, 172, 22, 136, 177, 95, 220, 44, 207, 52, 225, 160, 125, 242, 244, 85, 23, 242, 178, 104, 248, 175, 31, 217, 54, 182, 245, 29, 24, 84, 224, 171, 209, 97, 94, 91, 61, 244, 123, 206, 19, 62, 252, 155, 77, 164, 44, 89, 188, 194, 72, 243, 219, 134, 63, 13, 134, 90, 136, 120, 169, 77, 122, 146, 115, 137, 68, 54, 240, 46, 48, 192, 112, 231, 248, 54, 7, 247, 83, 119, 102, 20, 19, 135, 242, 176, 199, 149, 179, 162, 165, 180, 101, 127, 110, 51, 177, 225, 211, 247, 166, 206, 174, 63, 75, 242, 126, 132, 1, 238, 158, 76, 235, 237, 125, 108, 31, 111, 119, 111, 133, 52, 67, 189, 149 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2674), new byte[] { 201, 28, 88, 164, 3, 237, 148, 103, 25, 51, 195, 98, 226, 154, 53, 110, 190, 53, 58, 229, 180, 207, 229, 51, 126, 75, 183, 230, 93, 155, 240, 99, 120, 57, 166, 188, 198, 60, 191, 191, 177, 16, 52, 158, 85, 157, 165, 97, 126, 184, 27, 125, 174, 58, 181, 21, 55, 160, 154, 72, 104, 150, 157, 76 }, new byte[] { 224, 233, 243, 79, 67, 85, 138, 72, 32, 1, 82, 169, 121, 173, 221, 214, 67, 112, 196, 183, 197, 142, 163, 51, 2, 29, 170, 123, 39, 60, 189, 210, 174, 84, 238, 37, 117, 101, 77, 209, 232, 65, 58, 189, 62, 159, 97, 12, 164, 111, 125, 7, 44, 104, 84, 110, 89, 10, 154, 226, 51, 162, 58, 170, 42, 170, 111, 225, 147, 235, 164, 228, 233, 237, 191, 18, 148, 70, 51, 239, 125, 9, 239, 120, 44, 100, 223, 223, 97, 174, 251, 207, 41, 56, 51, 145, 181, 234, 120, 163, 24, 199, 180, 201, 7, 51, 253, 224, 238, 75, 132, 239, 33, 42, 157, 169, 184, 175, 131, 42, 137, 131, 217, 4, 103, 93, 61, 69 } });
        }
    }
}
