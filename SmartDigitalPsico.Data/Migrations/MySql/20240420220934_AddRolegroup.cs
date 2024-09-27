using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRolegroup : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6261), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6481), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6483), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6484), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6497), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6504), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6508), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6511), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6518), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6520), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6521), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6522), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6524), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6525), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6527), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6528), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6529), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6530), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6532), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6533), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6534), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6536), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6537), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6538), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6539), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6540), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6541), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6542), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6543), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6544), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6545), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6577), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6578), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6581), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6582), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6583), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6584), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6585), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6586), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7340), new byte[] { 91, 49, 58, 113, 111, 72, 106, 128, 245, 123, 210, 104, 16, 253, 147, 0, 206, 108, 236, 150, 11, 163, 208, 19, 242, 44, 217, 139, 163, 25, 36, 107, 238, 172, 146, 2, 145, 73, 77, 49, 74, 1, 0, 130, 22, 129, 43, 156, 190, 212, 212, 202, 14, 16, 239, 150, 72, 231, 6, 132, 67, 255, 206, 148 }, new byte[] { 224, 143, 128, 247, 194, 230, 89, 121, 202, 119, 55, 231, 81, 46, 240, 155, 152, 74, 168, 32, 37, 143, 100, 240, 229, 30, 232, 52, 246, 111, 228, 47, 34, 198, 117, 159, 86, 165, 243, 46, 147, 250, 169, 235, 84, 221, 231, 181, 227, 61, 8, 238, 61, 9, 90, 137, 148, 51, 9, 234, 202, 237, 117, 55, 220, 221, 139, 77, 135, 71, 89, 38, 50, 38, 225, 90, 59, 207, 116, 155, 194, 105, 246, 241, 109, 121, 202, 193, 57, 147, 100, 138, 75, 58, 16, 33, 146, 0, 83, 138, 43, 71, 226, 82, 245, 233, 249, 25, 11, 246, 167, 163, 104, 201, 202, 30, 175, 219, 237, 235, 26, 222, 107, 203, 37, 148, 55, 35 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8357), new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8358), new byte[] { 104, 94, 194, 218, 182, 175, 36, 59, 99, 247, 229, 170, 92, 250, 218, 138, 87, 119, 133, 163, 87, 49, 195, 19, 152, 184, 181, 251, 50, 124, 186, 182, 186, 138, 54, 85, 13, 138, 196, 39, 63, 67, 204, 212, 52, 161, 59, 162, 218, 216, 169, 249, 30, 89, 122, 24, 4, 170, 206, 156, 6, 127, 0, 20 }, new byte[] { 54, 46, 182, 3, 211, 120, 69, 73, 183, 122, 158, 27, 222, 13, 33, 44, 27, 159, 239, 19, 6, 145, 189, 171, 221, 53, 110, 0, 207, 159, 13, 245, 93, 252, 142, 72, 74, 75, 87, 160, 253, 234, 85, 135, 189, 117, 234, 79, 99, 36, 111, 174, 31, 245, 94, 228, 108, 201, 146, 187, 103, 111, 71, 203, 169, 173, 135, 17, 102, 188, 255, 18, 78, 214, 116, 98, 245, 66, 188, 127, 221, 191, 18, 91, 196, 109, 130, 145, 235, 119, 251, 177, 177, 15, 223, 241, 189, 218, 58, 1, 225, 78, 118, 113, 71, 107, 42, 47, 175, 244, 125, 238, 115, 154, 243, 112, 30, 99, 77, 61, 134, 211, 141, 194, 56, 197, 124, 48 } });
        }
    }
}
