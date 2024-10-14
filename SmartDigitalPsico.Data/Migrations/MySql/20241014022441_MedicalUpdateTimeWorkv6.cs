using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RecurrenceType",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1154), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1157), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1158), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1186), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1197), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1217), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1219), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1220), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1222), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1223), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1228), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1229), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1231), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1235), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1113), new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1114), new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1376), new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7894), new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7894), new byte[] { 21, 115, 207, 168, 175, 161, 61, 251, 227, 66, 1, 249, 141, 52, 141, 29, 232, 204, 133, 126, 174, 52, 221, 87, 253, 38, 232, 240, 57, 237, 153, 163, 67, 80, 5, 202, 18, 140, 13, 164, 135, 45, 184, 206, 236, 60, 254, 190, 211, 213, 91, 243, 96, 228, 20, 50, 77, 231, 144, 89, 218, 81, 240, 130 }, new byte[] { 115, 147, 106, 58, 127, 138, 215, 94, 249, 169, 108, 78, 170, 246, 47, 23, 116, 193, 42, 115, 220, 255, 107, 13, 165, 178, 247, 52, 215, 109, 192, 249, 35, 166, 151, 147, 220, 77, 182, 67, 226, 166, 97, 108, 138, 150, 203, 174, 173, 157, 231, 12, 40, 171, 69, 250, 250, 153, 20, 198, 61, 121, 118, 225, 107, 160, 16, 193, 196, 169, 255, 237, 214, 151, 41, 96, 79, 185, 67, 9, 204, 118, 201, 214, 146, 198, 13, 89, 152, 108, 68, 7, 249, 54, 117, 119, 50, 181, 32, 154, 221, 133, 211, 68, 232, 21, 111, 48, 186, 162, 182, 150, 78, 12, 232, 214, 103, 243, 194, 139, 203, 210, 4, 171, 104, 93, 25, 166 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9168), new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9170), new byte[] { 3, 160, 60, 185, 224, 145, 176, 211, 14, 118, 251, 92, 185, 240, 9, 18, 253, 95, 56, 174, 125, 128, 37, 226, 221, 120, 94, 1, 73, 46, 39, 77, 149, 200, 246, 108, 46, 110, 45, 172, 219, 206, 39, 91, 226, 68, 16, 62, 176, 10, 98, 72, 54, 46, 15, 236, 168, 200, 230, 243, 246, 31, 67, 83 }, new byte[] { 245, 52, 94, 44, 185, 154, 1, 150, 77, 206, 151, 233, 6, 61, 58, 12, 110, 142, 159, 132, 253, 165, 14, 13, 119, 106, 177, 9, 9, 251, 4, 247, 41, 14, 187, 57, 211, 169, 113, 52, 70, 148, 123, 143, 153, 243, 6, 44, 169, 214, 19, 205, 132, 140, 57, 188, 209, 122, 156, 67, 8, 133, 120, 211, 167, 97, 255, 184, 211, 255, 125, 92, 138, 111, 143, 229, 112, 14, 174, 236, 77, 178, 199, 121, 143, 171, 58, 145, 0, 221, 213, 180, 25, 90, 235, 209, 1, 92, 192, 91, 144, 246, 82, 114, 219, 65, 120, 250, 3, 99, 175, 214, 229, 97, 140, 165, 107, 16, 245, 252, 227, 38, 232, 159, 127, 188, 16, 186 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RecurrenceType",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6828), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6830), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6837), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6841), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6845), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6850), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6851), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6852), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6854), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6856), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6861), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6863), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6865), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6866), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6870), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6873), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6876), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6877), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6881), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6886), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6894), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6898), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4181), new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4183), new DateTime(2024, 10, 14, 1, 46, 22, 49, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 30, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 10, 14, 1, 46, 22, 37, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 38, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1050), new DateTime(2024, 10, 14, 1, 46, 22, 41, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 10, 14, 1, 46, 22, 43, DateTimeKind.Utc).AddTicks(8338), new byte[] { 100, 42, 113, 180, 210, 168, 7, 110, 30, 104, 202, 207, 20, 46, 68, 67, 99, 83, 182, 234, 248, 225, 153, 17, 85, 16, 2, 180, 60, 253, 114, 160, 131, 86, 217, 46, 121, 109, 64, 168, 93, 133, 24, 110, 236, 156, 42, 226, 249, 16, 227, 70, 44, 114, 38, 82, 205, 6, 171, 124, 175, 65, 167, 86 }, new byte[] { 2, 75, 140, 133, 156, 88, 153, 240, 26, 172, 121, 37, 66, 114, 62, 215, 234, 160, 56, 166, 37, 245, 249, 1, 90, 124, 92, 57, 56, 250, 66, 95, 197, 239, 225, 115, 98, 203, 181, 111, 8, 54, 185, 45, 193, 206, 171, 188, 71, 59, 5, 111, 181, 214, 161, 107, 126, 92, 127, 133, 246, 88, 253, 24, 68, 232, 92, 179, 61, 174, 7, 202, 240, 131, 205, 197, 31, 62, 195, 65, 208, 33, 193, 10, 52, 162, 86, 136, 243, 87, 194, 135, 190, 85, 75, 106, 178, 186, 185, 148, 142, 119, 66, 94, 148, 231, 232, 232, 183, 53, 175, 47, 108, 201, 208, 84, 226, 125, 73, 34, 152, 183, 231, 114, 41, 195, 218, 104 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 10, 14, 1, 46, 22, 46, DateTimeKind.Utc).AddTicks(346), new byte[] { 146, 73, 84, 22, 80, 8, 46, 43, 4, 21, 97, 23, 89, 27, 108, 217, 87, 221, 63, 73, 173, 163, 10, 245, 4, 86, 246, 180, 12, 208, 56, 103, 170, 156, 139, 202, 154, 148, 137, 171, 58, 209, 14, 81, 210, 37, 46, 52, 69, 161, 76, 164, 181, 200, 41, 173, 19, 0, 107, 121, 79, 158, 233, 160 }, new byte[] { 112, 117, 209, 171, 246, 102, 179, 238, 163, 191, 231, 77, 242, 22, 236, 90, 210, 147, 142, 24, 188, 214, 76, 134, 1, 104, 87, 79, 98, 10, 211, 1, 212, 85, 236, 73, 182, 128, 90, 160, 251, 174, 158, 224, 243, 135, 186, 100, 69, 74, 133, 87, 31, 248, 58, 160, 58, 246, 47, 120, 106, 154, 213, 22, 62, 30, 222, 214, 0, 103, 104, 193, 165, 137, 148, 121, 216, 152, 155, 232, 166, 229, 103, 229, 175, 208, 227, 73, 133, 151, 204, 49, 157, 94, 116, 176, 132, 82, 208, 199, 13, 216, 250, 180, 29, 239, 53, 170, 123, 170, 230, 116, 185, 70, 132, 69, 74, 177, 203, 197, 112, 65, 204, 199, 2, 165, 228, 126 } });
        }
    }
}
