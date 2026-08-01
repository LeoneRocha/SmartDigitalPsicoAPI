using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class InitialCreateMySql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ApplicationCacheLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateTimeSlidingExpiration = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CacheId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CacheKey = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationCacheLog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "ApplicationConfigSetting",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    EndPointUrl_StorageFiles = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    EndPointUrl_Cache = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TypeLocationSaveFiles = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    TypeLocationCache = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    TypeLocationQueeMessaging = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    UrlRootManager = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationConfigSetting", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "ApplicationLanguage",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Language = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    LanguageKey = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    ResourceKey = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    LanguageValue = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLanguage", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "NotificationTemplate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Subject = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Body = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TagApi = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    NotificationTemplateType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTemplate", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Office",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "RoleGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RolePolicyClaimCode = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroup", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Specialty",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialty", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "AuditDataEntityLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TableName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Operation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    KeyValue = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    OldValues = table.Column<string>(type: "text", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    NewValues = table.Column<string>(type: "text", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AuditDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserAuditedLogin = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    UserAuditedId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDataEntityLog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "AuditDataSelectiveEntityLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RowKey = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    PartitionKey = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TableName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Operation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    KeyValue = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    OldValues = table.Column<string>(type: "text", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    NewValues = table.Column<string>(type: "text", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AuditDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserAuditedLogin = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    UserAuditedId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDataSelectiveEntityLog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "InfoTag",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Tag = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoTag", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Leaves",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsRecurring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Medical",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Accreditation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TypeAccreditation = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SecurityKey = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartWorkingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndWorkingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkingDays = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PatientIntervalTimeMinutes = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    OfficeId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medical_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "dbo",
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "MedicalSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    GoogleCalendarId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    GoogleAccessToken = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    GoogleRefreshToken = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    GoogleTokenExpiry = table.Column<DateTime>(type: "datetime", nullable: false),
                    MedicalId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalSettings_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalSettings_Medical_MedicalId1",
                        column: x => x.MedicalId1,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "MedicalSpecialty",
                schema: "dbo",
                columns: table => new
                {
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    SpecialtyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecialty", x => new { x.MedicalId, x.SpecialtyId });
                    table.ForeignKey(
                        name: "FK_MedicalSpecialty_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalSpecialty_Specialty_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalSchema: "dbo",
                        principalTable: "Specialty",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "NotificationRules",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    IsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IntervalType = table.Column<short>(type: "smallint", nullable: false),
                    IntervalValue = table.Column<short>(type: "smallint", nullable: false),
                    IsBefore = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ENotificationServiceType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    NotificationType = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationRules_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Login = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PasswordHash = table.Column<byte[]>(type: "longblob", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "longblob", nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Admin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TimeZone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RefreshToken = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Refresh_token_expiry_time = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "MedicalFile",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileData = table.Column<byte[]>(type: "longblob", nullable: false),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    FileCloudContainer = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileBlobName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalFile_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalFile_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalFile_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Profession = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Cpf = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Rg = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Education = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    MaritalStatus = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AddressStreet = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AddressNeighborhood = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AddressCity = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AddressState = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AddressCep = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    EmergencyContactName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    EmergencyContactPhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    GenderId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Gender_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "dbo",
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "RoleGroupUser",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleGroupId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroupUser", x => new { x.UserId, x.RoleGroupId });
                    table.ForeignKey(
                        name: "FK_RoleGroupUser_RoleGroup_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalSchema: "dbo",
                        principalTable: "RoleGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleGroupUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "UserTokenSession",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessToken = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RefreshToken = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Refresh_token_expiry_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokenSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokenSession_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "MedicalCalendar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAllDay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ColorCategoryHexa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsPushedCalendar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TimeZone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "text", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceDays = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    RecurrenceEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    RecurrenceCount = table.Column<short>(type: "smallint", nullable: true),
                    TokenRecurrence = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    ReasonCancellation = table.Column<string>(type: "text", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCalendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientAdditionalInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FollowUp_Psychiatric = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FollowUp_Neurological = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAdditionalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInformation_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInformation_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientAdditionalInformation_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientFile",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileData = table.Column<byte[]>(type: "longblob", nullable: false),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    FileCloudContainer = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileBlobName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientFile_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientFile_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientFile_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientHospitalizationInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CID = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Observation = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientHospitalizationInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientHospitalizationInformation_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientHospitalizationInformation_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientHospitalizationInformation_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientInfoTag",
                schema: "dbo",
                columns: table => new
                {
                    InfoTagId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfoTag", x => new { x.InfoTagId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_PatientInfoTag_InfoTag_InfoTagId",
                        column: x => x.InfoTagId,
                        principalSchema: "dbo",
                        principalTable: "InfoTag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientInfoTag_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientMedicationInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Dosage = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Posology = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    MainDrug = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicationInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientMedicationInformation_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicationInformation_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientMedicationInformation_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientNotificationMessage",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MessagePatient = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsReaded = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReadingDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Notified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNotificationMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientNotificationMessage_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientNotificationMessage_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientNotificationMessage_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Annotation = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AnnotationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    TableStorageRowKey = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "ScheduleBatch",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    ScheduleData = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    UniqueToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "NotificationRecords",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalCalendarId = table.Column<long>(type: "bigint", nullable: true),
                    NextScheduledSendTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NotificationRules = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FinalSendDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    // Sem FK no banco: MySQL bloqueia TRUNCATE em MedicalCalendar se houver FK
                    // (erro 1701). Relação mantida no modelo via ClientCascade.
                    table.PrimaryKey("PK_NotificationRecords", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "EndPointUrl_Cache", "EndPointUrl_StorageFiles", "Language", "LastAccessDate", "ModifyDate", "TypeLocationCache", "TypeLocationQueeMessaging", "TypeLocationSaveFiles", "UrlRootManager" },
                values: new object[] { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 130, DateTimeKind.Utc).AddTicks(9879), "Default", true, "", "", "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 131, DateTimeKind.Utc).AddTicks(138), new DateTime(2026, 8, 1, 16, 3, 2, 131, DateTimeKind.Utc).AddTicks(30), (byte)1, (byte)0, (byte)0, "" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(673), "Registro atualizado", true, "pt-BR", "RegisterUpdated", "Registro atualizado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(680), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(679), "SharedResource" },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(687), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(688), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(688), "ApplicationLanguage" },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(689), "Registro encontrado", true, "pt-BR", "RegisterIsFound", "Registro encontrado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(690), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(689), "SharedResource" },
                    { 4L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(691), "Registro não encontrado", true, "pt-BR", "RegisterIsNotFound", "Registro não encontrado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(691), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(691), "SharedResource" },
                    { 5L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(693), "Registro existe", true, "pt-BR", "RegisterExist", "Registro existe", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(693), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(693), "SharedResource" },
                    { 6L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(694), "Registro deletado", true, "pt-BR", "RegisterDeleted", "Registro deletado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(695), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(695), "SharedResource" },
                    { 7L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(696), "Registro localizado", true, "pt-BR", "RegisterFind", "Registro localizado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(696), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(696), "SharedResource" },
                    { 8L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(698), "Registros contabilizados", true, "pt-BR", "RegisterCounted", "Registros contabilizados", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(698), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(698), "SharedResource" },
                    { 9L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(699), "Registro criado", true, "pt-BR", "RegisterCreated", "Registro criado", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(700), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(700), "SharedResource" },
                    { 10L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(701), "A descrição não pode ser vazia", true, "pt-BR", "ErrorValidator_Description_Null", "A descrição não pode ser vazia", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(701), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(701), "SharedResource" },
                    { 11L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(703), "O idoma não pode ser vazio", true, "pt-BR", "ErrorValidator_Language_Null", "O idoma não pode ser vazio", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(703), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(703), "SharedResource" },
                    { 12L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(717), "O idoma não pode ultrapassar {MaxLength}", true, "pt-BR", "ErrorValidator_Language_MaximumLength", "O idoma não pode ultrapassar {MaxLength}", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(718), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(717), "SharedResource" },
                    { 13L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(720), "Válido", true, "pt-BR", "LangValid", "Válido", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(721), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(720), "SharedResource" },
                    { 14L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(722), "Ocorreram erros!", true, "pt-BR", "LangErrors", "Ocorreram erros!", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(722), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(722), "SharedResource" },
                    { 15L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(723), "O medico deve ser informado.", true, "pt-BR", "ErrorValidator_MedicalId_Null", "O medico deve ser informado.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(724), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(724), "SharedResource" },
                    { 16L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(725), "O medico informado não existe.", true, "pt-BR", "ErrorValidator_MedicalId_NotFound", "O medico informado não existe.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(726), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(725), "SharedResource" },
                    { 17L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(727), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_Medical_Changed", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(727), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(727), "SharedResource" },
                    { 18L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(728), "O nome não pode ser vazio", true, "pt-BR", "ErrorValidator_Name_Null", "O nome não pode ser vazio", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(729), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(729), "SharedResource" },
                    { 19L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(730), "O Login não pode ser vazio.", true, "pt-BR", "ErrorValidator_Login_Null", "O Login não pode ser vazio.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(731), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(730), "SharedResource" },
                    { 20L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(732), "Login deve ser unico.", true, "pt-BR", "ErrorValidator_Login_Unique", "Login deve ser unico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(732), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(732), "SharedResource" },
                    { 21L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(733), "O Email não pode ser vazio", true, "pt-BR", "ErrorValidator_Email_Null", "O Email não pode ser vazio", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(734), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(734), "SharedResource" },
                    { 22L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(735), "O Email é invalido.", true, "pt-BR", "ErrorValidator_Email_Invalid", "O Email é invalido.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(736), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(735), "SharedResource" },
                    { 23L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(745), "O Email deve ser unico.", true, "pt-BR", "ErrorValidator_Email_Unique", "O Email deve ser unico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(747), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(746), "SharedResource" },
                    { 24L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(765), "O Credenciamento não pode ser vazio.", true, "pt-BR", "ErrorValidator_Accreditation_Null", "O Credenciamento não pode ser vazio.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(766), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(765), "SharedResource" },
                    { 25L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(767), "O Credenciamento deve ser unico.", true, "pt-BR", "ErrorValidator_Accreditation_Unique", "O Credenciamento deve ser unico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(768), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(768), "SharedResource" },
                    { 26L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(769), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalCreated_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(770), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(769), "SharedResource" },
                    { 27L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(771), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalModify_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(771), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(771), "SharedResource" },
                    { 28L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(772), "O Paciente deve ser informado.", true, "pt-BR", "ErrorValidator_Patient_Null", "O Paciente deve ser informado.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(773), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(773), "SharedResource" },
                    { 29L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(774), "O Paciente informado não existe.", true, "pt-BR", "ErrorValidator_Patient_NotFound", "O Paciente informado não existe.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(775), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(774), "SharedResource" },
                    { 30L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(776), "O Paciente não pode ser alterado.", true, "pt-BR", "ErrorValidator_Patient_Changed", "O Paciente não pode ser alterado.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(777), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(776), "SharedResource" },
                    { 31L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(778), "Informações do paciente não podem ser adicionadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Created", "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(778), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(778), "SharedResource" },
                    { 32L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(779), "Informações do paciente não podem ser modificadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Modify", "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(780), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(780), "SharedResource" },
                    { 33L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(781), "O Usuário que está criando deve ser informado.", true, "pt-BR", "ErrorValidator_CreatedUserId_Null", "O Usuário que está criando deve ser informado.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(782), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(781), "SharedResource" },
                    { 34L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(783), "A anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_Annotation_Null", "A anotação não pode ser vazia.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(783), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(783), "SharedResource" },
                    { 35L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(784), "A data da anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_AnnotationDate_Null", "A data da anotação não pode ser vazia.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(785), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(785), "SharedResource" },
                    { 36L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(786), "Data de nascimento invalido", true, "pt-BR", "ErrorValidator_DateOfBirth_Invalid", "Data de nascimento invalido", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(787), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(786), "SharedResource" },
                    { 37L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(788), "O Rg não pode ser vazio.", true, "pt-BR", "ErrorValidator_RG_Null", "O Rg não pode ser vazio.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(788), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(788), "SharedResource" },
                    { 38L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(789), "O CPF não pode ser vazio.", true, "pt-BR", "ErrorValidator_CPF_Null", "O CPF não pode ser vazio.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(790), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(790), "SharedResource" },
                    { 39L, new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(791), "Ocorreu erro no processo.", true, "pt-BR", "GenericErroMessage", "Ocorreu erro no processo.", new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(791), new DateTime(2026, 8, 1, 16, 3, 2, 138, DateTimeKind.Utc).AddTicks(791), "SharedResource" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 149, DateTimeKind.Utc).AddTicks(9191), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 149, DateTimeKind.Utc).AddTicks(9531), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Leaves",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "EndDate", "IsRecurring", "Language", "LastAccessDate", "MedicalId", "ModifyDate", "StartDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(4294), "Ano Novo", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5052), "Carnaval", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5054), "Sexta-feira Santa", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5055), "Tiradentes", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5057), "Dia do Trabalho", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5064), "Corpus Christi", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5065), "Independência do Brasil", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5078), "Nossa Senhora Aparecida", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5079), "Finados", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5081), "Proclamação da República", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11L, new DateTime(2026, 8, 1, 16, 3, 2, 159, DateTimeKind.Utc).AddTicks(5082), "Natal", true, null, true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Id", "Body", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "NotificationTemplateType", "Subject", "TagApi" },
                values: new object[,]
                {
                    { 1L, "<p>Seu acesso foi concedido com sucesso.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8084), "Liberar Login", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8086), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8086), (byte)0, "Acesso Concedido", "LoginReleaseEmail" },
                    { 2L, "<p>Seus dados da conta foram atualizados com sucesso.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8171), "Alteração de Conta Concluída", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8174), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8174), (byte)0, "Dados da Conta Atualizados", "AccountChangeSuccess" },
                    { 3L, "<p>Sua consulta foi agendada com sucesso.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8183), "Consulta Agendada", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8183), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8183), (byte)0, "Sua Consulta Foi Agendada", "AppointmentScheduledSuccess" },
                    { 4L, "<p>Sua consulta foi remarcada com sucesso.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8184), "Consulta Remarcada", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8185), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8185), (byte)0, "Sua Consulta Foi Remarcada", "AppointmentRescheduled" },
                    { 5L, "<p>Sua consulta foi cancelada.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8186), "Consulta Cancelada", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8187), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8187), (byte)0, "Sua Consulta Foi Cancelada", "AppointmentCancelled" },
                    { 6L, "<p>Seus dados médicos foram atualizados com sucesso.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8188), "Atualização de Cadastro Médico", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8189), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8188), (byte)0, "Dados Médicos Atualizados", "MedicalUpdateEmail" },
                    { 7L, "<p>Este é um lembrete para sua consulta agendada.</p>", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8190), "Lembrete de Consulta", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8190), new DateTime(2026, 8, 1, 16, 3, 2, 190, DateTimeKind.Utc).AddTicks(8190), (byte)0, "Lembrete de Consulta Agendada", "AppointmentReminder" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 192, DateTimeKind.Utc).AddTicks(6051), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 192, DateTimeKind.Utc).AddTicks(6502), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 192, DateTimeKind.Utc).AddTicks(6503), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3203), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3206), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3207), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3208), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3209), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(2026, 8, 1, 16, 3, 2, 220, DateTimeKind.Utc).AddTicks(3210), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(122), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(438), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(440), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(441), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(442), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(443), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2026, 8, 1, 16, 3, 2, 227, DateTimeKind.Utc).AddTicks(444), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2026, 8, 1, 16, 3, 2, 230, DateTimeKind.Utc).AddTicks(713), "admin@sistemas.com", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 230, DateTimeKind.Utc).AddTicks(715), "admin", null, new DateTime(2026, 8, 1, 16, 3, 2, 230, DateTimeKind.Utc).AddTicks(716), "User MOCK ", new byte[] { 176, 252, 74, 169, 109, 99, 246, 168, 113, 185, 144, 1, 123, 91, 58, 64, 174, 243, 246, 170, 219, 215, 118, 7, 173, 201, 200, 105, 0, 181, 134, 69, 148, 9, 70, 233, 185, 4, 221, 188, 163, 135, 152, 169, 149, 13, 122, 189, 241, 255, 59, 148, 111, 208, 151, 182, 226, 146, 202, 125, 207, 91, 172, 140 }, new byte[] { 178, 79, 210, 155, 237, 181, 54, 216, 249, 81, 158, 152, 85, 42, 76, 86, 188, 43, 174, 109, 55, 26, 112, 35, 122, 1, 129, 153, 78, 252, 61, 136, 206, 132, 74, 83, 100, 185, 74, 207, 2, 63, 123, 225, 115, 164, 212, 75, 105, 155, 164, 63, 17, 200, 126, 15, 133, 132, 200, 68, 13, 150, 236, 224, 105, 111, 176, 163, 144, 231, 171, 23, 183, 89, 206, 232, 104, 108, 131, 40, 100, 147, 127, 238, 30, 248, 192, 150, 91, 78, 21, 240, 100, 12, 87, 85, 38, 48, 239, 118, 224, 197, 163, 48, 218, 212, 100, 17, 127, 121, 1, 113, 245, 76, 140, 182, 80, 96, 24, 169, 55, 143, 217, 191, 241, 179, 182, 64 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "EndWorkingTime", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "PatientIntervalTimeMinutes", "SecurityKey", "StartWorkingTime", "TypeAccreditation", "UserId", "WorkingDays" },
                values: new object[] { 1L, "123456", new DateTime(2026, 8, 1, 16, 3, 2, 175, DateTimeKind.Utc).AddTicks(7633), 1L, "medical@sistemas.com", true, new TimeSpan(0, 20, 0, 0, 0), new DateTime(2026, 8, 1, 16, 3, 2, 175, DateTimeKind.Utc).AddTicks(7637), new DateTime(2026, 8, 1, 16, 3, 2, 175, DateTimeKind.Utc).AddTicks(7637), null, "Dr. Gabriel Monteiro", 1L, (byte)60, "", new TimeSpan(0, 6, 0, 0, 0), (byte)0, null, "1,2,3,4,5,6" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroupUser",
                columns: new[] { "RoleGroupId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "MedicalSpecialty",
                columns: new[] { "MedicalId", "SpecialtyId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotificationRules",
                columns: new[] { "Id", "CreatedDate", "Description", "ENotificationServiceType", "Enable", "IntervalType", "IntervalValue", "IsBefore", "IsEnabled", "Language", "LastAccessDate", "MedicalId", "ModifyDate", "NotificationType" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6753), "Envio 24 horas antes do agendamento", "0", true, (short)1, (short)24, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6758), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6758), (short)0 },
                    { 2L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6763), "Envio 3 dias antes do agendamento", "0", true, (short)2, (short)3, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6764), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6763), (short)0 },
                    { 3L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6765), "Envio 1 hora antes do agendamento", "0", true, (short)1, (short)1, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6766), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6765), (short)0 },
                    { 4L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6767), "Envio 15 minutos antes do agendamento", "0", true, (short)0, (short)15, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6768), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6767), (short)0 },
                    { 5L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6769), "Lembrete de pagamento (3 dias antes do vencimento)", "0", true, (short)2, (short)3, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6770), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6770), (short)2 },
                    { 6L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6771), "Envio 48 horas antes do agendamento", "0", true, (short)1, (short)48, true, true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6772), 1L, new DateTime(2026, 8, 1, 16, 3, 2, 188, DateTimeKind.Utc).AddTicks(6772), (short)0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 2L, false, new DateTime(2026, 8, 1, 16, 3, 2, 290, DateTimeKind.Utc).AddTicks(9659), "doctor@sistemas.com", true, "pt-BR", new DateTime(2026, 8, 1, 16, 3, 2, 290, DateTimeKind.Utc).AddTicks(9663), "doctor", 1L, new DateTime(2026, 8, 1, 16, 3, 2, 290, DateTimeKind.Utc).AddTicks(9664), "Dr. Gabriel Monteiro", new byte[] { 117, 81, 172, 139, 177, 26, 162, 96, 11, 168, 150, 45, 233, 163, 78, 58, 9, 255, 3, 63, 185, 246, 212, 225, 89, 243, 192, 30, 114, 17, 82, 188, 188, 104, 114, 149, 67, 169, 88, 165, 31, 101, 203, 185, 34, 151, 193, 1, 182, 38, 242, 54, 0, 207, 193, 146, 110, 73, 97, 162, 95, 57, 24, 112 }, new byte[] { 121, 75, 166, 184, 202, 90, 52, 198, 115, 26, 55, 150, 49, 144, 172, 169, 27, 181, 33, 161, 129, 27, 53, 96, 82, 212, 220, 132, 231, 193, 104, 247, 52, 134, 245, 159, 165, 172, 49, 45, 184, 181, 65, 195, 34, 141, 91, 54, 136, 239, 96, 145, 159, 130, 76, 10, 88, 185, 7, 202, 245, 44, 15, 33, 65, 208, 2, 196, 108, 49, 113, 11, 253, 228, 16, 6, 84, 132, 63, 172, 1, 204, 147, 145, 70, 252, 120, 140, 48, 41, 239, 240, 157, 67, 159, 65, 209, 16, 151, 82, 69, 57, 64, 9, 243, 209, 31, 80, 123, 218, 41, 43, 220, 141, 128, 165, 212, 80, 198, 124, 158, 30, 120, 97, 132, 232, 5, 134 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "InfoTag",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Enable", "LastAccessDate", "MedicalId", "ModifyDate", "ModifyUserId", "Tag" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Ansiedade" },
                    { 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Depressão" },
                    { 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "TDAH" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[,]
                {
                    { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9771), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9776), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9776), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" },
                    { 2L, "12345-678", "São Paulo", "Jardins", "São Paulo", "Rua das Flores, 123", "123.456.789-00", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9789), 2L, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Médio Completo", "ana.luiza@domain.com", "Carlos Ferreira", "(11) 91234-5678", true, 2L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9789), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9789), null, "Ana Luiza Ferreira", "(11) 4002-8922", "Estudante", "12.345.678-9" },
                    { 3L, "98765-432", "Rio de Janeiro", "Copacabana", "Rio de Janeiro", "Av. Atlântica, 456", "987.654.321-99", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9793), 2L, new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Superior Completo", "jose.henrique@domain.com", "Mariana Silva", "(21) 99876-5432", true, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9793), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9794), null, "José Henrique Silva", "(21) 3000-7000", "Advogado", "98.765.432-1" },
                    { 4L, "45678-123", "Belo Horizonte", "Savassi", "Minas Gerais", "Rua dos Ipês, 789", "456.789.123-10", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9796), 2L, new DateTime(1975, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pós-Graduação", "maria.clara@domain.com", "Fernando Oliveira", "(31) 97654-3210", true, 2L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9797), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9797), null, "Maria Clara Oliveira", "(31) 4004-3003", "Arquiteta", "45.678.912-0" },
                    { 5L, "65432-789", "Curitiba", "Centro Cívico", "Paraná", "Av. Paraná, 987", "654.321.987-88", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9800), 2L, new DateTime(2000, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Fundamental Completo", "gabriel.santos@domain.com", "Lucas Santos", "(41) 98432-1234", true, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9800), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9801), null, "Gabriel Santos", "(41) 3020-8989", "Atendente", "65.432.198-7" },
                    { 6L, "89010-123", "Blumenau", "Centro", "Santa Catarina", "Rua das Flores, 45", "456.123.789-09", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9804), 2L, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Médio Completo", "laura.costa@example.com", "Ana Costa", "(47) 99987-6543", true, 2L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9804), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9804), null, "Laura Carolina Costa", "(47) 3030-2020", "Estilista", "12.345.678-9" },
                    { 7L, "01310-100", "São Paulo", "Bela Vista", "São Paulo", "Avenida Paulista, 1500", "123.456.789-00", new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9807), 2L, new DateTime(1985, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Pós-Graduação", "diego.almeida@example.com", "Marina Almeida", "(11) 98888-1234", true, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9807), (byte)0, 1L, new DateTime(2026, 8, 1, 16, 3, 2, 202, DateTimeKind.Utc).AddTicks(9808), null, "Diego Rafael Almeida", "(11) 3111-4567", "Analista de Sistemas", "23.456.789-0" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientAdditionalInformation",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Enable", "FollowUp_Neurological", "FollowUp_Psychiatric", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Tiago Thales Mendes)", "Acompanhamento psiquiátrico mensal em andamento. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L },
                    { 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Tiago Thales Mendes)", "Histórico de crise de ansiedade; em estabilização. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L },
                    { 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Tiago Thales Mendes)", "Orientado sobre adesão medicamentosa e sono. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L },
                    { 4L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Ana Luiza Ferreira)", "Acompanhamento psiquiátrico mensal em andamento. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L },
                    { 5L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Ana Luiza Ferreira)", "Histórico de crise de ansiedade; em estabilização. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L },
                    { 6L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Ana Luiza Ferreira)", "Orientado sobre adesão medicamentosa e sono. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L },
                    { 7L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (José Henrique Silva)", "Acompanhamento psiquiátrico mensal em andamento. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L },
                    { 8L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (José Henrique Silva)", "Histórico de crise de ansiedade; em estabilização. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L },
                    { 9L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (José Henrique Silva)", "Orientado sobre adesão medicamentosa e sono. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L },
                    { 10L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Maria Clara Oliveira)", "Acompanhamento psiquiátrico mensal em andamento. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L },
                    { 11L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Maria Clara Oliveira)", "Histórico de crise de ansiedade; em estabilização. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L },
                    { 12L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Maria Clara Oliveira)", "Orientado sobre adesão medicamentosa e sono. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L },
                    { 13L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Gabriel Santos)", "Acompanhamento psiquiátrico mensal em andamento. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L },
                    { 14L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Gabriel Santos)", "Histórico de crise de ansiedade; em estabilização. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L },
                    { 15L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Gabriel Santos)", "Orientado sobre adesão medicamentosa e sono. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L },
                    { 16L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Laura Carolina Costa)", "Acompanhamento psiquiátrico mensal em andamento. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L },
                    { 17L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Laura Carolina Costa)", "Histórico de crise de ansiedade; em estabilização. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L },
                    { 18L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Laura Carolina Costa)", "Orientado sobre adesão medicamentosa e sono. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L },
                    { 19L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Sem intercorrências neurológicas relatadas. (Diego Rafael Almeida)", "Acompanhamento psiquiátrico mensal em andamento. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L },
                    { 20L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Avaliação neurológica prévia sem alterações. (Diego Rafael Almeida)", "Histórico de crise de ansiedade; em estabilização. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L },
                    { 21L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, "Encaminhado para reavaliação se houver cefaleia persistente. (Diego Rafael Almeida)", "Orientado sobre adesão medicamentosa e sono. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientFile",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "Enable", "FileBlobName", "FileCloudContainer", "FileContentType", "FileData", "FileExtension", "FileName", "FilePath", "FileSizeKB", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId", "TypeLocationSaveFile" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Tiago Thales Mendes", true, "", "", "application/pdf", new byte[0], "pdf", "p1-termo-consentimento.pdf", "/mock/patient/1/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, (byte)1 },
                    { 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Tiago Thales Mendes", true, "", "", "application/pdf", new byte[0], "pdf", "p1-exame-lab.pdf", "/mock/patient/1/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, (byte)1 },
                    { 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Tiago Thales Mendes", true, "", "", "image/png", new byte[0], "png", "p1-identificacao.png", "/mock/patient/1/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, (byte)1 },
                    { 4L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Ana Luiza Ferreira", true, "", "", "application/pdf", new byte[0], "pdf", "p2-termo-consentimento.pdf", "/mock/patient/2/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, (byte)1 },
                    { 5L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Ana Luiza Ferreira", true, "", "", "application/pdf", new byte[0], "pdf", "p2-exame-lab.pdf", "/mock/patient/2/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, (byte)1 },
                    { 6L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Ana Luiza Ferreira", true, "", "", "image/png", new byte[0], "png", "p2-identificacao.png", "/mock/patient/2/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, (byte)1 },
                    { 7L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - José Henrique Silva", true, "", "", "application/pdf", new byte[0], "pdf", "p3-termo-consentimento.pdf", "/mock/patient/3/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, (byte)1 },
                    { 8L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - José Henrique Silva", true, "", "", "application/pdf", new byte[0], "pdf", "p3-exame-lab.pdf", "/mock/patient/3/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, (byte)1 },
                    { 9L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - José Henrique Silva", true, "", "", "image/png", new byte[0], "png", "p3-identificacao.png", "/mock/patient/3/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, (byte)1 },
                    { 10L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Maria Clara Oliveira", true, "", "", "application/pdf", new byte[0], "pdf", "p4-termo-consentimento.pdf", "/mock/patient/4/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, (byte)1 },
                    { 11L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Maria Clara Oliveira", true, "", "", "application/pdf", new byte[0], "pdf", "p4-exame-lab.pdf", "/mock/patient/4/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, (byte)1 },
                    { 12L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Maria Clara Oliveira", true, "", "", "image/png", new byte[0], "png", "p4-identificacao.png", "/mock/patient/4/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, (byte)1 },
                    { 13L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Gabriel Santos", true, "", "", "application/pdf", new byte[0], "pdf", "p5-termo-consentimento.pdf", "/mock/patient/5/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, (byte)1 },
                    { 14L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Gabriel Santos", true, "", "", "application/pdf", new byte[0], "pdf", "p5-exame-lab.pdf", "/mock/patient/5/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, (byte)1 },
                    { 15L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Gabriel Santos", true, "", "", "image/png", new byte[0], "png", "p5-identificacao.png", "/mock/patient/5/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, (byte)1 },
                    { 16L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Laura Carolina Costa", true, "", "", "application/pdf", new byte[0], "pdf", "p6-termo-consentimento.pdf", "/mock/patient/6/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, (byte)1 },
                    { 17L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Laura Carolina Costa", true, "", "", "application/pdf", new byte[0], "pdf", "p6-exame-lab.pdf", "/mock/patient/6/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, (byte)1 },
                    { 18L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Laura Carolina Costa", true, "", "", "image/png", new byte[0], "png", "p6-identificacao.png", "/mock/patient/6/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, (byte)1 },
                    { 19L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Termo de consentimento - Diego Rafael Almeida", true, "", "", "application/pdf", new byte[0], "pdf", "p7-termo-consentimento.pdf", "/mock/patient/7/termo-consentimento.pdf", 120L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, (byte)1 },
                    { 20L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Exame laboratorial - Diego Rafael Almeida", true, "", "", "application/pdf", new byte[0], "pdf", "p7-exame-lab.pdf", "/mock/patient/7/exame-lab.pdf", 340L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, (byte)1 },
                    { 21L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Documento de identificação - Diego Rafael Almeida", true, "", "", "image/png", new byte[0], "png", "p7-identificacao.png", "/mock/patient/7/identificacao.png", 85L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, (byte)1 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                columns: new[] { "Id", "CID", "CreatedDate", "CreatedUserId", "Description", "Enable", "EndDate", "LastAccessDate", "ModifyDate", "ModifyUserId", "Observation", "PatientId", "StartDate" },
                values: new object[,]
                {
                    { 1L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Tiago Thales Mendes", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 1L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Tiago Thales Mendes", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 1L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Tiago Thales Mendes", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 1L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Ana Luiza Ferreira", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 2L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Ana Luiza Ferreira", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 2L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Ana Luiza Ferreira", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 2L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - José Henrique Silva", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 3L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - José Henrique Silva", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 3L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - José Henrique Silva", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 3L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Maria Clara Oliveira", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 4L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Maria Clara Oliveira", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 4L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Maria Clara Oliveira", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 4L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Gabriel Santos", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 5L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Gabriel Santos", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 5L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Gabriel Santos", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 5L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Laura Carolina Costa", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 6L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Laura Carolina Costa", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 6L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Laura Carolina Costa", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 6L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19L, "F41.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação psiquiátrica breve - Diego Rafael Almeida", true, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Alta com acompanhamento ambulatorial semanal.", 7L, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20L, "F32.1", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Observação clínica - Diego Rafael Almeida", true, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Estabilização do humor após ajuste medicamentoso.", 7L, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 21L, "F90.0", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Internação para avaliação diagnóstica - Diego Rafael Almeida", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, "Em avaliação multidisciplinar.", 7L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientInfoTag",
                columns: new[] { "InfoTagId", "PatientId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 2L },
                    { 1L, 3L },
                    { 1L, 4L },
                    { 1L, 5L },
                    { 1L, 6L },
                    { 1L, 7L },
                    { 2L, 1L },
                    { 2L, 2L },
                    { 2L, 3L },
                    { 2L, 4L },
                    { 2L, 5L },
                    { 2L, 6L },
                    { 2L, 7L },
                    { 3L, 1L },
                    { 3L, 2L },
                    { 3L, 3L },
                    { 3L, 4L },
                    { 3L, 5L },
                    { 3L, 6L },
                    { 3L, 7L }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientMedicationInformation",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "Dosage", "Enable", "EndDate", "LastAccessDate", "MainDrug", "ModifyDate", "ModifyUserId", "PatientId", "Posology", "StartDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Tiago Thales Mendes", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Tiago Thales Mendes", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Tiago Thales Mendes", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Ana Luiza Ferreira", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Ana Luiza Ferreira", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Ana Luiza Ferreira", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - José Henrique Silva", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - José Henrique Silva", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - José Henrique Silva", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Maria Clara Oliveira", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Maria Clara Oliveira", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Maria Clara Oliveira", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Gabriel Santos", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Gabriel Santos", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Gabriel Santos", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Laura Carolina Costa", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Laura Carolina Costa", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Laura Carolina Costa", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Ansiolítico - Diego Rafael Almeida", "0,5 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Clonazepam", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "1 comprimido à noite", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Antidepressivo - Diego Rafael Almeida", "50 mg", true, null, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sertralina", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "1 comprimido pela manhã", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 21L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Estimulante - Diego Rafael Almeida", "10 mg", true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Metilfenidato", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "1 comprimido pela manhã", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientNotificationMessage",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Enable", "IsReaded", "LastAccessDate", "MessagePatient", "ModifyDate", "ModifyUserId", "Notified", "NotifiedDate", "PatientId", "ReadingDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1L, null },
                    { 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Tiago Thales Mendes)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 1L, null },
                    { 4L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, null },
                    { 6L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Ana Luiza Ferreira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 2L, null },
                    { 7L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 3L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 3L, null },
                    { 9L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (José Henrique Silva)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 3L, null },
                    { 10L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 4L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 11L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 4L, null },
                    { 12L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Maria Clara Oliveira)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 4L, null },
                    { 13L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 5L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 14L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 5L, null },
                    { 15L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Gabriel Santos)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 5L, null },
                    { 16L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 6L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 17L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 6L, null },
                    { 18L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Laura Carolina Costa)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 6L, null },
                    { 19L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Lembrete: sua consulta está agendada para amanhã às 10h. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 7L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc) },
                    { 20L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Por favor, confirme a presença na sessão da próxima semana. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 7L, null },
                    { 21L, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, true, false, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Nova mensagem do seu profissional de saúde disponível. (Diego Rafael Almeida)", new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, false, null, 7L, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PatientRecord",
                columns: new[] { "Id", "Annotation", "AnnotationDate", "CreatedDate", "CreatedUserId", "Description", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "PatientId", "TableStorageRowKey" },
                values: new object[,]
                {
                    { 1L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Tiago Thales Mendes", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "" },
                    { 2L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Tiago Thales Mendes", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "" },
                    { 3L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Tiago Thales Mendes", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 1L, "" },
                    { 4L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Ana Luiza Ferreira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "" },
                    { 5L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Ana Luiza Ferreira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "" },
                    { 6L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Ana Luiza Ferreira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 2L, "" },
                    { 7L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - José Henrique Silva", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "" },
                    { 8L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - José Henrique Silva", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "" },
                    { 9L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - José Henrique Silva", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 3L, "" },
                    { 10L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Maria Clara Oliveira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "" },
                    { 11L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Maria Clara Oliveira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "" },
                    { 12L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Maria Clara Oliveira", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 4L, "" },
                    { 13L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Gabriel Santos", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "" },
                    { 14L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Gabriel Santos", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "" },
                    { 15L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Gabriel Santos", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 5L, "" },
                    { 16L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Laura Carolina Costa", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "" },
                    { 17L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Laura Carolina Costa", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "" },
                    { 18L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Laura Carolina Costa", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 6L, "" },
                    { 19L, "Paciente relatou sintomas de ansiedade generalizada. Plano terapêutico iniciado.", new DateTime(2024, 2, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Sessão inicial - Diego Rafael Almeida", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "" },
                    { 20L, "Melhora parcial do humor. Mantido protocolo cognitivo-comportamental.", new DateTime(2024, 5, 15, 16, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Acompanhamento - Diego Rafael Almeida", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "" },
                    { 21L, "Sinais compatíveis com TDAH adulto. Encaminhado para avaliação complementar.", new DateTime(2025, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), 2L, "Avaliação diagnóstica - Diego Rafael Almeida", true, new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 3, 4, 12, 0, 0, 0, DateTimeKind.Utc), null, 7L, "" }
                });

            migrationBuilder.CreateIndex(
                name: "Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique",
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "ResourceKey", "Language", "LanguageKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                columns: new[] { "TableName", "Operation", "AuditDate", "UserAuditedId" });

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                columns: new[] { "TableName", "Operation" });

            migrationBuilder.CreateIndex(
                name: "IX_AuditDataEntityLog_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                column: "UserAuditedId");

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                columns: new[] { "TableName", "Operation", "AuditDate", "UserAuditedId" });

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                columns: new[] { "TableName", "Operation" });

            migrationBuilder.CreateIndex(
                name: "IX_AuditDataSelectiveEntityLog_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                column: "UserAuditedId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoTag_CreatedUserId",
                schema: "dbo",
                table: "InfoTag",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoTag_MedicalId",
                schema: "dbo",
                table: "InfoTag",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoTag_ModifyUserId",
                schema: "dbo",
                table: "InfoTag",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_MedicalId",
                schema: "dbo",
                table: "Leaves",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_StartDate_EndDate",
                schema: "dbo",
                table: "Leaves",
                columns: new[] { "StartDate", "EndDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Medical_CreatedUserId",
                schema: "dbo",
                table: "Medical",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_ModifyUserId",
                schema: "dbo",
                table: "Medical",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_OfficeId",
                schema: "dbo",
                table: "Medical",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_UserId",
                schema: "dbo",
                table: "Medical",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_Inc_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "TokenRecurrence");

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                columns: new[] { "TokenRecurrence", "PatientId", "MedicalId", "StartDateTime", "EndDateTime" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_CreatedUserId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_MedicalId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_ModifyUserId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_PatientId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFile_CreatedUserId",
                schema: "dbo",
                table: "MedicalFile",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFile_MedicalId",
                schema: "dbo",
                table: "MedicalFile",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFile_ModifyUserId",
                schema: "dbo",
                table: "MedicalFile",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSettings_MedicalId",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSettings_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId1");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSpecialty_SpecialtyId",
                schema: "dbo",
                table: "MedicalSpecialty",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_IsCompleted",
                schema: "dbo",
                table: "NotificationRecords",
                column: "IsCompleted");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_NextScheduledSendTime",
                schema: "dbo",
                table: "NotificationRecords",
                column: "NextScheduledSendTime");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRules_MedicalId",
                schema: "dbo",
                table: "NotificationRules",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language",
                schema: "dbo",
                table: "NotificationTemplate",
                column: "Language");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Language", "TagApi", "Enable" });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Unique",
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Language", "TagApi" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_TagApi",
                schema: "dbo",
                table: "NotificationTemplate",
                column: "TagApi");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CreatedUserId",
                schema: "dbo",
                table: "Patient",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_GenderId",
                schema: "dbo",
                table: "Patient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicalId",
                schema: "dbo",
                table: "Patient",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ModifyUserId",
                schema: "dbo",
                table: "Patient",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInformation_CreatedUserId",
                schema: "dbo",
                table: "PatientAdditionalInformation",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInformation_ModifyUserId",
                schema: "dbo",
                table: "PatientAdditionalInformation",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAdditionalInformation_PatientId",
                schema: "dbo",
                table: "PatientAdditionalInformation",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFile_CreatedUserId",
                schema: "dbo",
                table: "PatientFile",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFile_ModifyUserId",
                schema: "dbo",
                table: "PatientFile",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientFile_PatientId",
                schema: "dbo",
                table: "PatientFile",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHospitalizationInformation_CreatedUserId",
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHospitalizationInformation_ModifyUserId",
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHospitalizationInformation_PatientId",
                schema: "dbo",
                table: "PatientHospitalizationInformation",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfoTag_PatientId",
                schema: "dbo",
                table: "PatientInfoTag",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicationInformation_CreatedUserId",
                schema: "dbo",
                table: "PatientMedicationInformation",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicationInformation_ModifyUserId",
                schema: "dbo",
                table: "PatientMedicationInformation",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicationInformation_PatientId",
                schema: "dbo",
                table: "PatientMedicationInformation",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotificationMessage_CreatedUserId",
                schema: "dbo",
                table: "PatientNotificationMessage",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotificationMessage_ModifyUserId",
                schema: "dbo",
                table: "PatientNotificationMessage",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotificationMessage_PatientId",
                schema: "dbo",
                table: "PatientNotificationMessage",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_CreatedUserId",
                schema: "dbo",
                table: "PatientRecord",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_ModifyUserId",
                schema: "dbo",
                table: "PatientRecord",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_PatientId",
                schema: "dbo",
                table: "PatientRecord",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroupUser_RoleGroupId",
                schema: "dbo",
                table: "RoleGroupUser",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_CreatedUserId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_MedicalId_PatientId_Period",
                schema: "dbo",
                table: "ScheduleBatch",
                columns: new[] { "MedicalId", "PatientId", "StartPeriod", "EndPeriod" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_ModifyUserId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_PatientId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_UniqueToken",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "UniqueToken",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MedicalId",
                schema: "dbo",
                table: "User",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokenSession_UserId",
                schema: "dbo",
                table: "UserTokenSession",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditDataEntityLog_User_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                column: "UserAuditedId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditDataSelectiveEntityLog_User_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                column: "UserAuditedId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoTag_Medical_MedicalId",
                schema: "dbo",
                table: "InfoTag",
                column: "MedicalId",
                principalSchema: "dbo",
                principalTable: "Medical",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfoTag_User_CreatedUserId",
                schema: "dbo",
                table: "InfoTag",
                column: "CreatedUserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfoTag_User_ModifyUserId",
                schema: "dbo",
                table: "InfoTag",
                column: "ModifyUserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaves_Medical_MedicalId",
                schema: "dbo",
                table: "Leaves",
                column: "MedicalId",
                principalSchema: "dbo",
                principalTable: "Medical",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_User_CreatedUserId",
                schema: "dbo",
                table: "Medical",
                column: "CreatedUserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_User_ModifyUserId",
                schema: "dbo",
                table: "Medical",
                column: "ModifyUserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_User_UserId",
                schema: "dbo",
                table: "Medical",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_User_CreatedUserId",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_User_ModifyUserId",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_User_UserId",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.DropTable(
                name: "ApplicationCacheLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationConfigSetting",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationLanguage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AuditDataEntityLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AuditDataSelectiveEntityLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Leaves",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalSpecialty",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "NotificationRecords",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "NotificationRules",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "NotificationTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientAdditionalInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientHospitalizationInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientInfoTag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientMedicationInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientNotificationMessage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PatientRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleGroupUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ScheduleBatch",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTokenSession",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Specialty",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalCalendar",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "InfoTag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Medical",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Office",
                schema: "dbo");
        }
    }
}
