using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileData = table.Column<byte[]>(type: "longblob", nullable: true),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint unsigned", nullable: false)
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
                name: "MedicalCalendar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AllDay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    ColorCategory = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Url = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    PushedCalendar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TimeZone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
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
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileData = table.Column<byte[]>(type: "longblob", nullable: true),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint unsigned", nullable: false)
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
                    Annotation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AnnotationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "EndPointUrl_Cache", "EndPointUrl_StorageFiles", "Language", "LastAccessDate", "ModifyDate", "TypeLocationCache", "TypeLocationQueeMessaging", "TypeLocationSaveFiles" },
                values: new object[] { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6261), "Default", true, "", "", "pt-BR", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6264), (byte)1, (byte)0, (byte)0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6479), "Registro atualizado", true, "pt-BR", "RegisterUpdated", "Registro atualizado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6479), "SharedResource" },
                    { 2L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6481), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6482), "ApplicationLanguage" },
                    { 3L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6483), "Registro encontrado", true, "pt-BR", "RegisterIsFound", "Registro encontrado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6484), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6484), "SharedResource" },
                    { 4L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486), "Registro não encontrado", true, "pt-BR", "RegisterIsNotFound", "Registro não encontrado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6486), "SharedResource" },
                    { 5L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488), "Registro existe", true, "pt-BR", "RegisterExist", "Registro existe", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6488), "SharedResource" },
                    { 6L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490), "Registro deletado", true, "pt-BR", "RegisterDeleted", "Registro deletado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6490), "SharedResource" },
                    { 7L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492), "Registro localizado", true, "pt-BR", "RegisterFind", "Registro localizado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6492), "SharedResource" },
                    { 8L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6494), "Registros contabilizados", true, "pt-BR", "RegisterCounted", "Registros contabilizados", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6494), "SharedResource" },
                    { 9L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6496), "Registro criado", true, "pt-BR", "RegisterCreated", "Registro criado", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6497), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6496), "SharedResource" },
                    { 10L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6498), "A descrição não pode ser vazia", true, "pt-BR", "ErrorValidator_Description_Null", "A descrição não pode ser vazia", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6498), "SharedResource" },
                    { 11L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6500), "O idoma não pode ser vazio", true, "pt-BR", "ErrorValidator_Language_Null", "O idoma não pode ser vazio", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6500), "SharedResource" },
                    { 12L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6502), "O idoma não pode ultrapassar {MaxLength}", true, "pt-BR", "ErrorValidator_Language_MaximumLength", "O idoma não pode ultrapassar {MaxLength}", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6502), "SharedResource" },
                    { 13L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6504), "Válido", true, "pt-BR", "LangValid", "Válido", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6504), "SharedResource" },
                    { 14L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6506), "Ocorreram erros!", true, "pt-BR", "LangErrors", "Ocorreram erros!", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6506), "SharedResource" },
                    { 15L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6508), "O medico deve ser informado.", true, "pt-BR", "ErrorValidator_MedicalId_Null", "O medico deve ser informado.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6508), "SharedResource" },
                    { 16L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6510), "O medico informado não existe.", true, "pt-BR", "ErrorValidator_MedicalId_NotFound", "O medico informado não existe.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6511), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6510), "SharedResource" },
                    { 17L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6512), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_Medical_Changed", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6512), "SharedResource" },
                    { 18L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6514), "O nome não pode ser vazio", true, "pt-BR", "ErrorValidator_Name_Null", "O nome não pode ser vazio", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6514), "SharedResource" },
                    { 19L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6516), "O Login não pode ser vazio.", true, "pt-BR", "ErrorValidator_Login_Null", "O Login não pode ser vazio.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6516), "SharedResource" },
                    { 20L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6518), "Login deve ser unico.", true, "pt-BR", "ErrorValidator_Login_Unique", "Login deve ser unico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6518), "SharedResource" },
                    { 21L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6520), "O Email não pode ser vazio", true, "pt-BR", "ErrorValidator_Email_Null", "O Email não pode ser vazio", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6521), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6521), "SharedResource" },
                    { 22L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6522), "O Email é invalido.", true, "pt-BR", "ErrorValidator_Email_Invalid", "O Email é invalido.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6523), "SharedResource" },
                    { 23L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6524), "O Email deve ser unico.", true, "pt-BR", "ErrorValidator_Email_Unique", "O Email deve ser unico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6525), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6525), "SharedResource" },
                    { 24L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6526), "O Credenciamento não pode ser vazio.", true, "pt-BR", "ErrorValidator_Accreditation_Null", "O Credenciamento não pode ser vazio.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6527), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6526), "SharedResource" },
                    { 25L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6528), "O Credenciamento deve ser unico.", true, "pt-BR", "ErrorValidator_Accreditation_Unique", "O Credenciamento deve ser unico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6529), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6529), "SharedResource" },
                    { 26L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6530), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalCreated_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6530), "SharedResource" },
                    { 27L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6532), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalModify_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6533), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6533), "SharedResource" },
                    { 28L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6534), "O Paciente deve ser informado.", true, "pt-BR", "ErrorValidator_Patient_Null", "O Paciente deve ser informado.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6535), "SharedResource" },
                    { 29L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6536), "O Paciente informado não existe.", true, "pt-BR", "ErrorValidator_Patient_NotFound", "O Paciente informado não existe.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6537), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6537), "SharedResource" },
                    { 30L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6538), "O Paciente não pode ser alterado.", true, "pt-BR", "ErrorValidator_Patient_Changed", "O Paciente não pode ser alterado.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6539), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6539), "SharedResource" },
                    { 31L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6540), "Informações do paciente não podem ser adicionadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Created", "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6541), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6541), "SharedResource" },
                    { 32L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6542), "Informações do paciente não podem ser modificadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Modify", "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6543), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6543), "SharedResource" },
                    { 33L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6544), "O Usuário que está criando deve ser informado.", true, "pt-BR", "ErrorValidator_CreatedUserId_Null", "O Usuário que está criando deve ser informado.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6545), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6545), "SharedResource" },
                    { 34L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6577), "A anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_Annotation_Null", "A anotação não pode ser vazia.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6578), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6578), "SharedResource" },
                    { 35L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580), "A data da anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_AnnotationDate_Null", "A data da anotação não pode ser vazia.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6580), "SharedResource" },
                    { 36L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6581), "Data de nascimento invalido", true, "pt-BR", "ErrorValidator_DateOfBirth_Invalid", "Data de nascimento invalido", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6582), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6582), "SharedResource" },
                    { 37L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6583), "O Rg não pode ser vazio.", true, "pt-BR", "ErrorValidator_RG_Null", "O Rg não pode ser vazio.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6584), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6584), "SharedResource" },
                    { 38L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6585), "O CPF não pode ser vazio.", true, "pt-BR", "ErrorValidator_CPF_Null", "O CPF não pode ser vazio.", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6586), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6586), "SharedResource" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6700), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6701), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6896), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6898), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6899), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7111), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7113), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7114), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7116), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7117), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7118), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7225), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7227), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7228), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7229), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7230), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7232), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7233), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7339), "admin@sistemas.com", true, "pt-BR", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7340), "admin", null, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(7340), "User MOCK ", new byte[] { 91, 49, 58, 113, 111, 72, 106, 128, 245, 123, 210, 104, 16, 253, 147, 0, 206, 108, 236, 150, 11, 163, 208, 19, 242, 44, 217, 139, 163, 25, 36, 107, 238, 172, 146, 2, 145, 73, 77, 49, 74, 1, 0, 130, 22, 129, 43, 156, 190, 212, 212, 202, 14, 16, 239, 150, 72, 231, 6, 132, 67, 255, 206, 148 }, new byte[] { 224, 143, 128, 247, 194, 230, 89, 121, 202, 119, 55, 231, 81, 46, 240, 155, 152, 74, 168, 32, 37, 143, 100, 240, 229, 30, 232, 52, 246, 111, 228, 47, 34, 198, 117, 159, 86, 165, 243, 46, 147, 250, 169, 235, 84, 221, 231, 181, 227, 61, 8, 238, 61, 9, 90, 137, 148, 51, 9, 234, 202, 237, 117, 55, 220, 221, 139, 77, 135, 71, 89, 38, 50, 38, 225, 90, 59, 207, 116, 155, 194, 105, 246, 241, 109, 121, 202, 193, 57, 147, 100, 138, 75, 58, 16, 33, 146, 0, 83, 138, 43, 71, 226, 82, 245, 233, 249, 25, 11, 246, 167, 163, 104, 201, 202, 30, 175, 219, 237, 235, 26, 222, 107, 203, 37, 148, 55, 35 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "SecurityKey", "TypeAccreditation", "UserId" },
                values: new object[] { 1L, "123456", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6804), 1L, "medical@sistemas.com", true, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6805), null, "Medical MOCK ", 1L, "", (byte)0, null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 2L, false, new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8356), "doctor@sistemas.com", true, "pt-BR", new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8357), "doctor", 1L, new DateTime(2024, 4, 7, 21, 58, 9, 694, DateTimeKind.Utc).AddTicks(8358), "User Medical", new byte[] { 104, 94, 194, 218, 182, 175, 36, 59, 99, 247, 229, 170, 92, 250, 218, 138, 87, 119, 133, 163, 87, 49, 195, 19, 152, 184, 181, 251, 50, 124, 186, 182, 186, 138, 54, 85, 13, 138, 196, 39, 63, 67, 204, 212, 52, 161, 59, 162, 218, 216, 169, 249, 30, 89, 122, 24, 4, 170, 206, 156, 6, 127, 0, 20 }, new byte[] { 54, 46, 182, 3, 211, 120, 69, 73, 183, 122, 158, 27, 222, 13, 33, 44, 27, 159, 239, 19, 6, 145, 189, 171, 221, 53, 110, 0, 207, 159, 13, 245, 93, 252, 142, 72, 74, 75, 87, 160, 253, 234, 85, 135, 189, 117, 234, 79, 99, 36, 111, 174, 31, 245, 94, 228, 108, 201, 146, 187, 103, 111, 71, 203, 169, 173, 135, 17, 102, 188, 255, 18, 78, 214, 116, 98, 245, 66, 188, 127, 221, 191, 18, 91, 196, 109, 130, 145, 235, 119, 251, 177, 177, 15, 223, 241, 189, 218, 58, 1, 225, 78, 118, 113, 71, 107, 42, 47, 175, 244, 125, 238, 115, 154, 243, 112, 30, 99, 77, 61, 134, 211, 141, 194, 56, 197, 124, 48 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6997), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6997), (byte)0, 1L, new DateTime(2024, 4, 7, 21, 58, 9, 692, DateTimeKind.Utc).AddTicks(6998), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" });

            migrationBuilder.CreateIndex(
                name: "Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique",
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "ResourceKey", "Language", "LanguageKey" },
                unique: true);

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
                name: "IX_MedicalSpecialty_SpecialtyId",
                schema: "dbo",
                table: "MedicalSpecialty",
                column: "SpecialtyId");

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
                name: "IX_User_MedicalId",
                schema: "dbo",
                table: "User",
                column: "MedicalId");

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
                name: "FK_User_Medical_MedicalId",
                schema: "dbo",
                table: "User");

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
                name: "MedicalCalendar",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MedicalSpecialty",
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
                name: "Specialty",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "InfoTag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Medical",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Office",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");
        }
    }
}
