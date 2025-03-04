using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecordsAdjustTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 857, DateTimeKind.Utc).AddTicks(9645), new DateTime(2025, 3, 4, 17, 25, 1, 857, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 3, 4, 17, 25, 1, 857, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4929), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4930), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4932), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4933), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4934), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4935), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4936), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4937), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4938), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4938), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4940), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4940), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4941), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4943), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4944), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4944) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4946), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4947), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4948), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4949), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4949), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4950), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4951), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4952), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4953), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4954), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4955), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4957), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4981), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4982), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4983), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4985), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4991), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4992), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4993), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4995), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4996), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4999), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4999), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5000), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5001), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5002), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5003), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5005), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5006), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5007), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5010), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5010), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5011), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5012), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5013), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5015), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5016), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5017), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5018), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5019), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5019), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5020), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5021), new DateTime(2025, 3, 4, 17, 25, 1, 858, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 859, DateTimeKind.Utc).AddTicks(5774), new DateTime(2025, 3, 4, 17, 25, 1, 859, DateTimeKind.Utc).AddTicks(5776), new DateTime(2025, 3, 4, 17, 25, 1, 859, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 859, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 859, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 862, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 869, DateTimeKind.Utc).AddTicks(1965), new DateTime(2025, 3, 4, 17, 25, 1, 869, DateTimeKind.Utc).AddTicks(1966), new DateTime(2025, 3, 4, 17, 25, 1, 869, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8803), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8805), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8808), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8809), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8811), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8811), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8813), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8814), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8815), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8816), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8818), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8818), new DateTime(2025, 3, 4, 17, 25, 1, 876, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 877, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 877, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 877, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 880, DateTimeKind.Utc).AddTicks(3743), new DateTime(2025, 3, 4, 17, 25, 1, 880, DateTimeKind.Utc).AddTicks(3744), new DateTime(2025, 3, 4, 17, 25, 1, 880, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 883, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(5987), new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(5988), new DateTime(2025, 3, 4, 17, 25, 1, 884, DateTimeKind.Utc).AddTicks(5989), new byte[] { 216, 63, 107, 56, 205, 220, 145, 189, 181, 205, 238, 171, 31, 235, 62, 115, 27, 51, 90, 223, 221, 177, 65, 11, 216, 148, 180, 59, 160, 142, 240, 219, 156, 110, 177, 100, 146, 67, 95, 235, 155, 58, 29, 97, 218, 139, 58, 35, 174, 47, 151, 172, 110, 105, 213, 54, 214, 148, 212, 177, 222, 174, 92, 239 }, new byte[] { 216, 253, 27, 56, 200, 28, 4, 25, 116, 176, 163, 100, 81, 99, 54, 26, 18, 32, 59, 175, 155, 188, 231, 211, 15, 3, 202, 138, 197, 148, 124, 75, 165, 122, 142, 177, 24, 158, 127, 162, 55, 173, 47, 65, 178, 57, 182, 60, 217, 254, 190, 237, 142, 226, 46, 108, 243, 27, 75, 62, 147, 186, 30, 73, 167, 47, 255, 200, 247, 79, 62, 250, 106, 98, 99, 221, 213, 72, 2, 208, 41, 189, 128, 212, 252, 150, 61, 183, 59, 105, 94, 167, 194, 61, 214, 120, 118, 194, 101, 217, 68, 211, 218, 171, 96, 168, 213, 77, 104, 244, 231, 117, 222, 241, 170, 227, 127, 208, 199, 31, 150, 140, 115, 101, 206, 242, 225, 38 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 25, 1, 886, DateTimeKind.Utc).AddTicks(7988), new DateTime(2025, 3, 4, 17, 25, 1, 886, DateTimeKind.Utc).AddTicks(7989), new DateTime(2025, 3, 4, 17, 25, 1, 886, DateTimeKind.Utc).AddTicks(7990), new byte[] { 129, 165, 171, 210, 246, 150, 189, 201, 27, 34, 71, 162, 94, 219, 194, 197, 9, 69, 236, 126, 67, 112, 19, 230, 253, 115, 65, 37, 221, 166, 240, 232, 20, 132, 229, 16, 86, 194, 17, 40, 100, 97, 250, 103, 39, 207, 134, 16, 60, 89, 50, 148, 51, 111, 102, 152, 180, 16, 235, 253, 235, 172, 128, 202 }, new byte[] { 211, 124, 60, 223, 224, 61, 115, 45, 229, 12, 164, 35, 186, 15, 246, 164, 135, 216, 149, 90, 19, 247, 224, 98, 233, 218, 30, 15, 34, 17, 194, 179, 89, 198, 142, 52, 125, 128, 245, 198, 68, 27, 226, 105, 244, 63, 184, 73, 83, 146, 106, 234, 210, 249, 171, 172, 251, 126, 82, 183, 158, 165, 239, 221, 224, 140, 215, 188, 190, 48, 44, 19, 228, 180, 185, 179, 83, 153, 53, 76, 218, 181, 89, 171, 233, 166, 125, 239, 25, 7, 230, 205, 25, 138, 51, 43, 76, 35, 71, 49, 89, 70, 229, 161, 8, 12, 150, 115, 18, 184, 26, 126, 1, 24, 184, 122, 189, 150, 83, 152, 46, 56, 56, 166, 42, 130, 132, 219 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2913), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8216), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8222), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8223), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8224), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8225), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8226), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8227), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8231), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8232), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8233), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8234), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8235), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8236), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8237), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8240), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8251), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8255), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8260), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8263), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8267), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8273), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8277), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8278), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8280), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8800), new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8801), new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 175, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 175, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1425), new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5912), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5915), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5921), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5945), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9595), new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9596), new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9718), new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9719), new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9719), new byte[] { 31, 217, 93, 145, 252, 55, 227, 212, 66, 220, 214, 194, 251, 248, 57, 247, 130, 83, 64, 86, 242, 221, 110, 125, 125, 210, 88, 153, 202, 43, 121, 129, 248, 37, 126, 56, 20, 238, 161, 186, 148, 14, 233, 225, 246, 46, 40, 148, 9, 1, 38, 99, 88, 111, 188, 145, 223, 210, 232, 73, 199, 157, 28, 204 }, new byte[] { 37, 202, 62, 221, 88, 236, 15, 31, 77, 204, 41, 231, 242, 122, 165, 98, 136, 74, 74, 173, 159, 192, 118, 108, 141, 143, 105, 68, 27, 77, 187, 11, 182, 220, 244, 209, 136, 36, 183, 88, 240, 207, 195, 153, 112, 217, 201, 68, 67, 125, 227, 111, 255, 60, 48, 253, 114, 46, 107, 40, 51, 134, 84, 191, 5, 43, 108, 70, 9, 148, 118, 20, 35, 55, 143, 0, 138, 187, 30, 223, 3, 168, 118, 252, 238, 55, 149, 68, 72, 56, 196, 102, 205, 0, 83, 197, 142, 94, 143, 116, 72, 225, 243, 245, 181, 202, 19, 125, 223, 204, 28, 207, 42, 174, 130, 75, 158, 29, 211, 15, 33, 20, 44, 198, 22, 5, 214, 207 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(660), new byte[] { 216, 242, 12, 204, 194, 121, 138, 74, 66, 201, 190, 2, 166, 244, 104, 171, 111, 49, 104, 154, 164, 110, 158, 232, 158, 109, 126, 157, 99, 53, 138, 82, 249, 47, 39, 8, 173, 219, 154, 47, 105, 7, 134, 34, 81, 228, 238, 182, 106, 0, 179, 166, 225, 65, 166, 136, 85, 103, 153, 234, 95, 158, 241, 219 }, new byte[] { 132, 39, 84, 104, 248, 141, 218, 27, 67, 122, 50, 220, 217, 65, 6, 233, 202, 184, 0, 209, 130, 207, 86, 235, 142, 215, 170, 48, 243, 89, 228, 165, 95, 206, 27, 123, 110, 233, 185, 69, 86, 14, 30, 109, 13, 190, 60, 228, 208, 80, 229, 252, 246, 83, 222, 13, 58, 251, 30, 155, 247, 158, 10, 12, 148, 27, 153, 222, 44, 243, 208, 17, 143, 81, 112, 71, 7, 111, 118, 83, 169, 34, 163, 135, 240, 159, 73, 184, 253, 254, 42, 219, 41, 182, 246, 130, 37, 151, 162, 189, 164, 3, 26, 142, 168, 85, 37, 95, 174, 218, 100, 23, 11, 153, 85, 75, 202, 218, 88, 30, 5, 15, 57, 48, 75, 117, 81, 194 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
