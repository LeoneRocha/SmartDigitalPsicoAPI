using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecords2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FinalSendDate",
                schema: "dbo",
                table: "NotificationRecords",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                schema: "dbo",
                table: "NotificationRecords",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextScheduledSendTime",
                schema: "dbo",
                table: "NotificationRecords",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 209, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 3, 1, 16, 36, 12, 209, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 3, 1, 16, 36, 12, 209, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3129), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3130), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3132), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3133), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3134), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3135), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3136), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3137), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3163), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3165), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3167), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3168), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3170), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3171), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3171), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3173), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3173), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3174), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3179), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3180), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3182), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3182), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3186), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3187), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3188), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3190), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3191), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3192), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3193), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3194), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3197), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3197), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3199), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3200), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3201), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3202), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3204), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3205), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3204) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3210), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3211), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3212), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3217), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3219), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3219), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3221), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3221), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3223), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3224), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3227), new DateTime(2025, 3, 1, 16, 36, 12, 210, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 211, DateTimeKind.Utc).AddTicks(4353), new DateTime(2025, 3, 1, 16, 36, 12, 211, DateTimeKind.Utc).AddTicks(4354), new DateTime(2025, 3, 1, 16, 36, 12, 211, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 211, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 211, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 220, DateTimeKind.Utc).AddTicks(9602), new DateTime(2025, 3, 1, 16, 36, 12, 220, DateTimeKind.Utc).AddTicks(9604), new DateTime(2025, 3, 1, 16, 36, 12, 220, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 228, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 228, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 228, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 231, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 3, 1, 16, 36, 12, 231, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 3, 1, 16, 36, 12, 231, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 234, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(8646), new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(8647), new DateTime(2025, 3, 1, 16, 36, 12, 235, DateTimeKind.Utc).AddTicks(8648), new byte[] { 166, 137, 214, 183, 193, 95, 70, 55, 2, 255, 253, 227, 119, 61, 65, 237, 31, 223, 221, 39, 22, 173, 223, 119, 252, 27, 155, 106, 4, 28, 241, 144, 178, 88, 172, 159, 136, 163, 223, 161, 241, 37, 122, 28, 19, 130, 170, 41, 112, 93, 35, 126, 43, 145, 121, 202, 20, 184, 115, 38, 181, 35, 132, 225 }, new byte[] { 231, 80, 147, 170, 246, 193, 168, 211, 207, 120, 58, 41, 239, 237, 134, 108, 100, 128, 179, 103, 50, 158, 128, 55, 57, 24, 213, 251, 174, 108, 192, 28, 68, 59, 94, 98, 148, 74, 83, 78, 201, 87, 136, 138, 167, 211, 6, 60, 60, 17, 179, 50, 219, 124, 200, 209, 21, 55, 118, 23, 16, 191, 147, 103, 60, 41, 133, 181, 56, 120, 119, 142, 113, 231, 110, 237, 59, 18, 227, 245, 165, 203, 30, 153, 183, 153, 66, 161, 235, 9, 26, 206, 126, 230, 239, 73, 77, 34, 12, 118, 140, 249, 71, 226, 91, 103, 123, 1, 104, 18, 188, 187, 19, 76, 20, 249, 242, 34, 58, 30, 77, 113, 166, 154, 32, 57, 86, 169 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 36, 12, 237, DateTimeKind.Utc).AddTicks(9979), new DateTime(2025, 3, 1, 16, 36, 12, 237, DateTimeKind.Utc).AddTicks(9979), new DateTime(2025, 3, 1, 16, 36, 12, 237, DateTimeKind.Utc).AddTicks(9980), new byte[] { 160, 237, 100, 119, 79, 252, 24, 134, 186, 84, 248, 58, 201, 135, 254, 133, 224, 120, 71, 227, 42, 104, 215, 163, 102, 203, 14, 89, 72, 22, 167, 104, 72, 34, 86, 221, 223, 157, 118, 178, 216, 66, 35, 245, 24, 126, 247, 41, 88, 245, 221, 219, 228, 95, 156, 83, 163, 207, 216, 141, 254, 99, 222, 212 }, new byte[] { 205, 179, 146, 124, 43, 191, 154, 3, 168, 104, 141, 180, 186, 84, 58, 29, 28, 166, 230, 10, 179, 120, 56, 179, 42, 216, 179, 161, 35, 128, 78, 254, 61, 241, 216, 55, 52, 100, 23, 98, 63, 199, 212, 71, 18, 230, 196, 88, 81, 45, 185, 50, 42, 250, 0, 97, 17, 247, 41, 192, 131, 176, 134, 178, 43, 29, 16, 161, 138, 235, 62, 112, 46, 232, 3, 48, 145, 93, 201, 192, 79, 63, 15, 251, 234, 163, 69, 47, 26, 145, 180, 171, 66, 99, 65, 133, 205, 202, 201, 213, 45, 209, 235, 112, 118, 168, 92, 129, 142, 5, 172, 180, 81, 127, 34, 114, 85, 139, 91, 251, 94, 33, 100, 8, 196, 24, 96, 40 } });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_IsCompleted",
                schema: "dbo",
                table: "NotificationRecords",
                column: "IsCompleted");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_NextScheduledSendTime",
                schema: "dbo",
                table: "NotificationRecords",
                column: "NextScheduledSendTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NotificationRecords_IsCompleted",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.DropIndex(
                name: "IX_NotificationRecords_NextScheduledSendTime",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.DropColumn(
                name: "FinalSendDate",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.DropColumn(
                name: "NextScheduledSendTime",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2809), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7894), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7896), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7897), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7898), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7905), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7906), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7907), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7909), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7911), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7916), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7917), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7919), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7920), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7921), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7922), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7923), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7927), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7949), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7951), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7952), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7953), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7954), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7959), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7960), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7961), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8526), new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8527), new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 876, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 876, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2156), new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4772), new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4773), new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(603), new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(604), new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(605), new byte[] { 50, 111, 107, 89, 62, 206, 44, 29, 25, 243, 49, 174, 183, 250, 24, 98, 137, 144, 161, 156, 144, 4, 179, 249, 171, 74, 157, 197, 178, 6, 67, 162, 192, 118, 11, 105, 224, 68, 186, 241, 204, 212, 43, 72, 67, 11, 145, 117, 94, 51, 217, 128, 135, 92, 162, 176, 17, 21, 81, 162, 58, 35, 142, 66 }, new byte[] { 65, 34, 62, 220, 82, 201, 199, 170, 114, 168, 18, 87, 64, 219, 68, 141, 160, 113, 88, 125, 137, 220, 33, 174, 117, 85, 163, 241, 247, 22, 140, 129, 153, 211, 133, 98, 140, 236, 226, 166, 5, 63, 36, 65, 8, 36, 15, 54, 181, 204, 69, 221, 163, 196, 24, 140, 44, 125, 67, 196, 100, 167, 213, 156, 0, 56, 185, 87, 173, 20, 162, 49, 122, 89, 114, 84, 60, 131, 68, 183, 138, 115, 71, 203, 127, 246, 107, 220, 168, 64, 118, 120, 155, 5, 242, 69, 72, 204, 42, 230, 78, 35, 239, 2, 10, 3, 170, 224, 115, 206, 167, 146, 174, 184, 234, 169, 185, 34, 218, 249, 129, 91, 230, 164, 93, 116, 48, 158 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7538), new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7539), new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7539), new byte[] { 228, 165, 115, 56, 235, 83, 168, 242, 145, 139, 80, 183, 240, 47, 53, 207, 140, 134, 171, 175, 189, 3, 32, 219, 111, 92, 14, 209, 211, 46, 207, 212, 223, 219, 112, 240, 254, 215, 128, 126, 89, 55, 239, 28, 91, 86, 27, 29, 141, 166, 187, 196, 11, 208, 63, 216, 69, 209, 157, 33, 208, 111, 31, 201 }, new byte[] { 206, 8, 179, 49, 210, 130, 162, 77, 203, 74, 13, 247, 113, 101, 62, 26, 123, 165, 185, 174, 64, 86, 134, 132, 147, 244, 114, 121, 51, 49, 225, 237, 180, 32, 6, 23, 200, 54, 61, 176, 144, 181, 126, 202, 132, 62, 140, 199, 56, 245, 126, 31, 163, 230, 158, 119, 119, 180, 26, 79, 175, 111, 116, 11, 214, 168, 199, 181, 213, 83, 40, 60, 121, 93, 32, 195, 45, 188, 214, 34, 105, 78, 121, 85, 44, 226, 139, 191, 67, 246, 94, 222, 227, 170, 242, 192, 150, 173, 7, 192, 211, 64, 150, 149, 61, 26, 136, 0, 154, 205, 204, 230, 173, 126, 94, 32, 194, 16, 29, 180, 201, 114, 13, 210, 31, 29, 153, 209 } });
        }
    }
}
