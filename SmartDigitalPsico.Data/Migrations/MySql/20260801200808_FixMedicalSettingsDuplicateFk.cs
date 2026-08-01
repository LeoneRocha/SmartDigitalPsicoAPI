using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class FixMedicalSettingsDuplicateFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSettings_Medical_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");

            migrationBuilder.DropIndex(
                name: "IX_MedicalSettings_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");

            migrationBuilder.DropColumn(
                name: "MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSettings_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSettings_Medical_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId1",
                principalSchema: "dbo",
                principalTable: "Medical",
                principalColumn: "Id");
        }
    }
}
