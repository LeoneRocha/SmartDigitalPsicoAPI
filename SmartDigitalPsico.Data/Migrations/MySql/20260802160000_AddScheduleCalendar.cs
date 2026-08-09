using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por AddScheduleCalendar.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class AddScheduleCalendar : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleCalendar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TenantKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    OwnerKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    SubjectKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    UniqueToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ScheduleData = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleCalendar", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCalendar_Tenant_Owner_Period",
                schema: "dbo",
                table: "ScheduleCalendar",
                columns: new[] { "TenantKey", "OwnerKey", "StartPeriod", "EndPeriod" });

            migrationBuilder.CreateIndex(
                name: "UX_ScheduleCalendar_UniqueToken",
                schema: "dbo",
                table: "ScheduleCalendar",
                column: "UniqueToken",
                unique: true);
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleCalendar",
                schema: "dbo");
        }
    }
}
