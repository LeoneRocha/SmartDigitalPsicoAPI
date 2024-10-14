using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv3 : Migration
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
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2572), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2578), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3820), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3822), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3826), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3827), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3828), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3829), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3831), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3833), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3834), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3835), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3838), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3840), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3875), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3876), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3877), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3878), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3879), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3882), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3883), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3884), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3885), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3886), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3898), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3899), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3900), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3901), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3902), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3903), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2309), new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9358), new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3115), new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3116), new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9168), new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9170), new byte[] { 240, 206, 132, 243, 213, 172, 179, 20, 91, 206, 44, 95, 112, 206, 129, 48, 235, 74, 211, 60, 71, 111, 157, 128, 71, 195, 195, 170, 205, 11, 191, 228, 228, 66, 30, 232, 14, 135, 112, 238, 244, 204, 236, 66, 249, 6, 125, 150, 168, 32, 195, 48, 31, 214, 135, 238, 123, 80, 46, 134, 226, 234, 51, 180 }, new byte[] { 96, 34, 61, 167, 114, 195, 189, 165, 160, 78, 47, 205, 130, 10, 126, 40, 26, 0, 251, 159, 107, 223, 250, 79, 144, 57, 50, 246, 187, 53, 9, 112, 16, 147, 22, 146, 98, 182, 118, 133, 184, 84, 63, 97, 171, 110, 75, 218, 51, 106, 100, 54, 178, 94, 255, 76, 237, 227, 105, 137, 20, 83, 37, 30, 122, 118, 146, 122, 108, 92, 177, 172, 222, 48, 71, 225, 145, 231, 142, 124, 115, 216, 115, 34, 177, 93, 237, 101, 195, 91, 238, 202, 81, 63, 183, 114, 52, 175, 224, 15, 149, 72, 187, 216, 99, 164, 182, 175, 211, 210, 132, 39, 235, 254, 43, 122, 57, 230, 103, 182, 28, 161, 89, 119, 22, 3, 231, 110 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(86), new byte[] { 250, 44, 220, 146, 173, 162, 138, 111, 252, 14, 183, 6, 185, 107, 201, 200, 114, 189, 156, 63, 62, 212, 39, 57, 4, 178, 209, 72, 40, 89, 195, 96, 25, 121, 241, 180, 182, 126, 169, 106, 146, 188, 140, 251, 1, 188, 84, 124, 62, 128, 226, 200, 247, 219, 184, 156, 29, 62, 75, 69, 169, 196, 149, 65 }, new byte[] { 135, 6, 80, 185, 19, 60, 48, 36, 33, 81, 99, 111, 150, 53, 36, 173, 74, 167, 76, 72, 77, 235, 78, 20, 20, 84, 115, 108, 80, 61, 173, 37, 212, 96, 38, 28, 244, 150, 61, 221, 127, 249, 88, 169, 109, 229, 170, 137, 129, 52, 222, 63, 50, 118, 59, 168, 98, 108, 177, 38, 126, 180, 74, 33, 35, 83, 40, 228, 185, 82, 110, 32, 240, 204, 241, 60, 233, 216, 38, 229, 162, 130, 81, 49, 184, 69, 96, 108, 11, 115, 183, 224, 141, 46, 224, 55, 186, 100, 69, 183, 69, 132, 175, 163, 171, 215, 254, 52, 181, 22, 177, 115, 134, 216, 118, 9, 123, 47, 138, 238, 130, 190, 50, 13, 37, 182, 196, 179 } });

            migrationBuilder.CreateIndex(
                name: "Idx_Title_Inc_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_Title_Inc_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 5, DateTimeKind.Utc).AddTicks(9486), new DateTime(2024, 10, 14, 1, 14, 19, 5, DateTimeKind.Utc).AddTicks(9494), new DateTime(2024, 10, 14, 1, 14, 19, 5, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(751), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(753), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(756), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(758), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(759), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(763), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(763), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(764), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(767), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(769), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(771), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(772), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(776), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(776), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(777), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(778), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(779), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(781), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(784), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(785), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(785) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(786), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(787), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(789), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(790), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(790), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(791), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(792), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(793), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(794), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(795), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(796), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(797), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(797), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(800), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(801), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(802), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(803), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(804), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(805), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(808), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(808), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(809), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(810), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(811), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(813), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(813), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(817), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(818), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(819), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(821), new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 24, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 10, 14, 1, 14, 19, 24, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 10, 14, 1, 14, 19, 24, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 6, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 12, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 10, 14, 1, 14, 19, 12, DateTimeKind.Utc).AddTicks(8713), new DateTime(2024, 10, 14, 1, 14, 19, 12, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 13, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 13, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 13, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 16, DateTimeKind.Utc).AddTicks(3877), new DateTime(2024, 10, 14, 1, 14, 19, 16, DateTimeKind.Utc).AddTicks(3878), new DateTime(2024, 10, 14, 1, 14, 19, 16, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 10, 14, 1, 14, 19, 18, DateTimeKind.Utc).AddTicks(9952), new byte[] { 86, 128, 253, 186, 123, 140, 77, 134, 189, 120, 234, 150, 249, 229, 72, 180, 104, 80, 242, 27, 237, 223, 194, 175, 199, 198, 14, 117, 180, 157, 5, 57, 186, 179, 127, 211, 211, 211, 188, 164, 51, 150, 20, 195, 107, 158, 30, 218, 136, 86, 127, 146, 149, 91, 118, 48, 183, 194, 3, 171, 5, 115, 213, 89 }, new byte[] { 43, 62, 210, 168, 132, 148, 6, 234, 172, 36, 143, 190, 213, 35, 166, 155, 20, 253, 246, 60, 0, 3, 90, 100, 166, 186, 104, 158, 197, 11, 95, 155, 172, 236, 64, 176, 123, 121, 75, 77, 111, 91, 125, 114, 243, 226, 34, 97, 160, 55, 155, 224, 101, 86, 19, 127, 166, 167, 3, 78, 42, 13, 26, 88, 250, 127, 33, 74, 188, 22, 5, 149, 98, 106, 134, 175, 68, 141, 68, 98, 38, 129, 53, 83, 30, 229, 143, 210, 61, 31, 205, 173, 45, 166, 155, 178, 48, 231, 79, 118, 152, 73, 64, 43, 113, 121, 184, 113, 119, 51, 154, 82, 225, 16, 19, 63, 84, 85, 98, 93, 4, 250, 16, 247, 63, 144, 32, 195 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 14, 19, 21, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 10, 14, 1, 14, 19, 21, DateTimeKind.Utc).AddTicks(774), new DateTime(2024, 10, 14, 1, 14, 19, 21, DateTimeKind.Utc).AddTicks(774), new byte[] { 199, 4, 96, 245, 250, 171, 108, 251, 25, 33, 41, 80, 36, 193, 152, 188, 71, 43, 59, 243, 138, 18, 163, 199, 34, 188, 143, 123, 36, 169, 175, 106, 149, 33, 56, 50, 211, 125, 30, 133, 197, 205, 230, 130, 9, 157, 100, 105, 1, 34, 216, 195, 65, 141, 207, 79, 227, 140, 135, 197, 103, 51, 192, 50 }, new byte[] { 228, 160, 31, 187, 89, 42, 51, 109, 5, 172, 66, 97, 205, 22, 212, 192, 19, 10, 169, 25, 172, 0, 223, 31, 206, 185, 212, 222, 85, 162, 140, 106, 152, 90, 125, 238, 225, 127, 48, 55, 66, 206, 141, 122, 133, 3, 244, 78, 152, 121, 197, 139, 69, 39, 220, 213, 72, 111, 238, 111, 125, 94, 30, 213, 73, 158, 149, 206, 92, 171, 12, 171, 180, 157, 100, 205, 207, 108, 90, 184, 60, 112, 198, 65, 168, 47, 159, 185, 119, 111, 174, 87, 135, 229, 57, 89, 60, 101, 213, 139, 117, 96, 192, 87, 78, 135, 107, 19, 212, 55, 92, 155, 164, 136, 231, 130, 17, 0, 143, 97, 8, 28, 172, 205, 116, 18, 202, 133 } });
        }
    }
}
