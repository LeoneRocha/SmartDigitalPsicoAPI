using System;
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

            migrationBuilder.CreateTable(
                name: "ApplicationCacheLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeSlidingExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CacheId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CacheKey = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationCacheLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationConfigSetting",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EndPointUrl_StorageFiles = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EndPointUrl_Cache = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TypeLocationSaveFiles = table.Column<byte>(type: "tinyint", nullable: false),
                    TypeLocationCache = table.Column<byte>(type: "tinyint", nullable: false),
                    TypeLocationQueeMessaging = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationConfigSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationLanguage",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LanguageKey = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ResourceKey = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LanguageValue = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    RolePolicyClaimCode = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialty",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoTag",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Tag = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medical",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Accreditation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TypeAccreditation = table.Column<byte>(type: "tinyint", nullable: false),
                    SecurityKey = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    OfficeId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "MedicalSpecialty",
                schema: "dbo",
                columns: table => new
                {
                    MedicalsId = table.Column<long>(type: "bigint", nullable: false),
                    SpecialtiesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecialty", x => new { x.MedicalsId, x.SpecialtiesId });
                    table.ForeignKey(
                        name: "FK_MedicalSpecialty_Medical_MedicalsId",
                        column: x => x.MedicalsId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalSpecialty_Specialty_SpecialtiesId",
                        column: x => x.SpecialtiesId,
                        principalSchema: "dbo",
                        principalTable: "Specialty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Login = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    TimeZone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refresh_token_expiry_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "MedicalFile",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profession = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Rg = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Education = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    MaritalStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    AddressStreet = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    AddressNeighborhood = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    AddressCity = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    AddressState = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    AddressCep = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    EmergencyContactName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    EmergencyContactPhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    GenderId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "MedicalCalendar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    ColorCategory = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    PushedCalendar = table.Column<bool>(type: "bit", nullable: false),
                    TimeZone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PatientAdditionalInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    FollowUp_Psychiatric = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    FollowUp_Neurological = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PatientFile",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    FilePath = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    FileContentType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileSizeKB = table.Column<long>(type: "bigint", nullable: false),
                    TypeLocationSaveFile = table.Column<byte>(type: "tinyint", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PatientHospitalizationInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CID = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Observation = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicationInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dosage = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Posology = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    MainDrug = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PatientNotificationMessage",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    MessagePatient = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    IsReaded = table.Column<bool>(type: "bit", nullable: false),
                    ReadingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notified = table.Column<bool>(type: "bit", nullable: false),
                    NotifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Annotation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnotationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "EndPointUrl_Cache", "EndPointUrl_StorageFiles", "Language", "LastAccessDate", "ModifyDate", "TypeLocationCache", "TypeLocationQueeMessaging", "TypeLocationSaveFiles" },
                values: new object[] { 1L, new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(5987), "Default", true, "", "", "pt-BR", new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(5989), new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(5988), (byte)1, (byte)0, (byte)0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[] { 1L, new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6054), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6054), "ApplicationLanguage" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6226), "admin@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6226), "admin", null, new DateTime(2024, 3, 31, 0, 3, 33, 724, DateTimeKind.Utc).AddTicks(6227), "User MOCK ", new byte[] { 241, 151, 202, 186, 226, 34, 250, 214, 173, 72, 163, 186, 53, 15, 204, 99, 133, 63, 20, 250, 149, 115, 166, 39, 196, 61, 234, 140, 151, 59, 118, 212, 80, 9, 78, 129, 70, 27, 207, 220, 180, 224, 137, 133, 21, 215, 37, 84, 158, 4, 235, 45, 46, 236, 187, 244, 179, 224, 165, 220, 80, 4, 251, 87 }, new byte[] { 117, 105, 170, 39, 131, 30, 70, 21, 184, 7, 1, 124, 107, 241, 116, 146, 178, 159, 56, 233, 48, 142, 139, 108, 123, 65, 123, 197, 161, 36, 196, 168, 190, 82, 197, 81, 138, 55, 217, 56, 91, 221, 166, 140, 103, 94, 52, 234, 180, 28, 226, 113, 144, 174, 2, 150, 181, 85, 242, 98, 224, 202, 0, 103, 179, 138, 12, 85, 216, 14, 162, 100, 90, 137, 255, 97, 234, 101, 204, 235, 43, 253, 138, 75, 21, 210, 245, 75, 131, 24, 170, 117, 16, 195, 238, 7, 42, 182, 181, 131, 206, 117, 154, 237, 134, 117, 232, 141, 49, 113, 103, 87, 95, 185, 91, 166, 249, 137, 241, 155, 47, 57, 229, 93, 229, 235, 203, 66 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "SecurityKey", "TypeAccreditation", "UserId" },
                values: new object[] { 1L, "123456", new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8158), 1L, "medical@sistemas.com", true, new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8159), new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8159), null, "Medical MOCK ", 1L, "", (byte)0, null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroupUser",
                columns: new[] { "RoleGroupsId", "UsersId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "MedicalSpecialty",
                columns: new[] { "MedicalsId", "SpecialtiesId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 2L, false, new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8421), "doctor@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8421), "doctor", 1L, new DateTime(2024, 3, 31, 0, 3, 33, 726, DateTimeKind.Utc).AddTicks(8422), "User Medical", new byte[] { 131, 98, 41, 63, 232, 118, 132, 88, 218, 191, 67, 118, 173, 30, 14, 20, 140, 27, 71, 73, 69, 105, 227, 104, 12, 29, 111, 231, 213, 157, 46, 148, 118, 228, 199, 106, 34, 228, 9, 190, 142, 123, 46, 109, 5, 185, 214, 66, 128, 72, 239, 175, 186, 132, 180, 250, 199, 222, 21, 251, 128, 231, 29, 98 }, new byte[] { 210, 77, 208, 157, 248, 216, 121, 132, 68, 40, 199, 22, 252, 59, 105, 52, 236, 194, 168, 103, 222, 59, 83, 163, 204, 245, 59, 217, 85, 49, 123, 246, 129, 58, 4, 72, 105, 21, 66, 182, 66, 43, 16, 125, 179, 161, 252, 203, 19, 96, 214, 183, 171, 191, 55, 93, 194, 185, 194, 15, 228, 106, 221, 148, 135, 173, 89, 38, 246, 34, 217, 182, 150, 85, 173, 57, 59, 216, 68, 166, 208, 201, 201, 133, 12, 229, 103, 240, 161, 34, 210, 14, 184, 53, 34, 82, 223, 219, 161, 232, 141, 193, 211, 11, 101, 245, 196, 24, 11, 169, 73, 44, 81, 182, 68, 253, 184, 196, 135, 199, 184, 248, 174, 135, 208, 161, 253, 131 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2024, 3, 31, 0, 3, 33, 728, DateTimeKind.Utc).AddTicks(8838), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2024, 3, 31, 0, 3, 33, 728, DateTimeKind.Utc).AddTicks(8839), (byte)0, 1L, new DateTime(2024, 3, 31, 0, 3, 33, 728, DateTimeKind.Utc).AddTicks(8840), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" });

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
                name: "IX_MedicalSpecialty_SpecialtiesId",
                schema: "dbo",
                table: "MedicalSpecialty",
                column: "SpecialtiesId");

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
