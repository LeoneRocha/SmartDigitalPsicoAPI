using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class AddEmailTemplate2 : Migration
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
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1593), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3116), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3118), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3121), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3122), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3123), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3127), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3129), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3131), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3132), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3142), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3144), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3145), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3146), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3152), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3156), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3159), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3164), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3178), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3181), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3186), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3187), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Body", "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { "<html>\r\n<head>\r\n    <style>\r\n        body {{ font-family: Arial, sans-serif; background-color: #f4f4f9; color: #333; padding: 20px; }}\r\n        .container {{ max-width: 600px; margin: 0 auto; background-color: #fff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }}\r\n        .header {{ text-align: center; padding-bottom: 20px; }}\r\n        .header h1 {{ margin: 0; color: #4CAF50; }}\r\n        .content {{ line-height: 1.6; }}\r\n        .footer {{ text-align: center; padding-top: 20px; font-size: 0.9em; color: #777; }}\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class='container'>\r\n        <div class='header'>\r\n            <h1>Access Granted</h1>\r\n        </div>\r\n        <div class='content'>\r\n            <p>Hello,</p>\r\n            <p>Your access has been granted. Below are your login details:</p>\r\n            <p><strong>URL:</strong> <a href='[{AccessUrl}]'>[{AccessUrl}]</a></p>\r\n            <p><strong>Email:</strong> [{Email}]</p>\r\n            <p><strong>Temporary Password:</strong> [{Password}]</p>\r\n            <p>Please change your password after your first login.</p>\r\n        </div>\r\n        <div class='footer'>\r\n            <p>Thank you for joining us!</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>", new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5667), new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9303), new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1011), new byte[] { 81, 211, 123, 111, 82, 6, 24, 223, 154, 173, 67, 252, 93, 103, 148, 146, 213, 132, 5, 246, 70, 216, 230, 233, 10, 38, 190, 41, 165, 188, 210, 172, 45, 163, 53, 78, 90, 74, 3, 97, 247, 88, 202, 18, 210, 4, 152, 33, 207, 236, 43, 180, 93, 186, 37, 43, 42, 21, 176, 26, 242, 58, 4, 85 }, new byte[] { 74, 44, 214, 227, 206, 39, 128, 15, 45, 7, 96, 60, 127, 31, 186, 253, 159, 86, 255, 4, 87, 13, 76, 153, 221, 51, 26, 191, 193, 7, 250, 156, 31, 106, 128, 26, 215, 206, 32, 90, 100, 145, 70, 248, 29, 177, 83, 173, 188, 86, 198, 204, 48, 171, 110, 82, 20, 54, 71, 82, 135, 33, 161, 107, 72, 229, 75, 113, 162, 147, 172, 37, 22, 45, 192, 225, 217, 132, 25, 5, 249, 156, 232, 96, 29, 209, 131, 49, 149, 177, 72, 38, 136, 142, 39, 111, 80, 212, 235, 185, 89, 176, 88, 112, 136, 55, 189, 245, 172, 245, 163, 23, 102, 1, 192, 210, 186, 202, 165, 191, 118, 132, 178, 101, 125, 133, 197, 145 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3483), new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3485), new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3485), new byte[] { 76, 237, 200, 195, 200, 126, 98, 215, 145, 165, 59, 165, 226, 5, 153, 57, 56, 72, 246, 249, 135, 86, 128, 65, 211, 211, 106, 97, 97, 1, 147, 125, 125, 88, 11, 210, 64, 127, 254, 223, 226, 14, 17, 189, 102, 118, 3, 232, 74, 240, 197, 243, 0, 106, 149, 176, 178, 210, 132, 15, 94, 113, 220, 40 }, new byte[] { 211, 209, 134, 38, 84, 49, 170, 142, 173, 208, 247, 20, 180, 165, 217, 190, 23, 24, 254, 88, 135, 203, 187, 45, 57, 249, 134, 170, 107, 230, 48, 199, 204, 147, 0, 69, 58, 193, 131, 225, 183, 64, 179, 67, 181, 155, 30, 120, 78, 143, 236, 139, 137, 199, 200, 126, 175, 43, 179, 127, 230, 139, 42, 113, 228, 41, 26, 235, 188, 73, 175, 0, 94, 87, 228, 126, 54, 227, 161, 211, 235, 8, 114, 102, 38, 177, 168, 147, 128, 36, 81, 240, 83, 223, 255, 235, 168, 171, 98, 74, 244, 9, 227, 222, 87, 93, 46, 36, 147, 201, 149, 245, 100, 193, 29, 153, 49, 38, 49, 84, 184, 133, 144, 119, 186, 161, 241, 32 } });
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
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(941), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(988), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(990), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(995), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1004), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Body", "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { "<html>\r\n<head>\r\n    <style>\r\n        body {{ font-family: Arial, sans-serif; background-color: #f4f4f9; color: #333; padding: 20px; }}\r\n        .container {{ max-width: 600px; margin: 0 auto; background-color: #fff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }}\r\n        .header {{ text-align: center; padding-bottom: 20px; }}\r\n        .header h1 {{ margin: 0; color: #4CAF50; }}\r\n        .content {{ line-height: 1.6; }}\r\n        .footer {{ text-align: center; padding-top: 20px; font-size: 0.9em; color: #777; }}\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class='container'>\r\n        <div class='header'>\r\n            <h1>Access Granted</h1>\r\n        </div>\r\n        <div class='content'>\r\n            <p>Hello,</p>\r\n            <p>Your access has been granted. Below are your login details:</p>\r\n            <p><strong>URL:</strong> <a href='{{AccessUrl}}'>{{AccessUrl}}</a></p>\r\n            <p><strong>Email:</strong> {{Email}}</p>\r\n            <p><strong>Temporary Password:</strong> {{Password}}</p>\r\n            <p>Please change your password after your first login.</p>\r\n        </div>\r\n        <div class='footer'>\r\n            <p>Thank you for joining us!</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>", new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6206), new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(411), new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(412), new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6686), new byte[] { 73, 78, 157, 49, 149, 0, 151, 77, 68, 239, 77, 79, 79, 181, 53, 169, 212, 62, 17, 180, 137, 87, 7, 148, 81, 91, 7, 232, 182, 114, 207, 79, 10, 207, 155, 54, 220, 13, 112, 173, 57, 219, 139, 202, 166, 157, 180, 19, 209, 37, 54, 221, 39, 128, 154, 124, 55, 242, 203, 174, 52, 152, 71, 115 }, new byte[] { 205, 216, 30, 238, 39, 193, 246, 249, 162, 187, 16, 249, 54, 129, 223, 225, 115, 240, 16, 120, 0, 193, 113, 182, 78, 120, 60, 50, 217, 3, 113, 67, 204, 121, 105, 28, 79, 49, 9, 235, 171, 10, 143, 73, 19, 133, 167, 108, 28, 252, 91, 35, 25, 141, 74, 178, 10, 245, 58, 227, 81, 12, 150, 126, 51, 71, 160, 32, 151, 77, 142, 218, 251, 16, 142, 105, 143, 185, 238, 121, 4, 172, 233, 80, 26, 150, 66, 130, 14, 199, 250, 145, 141, 76, 63, 45, 48, 215, 200, 9, 57, 64, 221, 64, 159, 208, 213, 233, 135, 225, 223, 116, 203, 30, 145, 131, 213, 13, 142, 137, 162, 240, 129, 123, 45, 31, 35, 72 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8447), new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8448), new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8448), new byte[] { 73, 212, 158, 81, 45, 83, 146, 191, 213, 141, 183, 248, 106, 225, 72, 173, 190, 231, 111, 200, 157, 209, 156, 29, 16, 22, 225, 6, 40, 146, 111, 217, 110, 157, 218, 126, 203, 45, 17, 8, 203, 150, 76, 36, 148, 87, 207, 63, 105, 82, 113, 109, 218, 105, 69, 5, 211, 69, 37, 3, 234, 208, 234, 31 }, new byte[] { 125, 130, 72, 115, 126, 240, 188, 83, 149, 213, 159, 204, 147, 183, 43, 1, 189, 234, 238, 43, 226, 222, 200, 188, 223, 55, 126, 205, 15, 253, 85, 3, 78, 254, 47, 218, 70, 217, 239, 106, 137, 144, 141, 221, 206, 53, 150, 188, 49, 94, 57, 210, 210, 55, 85, 205, 138, 249, 151, 72, 29, 122, 69, 236, 62, 199, 246, 60, 46, 190, 168, 6, 84, 107, 22, 35, 16, 100, 184, 152, 92, 145, 174, 55, 12, 252, 168, 60, 70, 127, 196, 183, 123, 47, 64, 38, 105, 139, 204, 35, 218, 193, 142, 173, 215, 4, 217, 20, 165, 180, 37, 126, 104, 213, 245, 182, 146, 100, 37, 156, 147, 223, 96, 107, 241, 166, 143, 241 } });
        }
    }
}
