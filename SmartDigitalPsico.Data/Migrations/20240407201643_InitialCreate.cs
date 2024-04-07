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
                    RoleGroupsId = table.Column<long>(type: "bigint", nullable: false),
                    UsersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroupUser", x => new { x.RoleGroupsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleGroupUser_RoleGroup_RoleGroupsId",
                        column: x => x.RoleGroupsId,
                        principalSchema: "dbo",
                        principalTable: "RoleGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleGroupUser_User_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                values: new object[] { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8591), "Default", true, "", "", "pt-BR", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8593), (byte)1, (byte)0, (byte)0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8806), "Registro atualizado", true, "pt-BR", "RegisterUpdated", "Registro atualizado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8806), "SharedResource" },
                    { 2L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8808), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8809), "ApplicationLanguage" },
                    { 3L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8810), "Registro encontrado", true, "pt-BR", "RegisterIsFound", "Registro encontrado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8811), "SharedResource" },
                    { 4L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8812), "Registro não encontrado", true, "pt-BR", "RegisterIsNotFound", "Registro não encontrado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8813), "SharedResource" },
                    { 5L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8814), "Registro existe", true, "pt-BR", "RegisterExist", "Registro existe", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8815), "SharedResource" },
                    { 6L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8816), "Registro deletado", true, "pt-BR", "RegisterDeleted", "Registro deletado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8817), "SharedResource" },
                    { 7L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8818), "Registro localizado", true, "pt-BR", "RegisterFind", "Registro localizado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8819), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8819), "SharedResource" },
                    { 8L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8820), "Registros contabilizados", true, "pt-BR", "RegisterCounted", "Registros contabilizados", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8821), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8820), "SharedResource" },
                    { 9L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8822), "Registro criado", true, "pt-BR", "RegisterCreated", "Registro criado", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8822), "SharedResource" },
                    { 10L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8824), "A descrição não pode ser vazia", true, "pt-BR", "ErrorValidator_Description_Null", "A descrição não pode ser vazia", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8824), "SharedResource" },
                    { 11L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8865), "O idoma não pode ser vazio", true, "pt-BR", "ErrorValidator_Language_Null", "O idoma não pode ser vazio", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8865), "SharedResource" },
                    { 12L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8867), "O idoma não pode ultrapassar {MaxLength}", true, "pt-BR", "ErrorValidator_Language_MaximumLength", "O idoma não pode ultrapassar {MaxLength}", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8867), "SharedResource" },
                    { 13L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8869), "Válido", true, "pt-BR", "LangValid", "Válido", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8869), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8869), "SharedResource" },
                    { 14L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8871), "Ocorreram erros!", true, "pt-BR", "LangErrors", "Ocorreram erros!", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8871), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8871), "SharedResource" },
                    { 15L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8873), "O medico deve ser informado.", true, "pt-BR", "ErrorValidator_MedicalId_Null", "O medico deve ser informado.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8873), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8873), "SharedResource" },
                    { 16L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8875), "O medico informado não existe.", true, "pt-BR", "ErrorValidator_MedicalId_NotFound", "O medico informado não existe.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8875), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8875), "SharedResource" },
                    { 17L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8876), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_Medical_Changed", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8877), "SharedResource" },
                    { 18L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8878), "O nome não pode ser vazio", true, "pt-BR", "ErrorValidator_Name_Null", "O nome não pode ser vazio", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8879), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8879), "SharedResource" },
                    { 19L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8881), "O Login não pode ser vazio.", true, "pt-BR", "ErrorValidator_Login_Null", "O Login não pode ser vazio.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8881), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8881), "SharedResource" },
                    { 20L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8883), "Login deve ser unico.", true, "pt-BR", "ErrorValidator_Login_Unique", "Login deve ser unico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8883), "SharedResource" },
                    { 21L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8884), "O Email não pode ser vazio", true, "pt-BR", "ErrorValidator_Email_Null", "O Email não pode ser vazio", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8885), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8885), "SharedResource" },
                    { 22L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8886), "O Email é invalido.", true, "pt-BR", "ErrorValidator_Email_Invalid", "O Email é invalido.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8887), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8887), "SharedResource" },
                    { 23L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8888), "O Email deve ser unico.", true, "pt-BR", "ErrorValidator_Email_Unique", "O Email deve ser unico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8889), "SharedResource" },
                    { 24L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8890), "O Credenciamento não pode ser vazio.", true, "pt-BR", "ErrorValidator_Accreditation_Null", "O Credenciamento não pode ser vazio.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8891), "SharedResource" },
                    { 25L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8892), "O Credenciamento deve ser unico.", true, "pt-BR", "ErrorValidator_Accreditation_Unique", "O Credenciamento deve ser unico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8893), "SharedResource" },
                    { 26L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8894), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalCreated_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8895), "SharedResource" },
                    { 27L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8896), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalModify_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8896), "SharedResource" },
                    { 28L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8898), "O Paciente deve ser informado.", true, "pt-BR", "ErrorValidator_Patient_Null", "O Paciente deve ser informado.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8898), "SharedResource" },
                    { 29L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8900), "O Paciente informado não existe.", true, "pt-BR", "ErrorValidator_Patient_NotFound", "O Paciente informado não existe.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8900), "SharedResource" },
                    { 30L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8902), "O Paciente não pode ser alterado.", true, "pt-BR", "ErrorValidator_Patient_Changed", "O Paciente não pode ser alterado.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8902), "SharedResource" },
                    { 31L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8904), "Informações do paciente não podem ser adicionadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Created", "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8904), "SharedResource" },
                    { 32L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8906), "Informações do paciente não podem ser modificadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Modify", "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8906), "SharedResource" },
                    { 33L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8908), "O Usuário que está criando deve ser informado.", true, "pt-BR", "ErrorValidator_CreatedUserId_Null", "O Usuário que está criando deve ser informado.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8908), "SharedResource" },
                    { 34L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8910), "A anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_Annotation_Null", "A anotação não pode ser vazia.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8910), "SharedResource" },
                    { 35L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8912), "A data da anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_AnnotationDate_Null", "A data da anotação não pode ser vazia.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8912), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8912), "SharedResource" },
                    { 36L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8913), "Data de nascimento invalido", true, "pt-BR", "ErrorValidator_DateOfBirth_Invalid", "Data de nascimento invalido", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8914), "SharedResource" },
                    { 37L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8916), "O Rg não pode ser vazio.", true, "pt-BR", "ErrorValidator_RG_Null", "O Rg não pode ser vazio.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8916), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8916), "SharedResource" },
                    { 38L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8917), "O CPF não pode ser vazio.", true, "pt-BR", "ErrorValidator_CPF_Null", "O CPF não pode ser vazio.", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(8918), "SharedResource" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9042), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9043), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9250), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9252), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9253), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9467), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9469), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9470), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9471), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9472), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9473), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9568), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9569), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9571), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9597), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9599), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9600), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9601), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9709), "admin@sistemas.com", true, "pt-BR", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9709), "admin", null, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9710), "User MOCK ", new byte[] { 58, 57, 96, 217, 211, 117, 38, 152, 181, 230, 254, 255, 86, 31, 179, 75, 171, 151, 169, 218, 125, 216, 60, 164, 121, 165, 67, 213, 244, 147, 192, 178, 207, 222, 228, 130, 117, 43, 118, 25, 115, 103, 254, 58, 182, 130, 10, 28, 236, 193, 21, 188, 57, 79, 117, 132, 227, 226, 122, 185, 78, 55, 228, 118 }, new byte[] { 182, 132, 56, 65, 143, 157, 224, 115, 251, 87, 64, 165, 152, 134, 173, 72, 55, 21, 67, 80, 8, 82, 80, 192, 29, 218, 230, 157, 9, 106, 243, 117, 50, 46, 141, 102, 200, 61, 103, 142, 60, 233, 149, 129, 78, 151, 205, 147, 136, 117, 155, 65, 107, 47, 15, 78, 219, 72, 9, 173, 185, 93, 10, 167, 191, 145, 38, 147, 254, 152, 251, 22, 107, 18, 10, 49, 131, 155, 45, 60, 103, 210, 21, 138, 95, 189, 65, 137, 128, 57, 74, 33, 174, 197, 246, 209, 234, 156, 169, 244, 161, 225, 106, 34, 239, 239, 68, 88, 192, 80, 14, 172, 219, 144, 184, 158, 26, 104, 172, 134, 70, 52, 13, 71, 57, 235, 62, 20 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "SecurityKey", "TypeAccreditation", "UserId" },
                values: new object[] { 1L, "123456", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9147), 1L, "medical@sistemas.com", true, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9147), new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9148), null, "Medical MOCK ", 1L, "", (byte)0, null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroupUser",
                columns: new[] { "RoleGroupsId", "UsersId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 2L, false, new DateTime(2024, 4, 7, 20, 16, 43, 298, DateTimeKind.Utc).AddTicks(8873), "doctor@sistemas.com", true, "pt-BR", new DateTime(2024, 4, 7, 20, 16, 43, 298, DateTimeKind.Utc).AddTicks(8875), "doctor", 1L, new DateTime(2024, 4, 7, 20, 16, 43, 298, DateTimeKind.Utc).AddTicks(8875), "User Medical", new byte[] { 178, 243, 19, 215, 112, 91, 135, 172, 156, 146, 226, 217, 88, 19, 45, 168, 135, 175, 102, 158, 114, 34, 5, 107, 252, 153, 90, 171, 136, 40, 243, 182, 163, 130, 102, 249, 222, 222, 101, 39, 205, 109, 123, 240, 141, 184, 189, 39, 173, 156, 207, 88, 79, 233, 234, 216, 229, 151, 128, 205, 180, 217, 106, 220 }, new byte[] { 245, 146, 159, 83, 191, 61, 21, 249, 226, 178, 239, 221, 126, 254, 122, 75, 166, 150, 100, 43, 247, 162, 86, 71, 35, 12, 199, 43, 85, 187, 127, 110, 183, 123, 77, 219, 24, 63, 188, 42, 20, 157, 44, 57, 239, 52, 17, 230, 200, 153, 215, 48, 33, 109, 34, 138, 44, 70, 71, 226, 19, 182, 231, 60, 32, 82, 254, 141, 202, 67, 49, 87, 212, 28, 176, 49, 143, 74, 32, 224, 78, 56, 222, 255, 13, 210, 105, 204, 131, 47, 58, 79, 24, 119, 63, 216, 160, 43, 201, 17, 174, 109, 248, 36, 19, 239, 124, 157, 245, 30, 163, 189, 115, 83, 116, 68, 191, 99, 239, 240, 106, 0, 141, 224, 248, 135, 112, 109 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9353), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9353), (byte)0, 1L, new DateTime(2024, 4, 7, 20, 16, 43, 295, DateTimeKind.Utc).AddTicks(9354), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroupUser",
                columns: new[] { "RoleGroupsId", "UsersId" },
                values: new object[] { 2L, 2L });

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
                name: "IX_RoleGroupUser_UsersId",
                schema: "dbo",
                table: "RoleGroupUser",
                column: "UsersId");

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
