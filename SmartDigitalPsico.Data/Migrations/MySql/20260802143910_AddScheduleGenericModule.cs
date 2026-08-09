using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por AddScheduleGenericModule.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class AddScheduleGenericModule : Migration
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
                    OwnerKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TimeZoneDefault = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ScheduleSeries",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CalendarId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "text", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    OwnerKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    SubjectKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    RecurrenceDays = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    RecurrenceCount = table.Column<short>(type: "smallint", nullable: true),
                    StartPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleSeries_ScheduleCalendar_CalendarId",
                        column: x => x.CalendarId,
                        principalSchema: "dbo",
                        principalTable: "ScheduleCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "ScheduleOccurrence",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CalendarId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: true),
                    SeriesToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    OwnerKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    SubjectKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "text", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsAllDay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ColorCategoryHexa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TimeZone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsException = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExternalId = table.Column<long>(type: "bigint", nullable: true),
                    ExternalSource = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleOccurrence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleOccurrence_ScheduleCalendar_CalendarId",
                        column: x => x.CalendarId,
                        principalSchema: "dbo",
                        principalTable: "ScheduleCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleOccurrence_ScheduleSeries_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "dbo",
                        principalTable: "ScheduleSeries",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCalendar_Tenant_Owner",
                schema: "dbo",
                table: "ScheduleCalendar",
                columns: new[] { "TenantKey", "OwnerKey" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOccurrence_Calendar_Start_End",
                schema: "dbo",
                table: "ScheduleOccurrence",
                columns: new[] { "CalendarId", "StartDateTime", "EndDateTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOccurrence_External",
                schema: "dbo",
                table: "ScheduleOccurrence",
                columns: new[] { "ExternalSource", "ExternalId" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOccurrence_Owner_Start",
                schema: "dbo",
                table: "ScheduleOccurrence",
                columns: new[] { "OwnerKey", "StartDateTime" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOccurrence_SeriesId",
                schema: "dbo",
                table: "ScheduleOccurrence",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOccurrence_SeriesToken",
                schema: "dbo",
                table: "ScheduleOccurrence",
                column: "SeriesToken");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleSeries_CalendarId",
                schema: "dbo",
                table: "ScheduleSeries",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "UX_ScheduleSeries_SeriesToken",
                schema: "dbo",
                table: "ScheduleSeries",
                column: "SeriesToken",
                unique: true);
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleOccurrence",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ScheduleSeries",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ScheduleCalendar",
                schema: "dbo");
        }
    }
}
