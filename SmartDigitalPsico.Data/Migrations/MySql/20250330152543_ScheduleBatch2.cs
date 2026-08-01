using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class ScheduleBatch2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ScheduleBatch_BatchToken",
                schema: "dbo",
                table: "ScheduleBatch");

            migrationBuilder.RenameColumn(
                name: "BatchToken",
                schema: "dbo",
                table: "ScheduleBatch",
                newName: "UniqueToken");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3986), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3989), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3998), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4000), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4009), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4011), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4015), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4016), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4048), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4051), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4052), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4053), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4055), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4056), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4057), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4058), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4059), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4060), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4059) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4061), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4062), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4066), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4067), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4068), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4069), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4075), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4076), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4077), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4078), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4079), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 328, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 328, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8693), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2047), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2052), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2054), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2055) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2056), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2057), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2058), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2059), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2060), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2061), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3137), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3138), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3156), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3157), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3162), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3162), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3170), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3173), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3174), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3382), new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3383), new byte[] { 239, 236, 156, 77, 230, 105, 152, 99, 15, 84, 206, 86, 169, 193, 11, 230, 49, 107, 69, 172, 222, 180, 161, 76, 42, 151, 177, 1, 146, 19, 175, 252, 4, 250, 124, 191, 95, 169, 31, 190, 92, 53, 228, 74, 127, 97, 182, 185, 211, 46, 74, 113, 125, 6, 40, 205, 25, 146, 11, 227, 63, 159, 129, 181 }, new byte[] { 135, 91, 225, 189, 12, 159, 120, 179, 125, 124, 47, 54, 108, 10, 137, 234, 137, 37, 149, 166, 185, 21, 76, 28, 197, 142, 30, 23, 26, 69, 154, 10, 242, 202, 252, 204, 109, 92, 7, 34, 217, 112, 168, 129, 117, 129, 69, 109, 241, 113, 117, 94, 58, 167, 58, 138, 149, 2, 124, 74, 167, 55, 245, 17, 138, 153, 200, 123, 33, 63, 249, 78, 152, 11, 49, 123, 200, 166, 115, 95, 200, 187, 46, 186, 147, 18, 226, 26, 51, 53, 83, 185, 27, 145, 27, 245, 169, 153, 222, 50, 143, 135, 67, 191, 109, 84, 236, 133, 188, 16, 126, 41, 25, 92, 233, 97, 201, 41, 51, 54, 164, 62, 233, 19, 53, 227, 175, 242 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5814), new byte[] { 21, 46, 165, 170, 165, 124, 150, 81, 18, 253, 168, 136, 252, 227, 190, 19, 79, 237, 72, 53, 216, 129, 239, 28, 129, 227, 204, 57, 232, 162, 164, 199, 227, 133, 102, 54, 151, 27, 190, 209, 141, 86, 153, 118, 81, 223, 104, 73, 182, 24, 28, 246, 159, 126, 51, 93, 60, 196, 34, 145, 99, 70, 41, 8 }, new byte[] { 134, 50, 211, 221, 221, 71, 146, 0, 20, 17, 15, 23, 252, 185, 115, 190, 48, 247, 54, 14, 167, 52, 111, 62, 100, 137, 47, 252, 22, 13, 153, 140, 185, 186, 52, 110, 156, 203, 215, 72, 183, 253, 106, 45, 105, 54, 235, 124, 41, 41, 238, 208, 61, 219, 167, 227, 167, 118, 183, 129, 244, 144, 118, 177, 128, 223, 22, 20, 105, 98, 136, 130, 129, 248, 234, 191, 117, 204, 207, 123, 212, 181, 160, 222, 28, 132, 97, 61, 232, 104, 30, 220, 198, 27, 21, 134, 60, 139, 236, 163, 78, 179, 81, 72, 4, 8, 21, 59, 120, 149, 154, 21, 230, 189, 139, 118, 201, 98, 153, 90, 211, 104, 220, 121, 94, 161, 67, 117 } });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_UniqueToken",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "UniqueToken",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ScheduleBatch_UniqueToken",
                schema: "dbo",
                table: "ScheduleBatch");

            migrationBuilder.RenameColumn(
                name: "UniqueToken",
                schema: "dbo",
                table: "ScheduleBatch",
                newName: "BatchToken");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6226), new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1887), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1888), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1889), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1897), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1899), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1901), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1903), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1904), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1910), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1912), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1914), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1921), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1922), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1923), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1924), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1925), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1927), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1928), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1929), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1933), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1934), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1935), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1936), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1937), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1938), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1939), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1940), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1941), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1942), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1943), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1944), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1948), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1949), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1950), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1951), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1952), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1953), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1954), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1955), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 412, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 412, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2823), new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2824), new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1840), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1846), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4830), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4831), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4833), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4834), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4835), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4836), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4837), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4838), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4839), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4840), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4841), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3124), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3125), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3153), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3159), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9467), new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9468), new byte[] { 48, 73, 188, 237, 233, 69, 180, 248, 66, 152, 105, 74, 162, 185, 125, 183, 128, 130, 199, 200, 115, 120, 221, 225, 218, 122, 24, 199, 51, 191, 88, 75, 216, 34, 235, 91, 167, 199, 112, 153, 24, 143, 149, 245, 63, 1, 225, 193, 24, 181, 186, 129, 44, 236, 180, 171, 129, 165, 180, 179, 221, 102, 98, 127 }, new byte[] { 100, 229, 75, 75, 24, 176, 155, 231, 44, 50, 61, 99, 196, 93, 166, 132, 59, 19, 209, 59, 142, 191, 32, 195, 144, 226, 61, 162, 75, 191, 175, 36, 27, 44, 240, 210, 70, 72, 184, 203, 246, 186, 156, 57, 17, 157, 111, 104, 56, 248, 18, 184, 160, 105, 251, 112, 222, 201, 70, 158, 3, 17, 208, 87, 50, 104, 24, 132, 47, 116, 78, 160, 136, 28, 100, 221, 151, 33, 79, 0, 210, 223, 243, 3, 173, 251, 197, 139, 4, 52, 55, 252, 10, 16, 58, 136, 105, 202, 10, 146, 240, 51, 178, 126, 239, 118, 138, 90, 1, 128, 216, 135, 157, 107, 220, 200, 105, 105, 170, 210, 231, 194, 145, 20, 69, 245, 144, 40 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(671), new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(671), new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(672), new byte[] { 187, 3, 142, 55, 59, 241, 39, 218, 242, 1, 121, 229, 41, 168, 139, 100, 152, 116, 19, 139, 254, 219, 33, 90, 129, 10, 117, 102, 167, 146, 37, 73, 106, 247, 199, 240, 29, 180, 45, 161, 43, 161, 246, 92, 40, 191, 45, 173, 93, 31, 171, 209, 97, 145, 74, 88, 227, 43, 172, 63, 51, 47, 114, 102 }, new byte[] { 55, 13, 85, 166, 169, 65, 3, 254, 21, 87, 85, 237, 137, 50, 23, 72, 139, 92, 98, 30, 16, 26, 245, 126, 209, 99, 206, 50, 6, 92, 202, 44, 219, 86, 98, 156, 140, 243, 65, 108, 176, 247, 226, 151, 244, 145, 190, 105, 219, 178, 32, 242, 246, 202, 230, 167, 44, 59, 127, 146, 236, 79, 62, 116, 130, 87, 217, 160, 57, 61, 15, 131, 10, 1, 250, 150, 178, 123, 17, 153, 104, 203, 125, 87, 178, 210, 255, 196, 186, 31, 45, 60, 78, 198, 57, 73, 68, 201, 32, 251, 58, 252, 90, 11, 187, 64, 220, 113, 196, 218, 5, 249, 133, 32, 231, 157, 72, 215, 163, 137, 223, 198, 123, 3, 204, 178, 100, 84 } });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_BatchToken",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "BatchToken");
        }
    }
}
