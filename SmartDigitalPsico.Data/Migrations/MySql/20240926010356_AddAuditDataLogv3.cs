using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyValues",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "KeyValues",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.AddColumn<string>(
                name: "KeyValue",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<string>(
                name: "KeyValue",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1182), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1204), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1219), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1220), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1222), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1223), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1228), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1229), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1231), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1235), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1245), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1249), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2072), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2073), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2073), new byte[] { 164, 245, 215, 24, 1, 109, 33, 79, 246, 83, 63, 196, 249, 35, 155, 252, 192, 111, 96, 121, 24, 7, 148, 56, 29, 110, 246, 234, 186, 153, 54, 244, 9, 133, 124, 139, 132, 126, 52, 99, 83, 33, 194, 56, 152, 107, 252, 113, 83, 47, 105, 102, 146, 86, 204, 180, 228, 172, 55, 64, 62, 152, 156, 227 }, new byte[] { 22, 242, 254, 149, 229, 53, 136, 34, 47, 37, 153, 203, 151, 95, 192, 22, 6, 19, 121, 235, 240, 231, 71, 159, 122, 173, 53, 184, 161, 213, 16, 8, 8, 15, 95, 78, 231, 164, 186, 184, 216, 181, 96, 64, 221, 157, 224, 143, 8, 182, 122, 204, 138, 32, 106, 134, 237, 3, 110, 244, 148, 8, 217, 145, 172, 79, 20, 45, 91, 207, 207, 184, 29, 97, 0, 96, 0, 33, 240, 113, 236, 27, 252, 74, 72, 60, 93, 165, 120, 88, 255, 208, 191, 202, 48, 95, 147, 222, 252, 31, 85, 233, 42, 16, 247, 240, 247, 252, 44, 214, 38, 151, 228, 255, 49, 54, 49, 113, 91, 152, 251, 97, 66, 64, 139, 199, 252, 39 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3427), new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3427), new byte[] { 148, 207, 224, 4, 83, 206, 219, 43, 9, 112, 228, 134, 121, 28, 41, 25, 171, 241, 91, 84, 90, 189, 5, 228, 75, 69, 25, 198, 26, 146, 188, 174, 165, 20, 18, 59, 76, 246, 36, 86, 68, 188, 83, 160, 142, 8, 184, 8, 186, 228, 14, 193, 220, 19, 167, 52, 141, 248, 152, 238, 211, 18, 181, 113 }, new byte[] { 46, 207, 133, 200, 121, 171, 210, 194, 162, 74, 3, 213, 6, 121, 46, 158, 245, 18, 105, 78, 126, 146, 7, 183, 38, 97, 225, 152, 124, 26, 16, 184, 32, 93, 182, 134, 129, 173, 12, 137, 30, 206, 223, 162, 77, 58, 98, 74, 138, 51, 170, 158, 159, 11, 80, 254, 245, 219, 209, 176, 227, 221, 167, 197, 198, 41, 12, 64, 75, 181, 248, 171, 219, 139, 217, 212, 146, 124, 158, 206, 138, 63, 55, 255, 128, 92, 191, 87, 109, 92, 192, 162, 62, 80, 157, 142, 184, 63, 135, 212, 131, 24, 133, 55, 16, 54, 104, 82, 62, 237, 154, 5, 167, 239, 90, 170, 250, 193, 213, 242, 162, 104, 47, 140, 23, 122, 131, 7 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyValue",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "KeyValue",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.AddColumn<string>(
                name: "KeyValues",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "text",
                maxLength: 4000,
                nullable: false)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<string>(
                name: "KeyValues",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "text",
                maxLength: 4000,
                nullable: false)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3623), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3624), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3625), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3627), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3628), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3630), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3631), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3632), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3638), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3642), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3643), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3644), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3649), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3652), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3662), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3664), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3666), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3669), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3673), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3674), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3678), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3684), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3686), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3688), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3689), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3971), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4172), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4513), new byte[] { 145, 196, 85, 136, 233, 205, 232, 63, 226, 44, 120, 165, 191, 113, 0, 191, 171, 28, 73, 88, 204, 164, 75, 162, 217, 198, 212, 158, 184, 233, 74, 98, 196, 5, 48, 125, 38, 110, 26, 237, 68, 92, 228, 57, 198, 118, 231, 224, 11, 40, 6, 77, 93, 194, 248, 94, 95, 142, 228, 189, 130, 94, 223, 132 }, new byte[] { 0, 27, 97, 201, 83, 204, 108, 95, 19, 111, 221, 214, 10, 81, 68, 140, 50, 184, 41, 78, 254, 34, 203, 246, 184, 128, 234, 151, 137, 141, 207, 136, 6, 86, 251, 230, 232, 29, 158, 97, 57, 213, 143, 91, 129, 15, 246, 169, 209, 103, 184, 224, 142, 51, 209, 11, 57, 26, 184, 202, 221, 93, 21, 95, 154, 116, 222, 48, 255, 132, 193, 211, 205, 254, 53, 14, 191, 232, 167, 246, 149, 105, 24, 223, 214, 215, 72, 211, 214, 95, 139, 205, 90, 57, 151, 246, 222, 133, 125, 145, 128, 184, 143, 107, 189, 97, 134, 174, 10, 191, 251, 83, 57, 105, 59, 214, 59, 233, 66, 191, 200, 120, 222, 150, 67, 6, 154, 254 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6721), new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6723), new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6724), new byte[] { 70, 132, 118, 220, 115, 210, 93, 48, 54, 6, 147, 54, 148, 14, 33, 120, 197, 165, 22, 81, 196, 157, 200, 228, 42, 87, 78, 2, 238, 72, 2, 246, 166, 135, 66, 202, 195, 218, 110, 123, 183, 238, 158, 253, 143, 248, 111, 37, 134, 103, 95, 170, 158, 82, 179, 66, 159, 64, 64, 105, 104, 158, 217, 94 }, new byte[] { 235, 172, 121, 111, 214, 66, 166, 172, 181, 183, 204, 98, 28, 91, 123, 110, 155, 19, 160, 203, 73, 138, 110, 143, 120, 68, 232, 83, 250, 196, 7, 56, 41, 91, 36, 57, 58, 157, 82, 107, 79, 73, 57, 139, 52, 154, 220, 87, 162, 189, 68, 179, 239, 180, 8, 220, 128, 73, 78, 215, 255, 219, 244, 249, 209, 134, 137, 75, 188, 81, 150, 28, 148, 220, 219, 30, 87, 132, 171, 220, 160, 81, 236, 33, 195, 157, 148, 123, 91, 207, 227, 2, 222, 38, 123, 1, 249, 7, 179, 53, 78, 166, 157, 189, 98, 106, 59, 104, 130, 39, 105, 54, 180, 131, 18, 236, 170, 105, 126, 42, 60, 175, 146, 63, 52, 225, 237, 93 } });
        }
    }
}
