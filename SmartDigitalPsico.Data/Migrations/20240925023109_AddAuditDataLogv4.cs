using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Idx_AuditDataEntityLog_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                newName: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1937), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1939), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1942), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1943), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1944), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1946), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1947), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1947), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1951), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1952), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1953), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1959), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1964), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1967), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1967), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1968), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1969), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1971), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1972), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1973), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1977), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1978), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1979), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1981), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1982), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1983), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1983), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1985), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1985), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1988), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1989), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1991), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1994), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1996), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1999), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1999), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2000), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2003), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2004), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2005), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2006), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2006), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2231), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2231), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2522), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2523), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 25, 2, 31, 9, 45, DateTimeKind.Utc).AddTicks(2961), new byte[] { 121, 2, 56, 163, 32, 223, 98, 83, 121, 222, 201, 154, 127, 206, 192, 40, 207, 158, 58, 126, 122, 140, 166, 194, 44, 205, 234, 153, 36, 16, 189, 12, 182, 6, 150, 172, 209, 140, 241, 252, 204, 112, 226, 152, 207, 138, 240, 95, 216, 211, 239, 227, 162, 138, 74, 43, 117, 246, 187, 31, 252, 72, 57, 80 }, new byte[] { 26, 18, 163, 104, 71, 65, 74, 102, 255, 80, 90, 69, 202, 153, 167, 76, 194, 142, 180, 146, 201, 108, 214, 131, 35, 234, 1, 9, 145, 202, 235, 40, 223, 217, 191, 13, 49, 244, 147, 56, 193, 31, 53, 86, 69, 250, 114, 28, 103, 37, 140, 203, 233, 70, 118, 65, 171, 179, 201, 73, 128, 101, 69, 60, 60, 55, 139, 82, 93, 155, 136, 23, 145, 49, 41, 135, 111, 214, 26, 52, 174, 196, 80, 225, 255, 26, 6, 55, 14, 82, 194, 209, 25, 217, 160, 79, 113, 203, 140, 152, 218, 108, 74, 51, 165, 4, 10, 138, 238, 55, 199, 227, 215, 247, 244, 124, 237, 163, 53, 116, 182, 149, 220, 69, 200, 15, 181, 149 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 31, 9, 47, DateTimeKind.Utc).AddTicks(6399), new DateTime(2024, 9, 25, 2, 31, 9, 47, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 9, 25, 2, 31, 9, 47, DateTimeKind.Utc).AddTicks(6401), new byte[] { 202, 189, 124, 194, 48, 83, 126, 30, 197, 190, 227, 115, 230, 165, 11, 60, 254, 138, 185, 35, 141, 85, 208, 39, 207, 24, 126, 91, 241, 6, 52, 4, 90, 137, 156, 126, 118, 212, 77, 30, 99, 170, 220, 131, 249, 46, 61, 236, 150, 240, 80, 177, 138, 102, 181, 32, 236, 158, 113, 27, 194, 220, 107, 250 }, new byte[] { 63, 138, 54, 39, 65, 113, 53, 139, 57, 99, 80, 254, 110, 207, 206, 13, 49, 0, 53, 235, 95, 5, 0, 119, 38, 223, 76, 229, 120, 72, 11, 121, 234, 96, 16, 32, 244, 203, 191, 188, 130, 55, 240, 180, 33, 9, 139, 71, 110, 210, 147, 93, 64, 191, 254, 230, 8, 180, 59, 51, 4, 128, 142, 88, 125, 148, 72, 178, 21, 70, 181, 84, 221, 3, 207, 27, 0, 161, 20, 94, 201, 248, 168, 73, 128, 118, 207, 150, 190, 176, 84, 169, 48, 159, 97, 45, 140, 158, 47, 200, 219, 18, 234, 101, 107, 155, 237, 53, 220, 27, 53, 56, 103, 1, 223, 222, 34, 56, 196, 154, 74, 80, 115, 96, 15, 24, 65, 150 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                newName: "Idx_AuditDataEntityLog_TableName_Operation_Inc_AuditDate_UserAuditedId");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2934), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2940), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2941), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2942), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2944), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2945), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2948), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2949), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2952), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2953), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2954), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2957), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2958), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2959), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2961), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2962), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2968), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2970), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2971), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2972), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2973), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2977), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2978), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2979), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2980), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2981), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2982), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2984), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2985), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2986), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2989), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2993), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2994), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2995), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3001), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3002), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3463), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3782), new byte[] { 41, 88, 55, 66, 191, 229, 116, 203, 255, 126, 97, 109, 164, 188, 81, 133, 238, 80, 147, 119, 123, 49, 107, 91, 123, 114, 156, 119, 130, 200, 67, 78, 89, 108, 244, 201, 200, 136, 177, 89, 65, 212, 253, 149, 74, 125, 152, 210, 97, 87, 7, 50, 166, 25, 222, 231, 125, 136, 112, 233, 247, 197, 185, 114 }, new byte[] { 232, 87, 48, 23, 95, 4, 199, 234, 77, 93, 192, 44, 47, 215, 195, 142, 118, 52, 116, 82, 50, 202, 83, 210, 113, 221, 38, 108, 164, 35, 249, 14, 110, 62, 180, 191, 80, 250, 205, 15, 141, 169, 121, 208, 209, 125, 4, 182, 140, 88, 209, 61, 175, 122, 240, 204, 81, 211, 148, 107, 78, 238, 58, 244, 212, 221, 217, 6, 255, 174, 54, 220, 183, 25, 107, 13, 118, 173, 65, 178, 230, 75, 12, 213, 147, 130, 40, 245, 194, 205, 45, 128, 72, 167, 141, 123, 102, 228, 156, 123, 253, 141, 67, 74, 251, 12, 139, 121, 229, 103, 245, 97, 155, 240, 24, 46, 141, 63, 171, 27, 235, 140, 27, 109, 195, 248, 77, 205 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5413), new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5414), new byte[] { 13, 136, 152, 125, 7, 102, 13, 153, 180, 161, 170, 203, 134, 127, 87, 1, 171, 154, 10, 124, 26, 237, 227, 77, 7, 93, 113, 59, 222, 171, 236, 194, 128, 131, 239, 34, 212, 112, 179, 215, 34, 177, 240, 131, 219, 225, 135, 62, 177, 142, 6, 128, 160, 200, 220, 230, 68, 203, 3, 32, 234, 124, 252, 70 }, new byte[] { 60, 120, 32, 51, 241, 157, 29, 14, 185, 88, 58, 66, 47, 249, 153, 220, 0, 225, 78, 18, 172, 25, 237, 91, 118, 254, 135, 102, 64, 156, 181, 224, 13, 147, 42, 0, 246, 229, 62, 52, 115, 167, 141, 212, 89, 51, 214, 96, 212, 15, 12, 9, 171, 208, 43, 68, 251, 126, 67, 218, 5, 1, 222, 40, 13, 222, 253, 97, 239, 109, 175, 102, 202, 196, 156, 69, 5, 192, 148, 254, 45, 126, 153, 52, 38, 245, 77, 101, 54, 147, 60, 93, 198, 67, 177, 218, 126, 77, 184, 198, 124, 67, 113, 176, 115, 71, 168, 191, 0, 105, 159, 131, 36, 32, 143, 149, 158, 143, 202, 159, 206, 145, 17, 44, 166, 156, 177, 227 } });
        }
    }
}
