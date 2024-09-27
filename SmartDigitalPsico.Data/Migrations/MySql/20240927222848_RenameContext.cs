using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RenameContext : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4228), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4231), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4522), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4537), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4547), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4549), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4556), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4558), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4562), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4571), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4578), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4887), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5152), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5548), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5549), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5549), new byte[] { 80, 232, 90, 64, 28, 253, 160, 195, 126, 250, 157, 211, 209, 147, 252, 169, 95, 214, 249, 181, 78, 253, 102, 230, 194, 123, 226, 71, 64, 147, 41, 124, 129, 0, 20, 58, 137, 0, 33, 180, 241, 32, 5, 255, 72, 13, 248, 94, 64, 228, 180, 180, 241, 250, 250, 8, 52, 224, 9, 121, 164, 124, 73, 31 }, new byte[] { 136, 125, 6, 203, 230, 237, 28, 39, 107, 107, 16, 138, 91, 167, 30, 179, 248, 193, 237, 142, 170, 180, 23, 94, 132, 203, 211, 170, 16, 104, 184, 54, 17, 128, 69, 254, 187, 233, 54, 28, 210, 21, 225, 25, 201, 160, 60, 178, 57, 52, 61, 152, 218, 157, 226, 235, 15, 142, 77, 190, 181, 175, 53, 200, 204, 142, 33, 33, 101, 61, 120, 52, 87, 107, 53, 34, 232, 55, 208, 152, 205, 248, 134, 128, 44, 153, 83, 216, 54, 235, 85, 127, 166, 252, 94, 195, 7, 29, 221, 145, 24, 136, 198, 177, 37, 242, 26, 217, 166, 186, 1, 252, 229, 49, 53, 231, 199, 157, 87, 149, 160, 79, 49, 15, 252, 127, 186, 147 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8186), new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8187), new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8187), new byte[] { 223, 98, 181, 34, 243, 37, 195, 15, 219, 164, 34, 247, 5, 129, 173, 17, 125, 37, 70, 133, 13, 103, 194, 152, 144, 199, 166, 102, 26, 178, 247, 243, 62, 3, 23, 230, 103, 18, 100, 150, 213, 116, 212, 38, 139, 196, 3, 235, 141, 96, 235, 227, 115, 43, 137, 146, 98, 63, 171, 252, 123, 64, 222, 57 }, new byte[] { 162, 166, 217, 76, 29, 162, 105, 251, 50, 150, 13, 230, 247, 234, 192, 125, 203, 29, 245, 3, 217, 198, 22, 87, 133, 210, 199, 51, 214, 12, 61, 167, 158, 220, 200, 193, 161, 88, 65, 180, 249, 133, 188, 52, 212, 230, 127, 207, 52, 193, 155, 141, 198, 227, 189, 139, 255, 112, 87, 140, 86, 50, 55, 184, 204, 126, 97, 213, 5, 70, 46, 178, 24, 36, 33, 217, 125, 159, 221, 217, 176, 105, 43, 43, 89, 123, 12, 66, 79, 119, 122, 162, 57, 70, 52, 155, 25, 33, 118, 78, 22, 113, 197, 90, 202, 43, 199, 74, 84, 143, 164, 104, 45, 204, 63, 158, 79, 23, 157, 110, 66, 27, 98, 110, 120, 63, 123, 147 } });
        }
    }
}
