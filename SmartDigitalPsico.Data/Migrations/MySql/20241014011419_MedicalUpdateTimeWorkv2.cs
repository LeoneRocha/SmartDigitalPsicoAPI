using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecurrenceDays",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecurrenceDays",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(58), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(60), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1453), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1455), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1457), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1459), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1473), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1486), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1488), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1524), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(305), new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7691), new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5926), new byte[] { 176, 102, 77, 214, 38, 73, 248, 65, 196, 220, 23, 75, 41, 15, 224, 153, 103, 184, 188, 146, 85, 91, 132, 228, 149, 99, 68, 177, 137, 39, 58, 150, 105, 41, 45, 70, 32, 56, 184, 98, 95, 113, 213, 130, 118, 238, 247, 253, 132, 124, 139, 140, 101, 225, 138, 198, 175, 253, 9, 173, 89, 76, 156, 196 }, new byte[] { 5, 6, 207, 190, 211, 28, 207, 92, 2, 133, 201, 237, 192, 218, 92, 126, 93, 168, 132, 109, 59, 213, 88, 239, 153, 25, 29, 92, 163, 209, 36, 74, 23, 13, 62, 143, 169, 222, 253, 185, 188, 180, 112, 57, 22, 118, 205, 251, 81, 233, 46, 48, 71, 213, 0, 253, 231, 173, 132, 84, 229, 188, 177, 165, 56, 163, 203, 203, 55, 62, 45, 177, 185, 138, 234, 4, 198, 207, 48, 242, 9, 103, 183, 150, 88, 140, 126, 153, 30, 250, 17, 91, 20, 131, 137, 140, 50, 17, 82, 230, 236, 78, 97, 232, 52, 96, 64, 19, 165, 24, 159, 32, 133, 246, 27, 229, 252, 127, 225, 109, 203, 54, 167, 47, 40, 190, 128, 83 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7296), new byte[] { 216, 110, 178, 81, 131, 227, 197, 114, 202, 36, 96, 225, 76, 177, 70, 112, 58, 206, 21, 50, 82, 249, 208, 204, 161, 63, 91, 181, 125, 152, 14, 52, 180, 133, 122, 225, 94, 92, 147, 154, 112, 172, 157, 88, 1, 172, 30, 127, 121, 188, 231, 127, 143, 231, 215, 74, 210, 144, 94, 213, 145, 113, 202, 221 }, new byte[] { 204, 84, 112, 104, 225, 186, 78, 130, 43, 171, 26, 32, 23, 152, 233, 93, 73, 182, 9, 102, 18, 143, 140, 253, 115, 231, 127, 202, 116, 59, 122, 229, 231, 20, 16, 170, 24, 114, 205, 131, 86, 233, 124, 22, 240, 235, 79, 137, 39, 0, 181, 38, 3, 114, 49, 30, 237, 130, 119, 203, 105, 184, 32, 31, 145, 225, 14, 125, 85, 253, 91, 16, 102, 213, 208, 125, 16, 156, 198, 52, 231, 124, 119, 240, 0, 37, 216, 247, 161, 196, 174, 41, 201, 11, 200, 84, 218, 77, 34, 9, 163, 232, 40, 74, 92, 162, 154, 15, 81, 106, 148, 97, 53, 53, 27, 101, 55, 220, 75, 83, 89, 90, 140, 104, 70, 115, 126, 209 } });
        }
    }
}
