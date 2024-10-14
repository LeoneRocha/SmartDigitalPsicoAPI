using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv10 : Migration
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
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8637), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9901), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9913), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9917), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9921), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9923), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9924), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9932), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9933), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9934), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9935), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9941), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9942), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9943), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9975), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9982), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9983), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9984), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9985), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9988), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9542), new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(409), new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6536), new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6537), new byte[] { 172, 58, 117, 34, 187, 226, 164, 3, 28, 237, 70, 46, 231, 107, 213, 125, 22, 162, 135, 111, 39, 227, 233, 220, 216, 87, 125, 92, 170, 72, 178, 187, 198, 105, 107, 0, 228, 178, 175, 17, 147, 163, 131, 112, 104, 58, 220, 147, 16, 210, 182, 192, 137, 206, 77, 2, 4, 39, 86, 135, 47, 75, 135, 246 }, new byte[] { 172, 103, 166, 243, 41, 162, 210, 71, 89, 125, 12, 242, 156, 29, 250, 116, 247, 34, 128, 118, 44, 5, 240, 2, 53, 59, 227, 169, 196, 209, 197, 2, 117, 197, 214, 87, 15, 199, 186, 191, 121, 231, 99, 88, 64, 25, 103, 109, 109, 234, 65, 101, 255, 127, 43, 224, 75, 51, 215, 121, 75, 128, 19, 59, 50, 37, 173, 68, 78, 123, 54, 239, 31, 36, 171, 141, 171, 244, 230, 210, 168, 173, 40, 119, 30, 208, 102, 41, 211, 151, 237, 165, 226, 58, 122, 211, 194, 15, 136, 142, 88, 208, 50, 230, 127, 43, 236, 96, 111, 207, 117, 208, 120, 127, 231, 190, 237, 116, 246, 69, 222, 2, 151, 239, 163, 179, 139, 181 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7644), new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7645), new byte[] { 246, 148, 222, 136, 27, 255, 10, 162, 78, 234, 133, 33, 6, 67, 205, 126, 249, 148, 118, 49, 63, 209, 70, 183, 98, 195, 97, 169, 48, 160, 118, 26, 30, 204, 174, 157, 168, 211, 54, 214, 56, 145, 143, 56, 125, 220, 248, 247, 132, 73, 68, 109, 31, 100, 248, 166, 8, 217, 232, 84, 99, 203, 68, 34 }, new byte[] { 234, 128, 108, 217, 248, 137, 209, 244, 105, 123, 21, 218, 112, 255, 10, 173, 24, 146, 182, 247, 11, 234, 44, 214, 93, 181, 204, 115, 240, 45, 198, 51, 118, 70, 125, 16, 97, 157, 150, 240, 152, 45, 35, 53, 186, 240, 53, 0, 175, 87, 70, 160, 238, 169, 197, 92, 23, 13, 243, 27, 145, 179, 71, 145, 210, 166, 113, 171, 217, 193, 26, 33, 99, 170, 16, 96, 74, 117, 19, 192, 165, 25, 133, 187, 93, 190, 176, 201, 4, 220, 233, 32, 64, 171, 112, 181, 176, 2, 236, 210, 26, 251, 70, 7, 149, 223, 19, 44, 143, 181, 151, 241, 122, 143, 206, 131, 32, 121, 229, 239, 10, 92, 162, 49, 67, 205, 128, 188 } });
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
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 10, 14, 2, 43, 8, 323, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(957), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(988), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(990), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(995), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(882), new DateTime(2024, 10, 14, 2, 43, 8, 345, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 324, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8993), new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 10, 14, 2, 43, 8, 331, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 332, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9472), new DateTime(2024, 10, 14, 2, 43, 8, 335, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 43, 8, 338, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 10, 14, 2, 43, 8, 339, DateTimeKind.Utc).AddTicks(1765), new byte[] { 149, 89, 225, 167, 74, 183, 225, 174, 101, 42, 43, 239, 83, 104, 142, 181, 187, 152, 20, 11, 37, 118, 239, 91, 33, 123, 126, 183, 106, 13, 169, 175, 153, 101, 141, 213, 158, 70, 183, 217, 72, 206, 228, 114, 186, 85, 90, 156, 60, 148, 119, 145, 132, 206, 29, 85, 191, 52, 182, 36, 240, 78, 151, 127 }, new byte[] { 179, 169, 80, 111, 194, 103, 208, 155, 20, 13, 255, 90, 48, 216, 220, 78, 69, 162, 95, 182, 8, 141, 90, 116, 100, 187, 8, 189, 214, 40, 176, 54, 41, 123, 51, 196, 192, 248, 203, 12, 207, 188, 30, 130, 173, 118, 195, 240, 101, 162, 41, 231, 236, 22, 115, 42, 233, 33, 151, 87, 171, 66, 53, 3, 116, 69, 71, 171, 152, 130, 71, 173, 1, 234, 253, 23, 91, 98, 245, 150, 1, 118, 196, 95, 193, 215, 94, 184, 96, 17, 204, 223, 32, 145, 1, 141, 219, 42, 183, 21, 129, 202, 228, 225, 89, 50, 157, 62, 98, 153, 55, 82, 3, 148, 11, 235, 77, 166, 153, 71, 105, 149, 189, 113, 79, 173, 168, 161 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4910), new DateTime(2024, 10, 14, 2, 43, 8, 341, DateTimeKind.Utc).AddTicks(4911), new byte[] { 141, 146, 242, 37, 130, 252, 22, 199, 151, 176, 249, 106, 45, 144, 246, 191, 190, 6, 126, 165, 22, 245, 90, 12, 229, 44, 1, 236, 170, 202, 69, 52, 243, 245, 56, 69, 56, 46, 211, 234, 177, 156, 12, 239, 25, 131, 85, 207, 133, 221, 177, 165, 41, 73, 132, 53, 255, 188, 68, 93, 41, 119, 97, 103 }, new byte[] { 50, 144, 221, 215, 106, 167, 15, 159, 155, 47, 198, 73, 134, 217, 92, 172, 19, 140, 165, 180, 12, 17, 122, 16, 2, 30, 110, 204, 66, 231, 139, 38, 0, 183, 57, 15, 102, 112, 216, 117, 111, 247, 49, 97, 148, 126, 94, 147, 169, 128, 46, 235, 103, 82, 236, 222, 6, 210, 25, 77, 63, 60, 156, 153, 44, 229, 78, 152, 237, 99, 115, 46, 190, 244, 99, 201, 151, 175, 165, 236, 169, 83, 32, 127, 49, 123, 224, 179, 214, 64, 8, 19, 24, 154, 113, 252, 6, 136, 193, 251, 180, 28, 60, 150, 220, 242, 113, 132, 206, 212, 24, 69, 112, 128, 95, 91, 187, 66, 61, 127, 211, 56, 205, 180, 231, 99, 86, 63 } });
        }
    }
}
