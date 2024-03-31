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
                values: new object[] { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(2954), "Default", true, "", "", "pt-BR", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(2955), (byte)1, (byte)0, (byte)0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3119), "Registro atualizado", true, "pt-BR", "RegisterUpdated", "Registro atualizado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3119), "SharedResource" },
                    { 2L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3121), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3122), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3122), "ApplicationLanguage" },
                    { 3L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3123), "Registro encontrado", true, "pt-BR", "RegisterIsFound", "Registro encontrado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3124), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3124), "SharedResource" },
                    { 4L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3125), "Registro não encontrado", true, "pt-BR", "RegisterIsNotFound", "Registro não encontrado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3126), "SharedResource" },
                    { 5L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3127), "Registro existe", true, "pt-BR", "RegisterExist", "Registro existe", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3128), "SharedResource" },
                    { 6L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3129), "Registro deletado", true, "pt-BR", "RegisterDeleted", "Registro deletado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3130), "SharedResource" },
                    { 7L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3131), "Registro localizado", true, "pt-BR", "RegisterFind", "Registro localizado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3132), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3131), "SharedResource" },
                    { 8L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3133), "Registros contabilizados", true, "pt-BR", "RegisterCounted", "Registros contabilizados", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3133), "SharedResource" },
                    { 9L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3134), "Registro criado", true, "pt-BR", "RegisterCreated", "Registro criado", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3135), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3135), "SharedResource" },
                    { 10L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3136), "A descrição não pode ser vazia", true, "pt-BR", "ErrorValidator_Description_Null", "A descrição não pode ser vazia", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3137), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3137), "SharedResource" },
                    { 11L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3138), "O idoma não pode ser vazio", true, "pt-BR", "ErrorValidator_Language_Null", "O idoma não pode ser vazio", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3139), "SharedResource" },
                    { 12L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3140), "O idoma não pode ultrapassar {MaxLength}", true, "pt-BR", "ErrorValidator_Language_MaximumLength", "O idoma não pode ultrapassar {MaxLength}", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3141), "SharedResource" },
                    { 13L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3142), "Válido", true, "pt-BR", "LangValid", "Válido", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3143), "SharedResource" },
                    { 14L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3144), "Ocorreram erros!", true, "pt-BR", "LangErrors", "Ocorreram erros!", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3145), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3144), "SharedResource" },
                    { 15L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3146), "O medico deve ser informado.", true, "pt-BR", "ErrorValidator_MedicalId_Null", "O medico deve ser informado.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3146), "SharedResource" },
                    { 16L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3148), "O medico informado não existe.", true, "pt-BR", "ErrorValidator_MedicalId_NotFound", "O medico informado não existe.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3148), "SharedResource" },
                    { 17L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3150), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_Medical_Changed", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3150), "SharedResource" },
                    { 18L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3152), "O nome não pode ser vazio", true, "pt-BR", "ErrorValidator_Name_Null", "O nome não pode ser vazio", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3152), "SharedResource" },
                    { 19L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3154), "O Login não pode ser vazio.", true, "pt-BR", "ErrorValidator_Login_Null", "O Login não pode ser vazio.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3154), "SharedResource" },
                    { 20L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3156), "Login deve ser unico.", true, "pt-BR", "ErrorValidator_Login_Unique", "Login deve ser unico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3156), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3156), "SharedResource" },
                    { 21L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3158), "O Email não pode ser vazio", true, "pt-BR", "ErrorValidator_Email_Null", "O Email não pode ser vazio", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3158), "SharedResource" },
                    { 22L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3160), "O Email é invalido.", true, "pt-BR", "ErrorValidator_Email_Invalid", "O Email é invalido.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3160), "SharedResource" },
                    { 23L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3161), "O Email deve ser unico.", true, "pt-BR", "ErrorValidator_Email_Unique", "O Email deve ser unico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3162), "SharedResource" },
                    { 24L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3163), "O Credenciamento não pode ser vazio.", true, "pt-BR", "ErrorValidator_Accreditation_Null", "O Credenciamento não pode ser vazio.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3164), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3164), "SharedResource" },
                    { 25L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3165), "O Credenciamento deve ser unico.", true, "pt-BR", "ErrorValidator_Accreditation_Unique", "O Credenciamento deve ser unico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3166), "SharedResource" },
                    { 26L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3167), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalCreated_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3168), "SharedResource" },
                    { 27L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3169), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalModify_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3169), "SharedResource" },
                    { 28L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3171), "O Paciente deve ser informado.", true, "pt-BR", "ErrorValidator_Patient_Null", "O Paciente deve ser informado.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3171), "SharedResource" },
                    { 29L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3173), "O Paciente informado não existe.", true, "pt-BR", "ErrorValidator_Patient_NotFound", "O Paciente informado não existe.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3173), "SharedResource" },
                    { 30L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3175), "O Paciente não pode ser alterado.", true, "pt-BR", "ErrorValidator_Patient_Changed", "O Paciente não pode ser alterado.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3175), "SharedResource" },
                    { 31L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3176), "Informações do paciente não podem ser adicionadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Created", "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3177), "SharedResource" },
                    { 32L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3178), "Informações do paciente não podem ser modificadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Modify", "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3179), "SharedResource" },
                    { 33L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3180), "O Usuário que está criando deve ser informado.", true, "pt-BR", "ErrorValidator_CreatedUser_Null", "O Usuário que está criando deve ser informado.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3181), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3180), "SharedResource" },
                    { 34L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3182), "A anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_Annotation_Null", "A anotação não pode ser vazia.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3182), "SharedResource" },
                    { 35L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3184), "A data da anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_AnnotationDate_Null", "A data da anotação não pode ser vazia.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3184), "SharedResource" },
                    { 36L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3186), "Data de nascimento invalido", true, "pt-BR", "ErrorValidator_DateOfBirth_Invalid", "Data de nascimento invalido", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3187), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3186), "SharedResource" },
                    { 37L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3188), "O Rg não pode ser vazio.", true, "pt-BR", "ErrorValidator_RG_Null", "O Rg não pode ser vazio.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3188), "SharedResource" },
                    { 38L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3190), "O CPF não pode ser vazio.", true, "pt-BR", "ErrorValidator_CPF_Null", "O CPF não pode ser vazio.", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3190), "SharedResource" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3298), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3299), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3674), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3675), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3676), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3857), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3858), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3860), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3860), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3861), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3862), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3951), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3952), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3953), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3954), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3955), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3956), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3957), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(4047), "admin@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(4048), "admin", null, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(4048), "User MOCK ", new byte[] { 169, 17, 122, 220, 205, 127, 42, 33, 147, 23, 243, 58, 96, 113, 236, 159, 114, 176, 205, 163, 0, 123, 233, 165, 139, 50, 110, 251, 232, 62, 8, 54, 45, 20, 247, 135, 94, 223, 131, 37, 249, 115, 105, 151, 82, 242, 205, 61, 40, 194, 89, 165, 146, 54, 91, 135, 228, 172, 14, 85, 62, 34, 5, 92 }, new byte[] { 202, 238, 90, 108, 66, 110, 125, 55, 168, 213, 243, 182, 146, 120, 19, 241, 152, 150, 145, 208, 217, 22, 1, 55, 176, 237, 46, 1, 126, 136, 97, 40, 159, 170, 31, 201, 29, 217, 56, 255, 58, 124, 170, 9, 118, 165, 134, 46, 91, 246, 72, 208, 22, 92, 220, 200, 70, 226, 173, 251, 71, 18, 232, 4, 156, 175, 156, 129, 153, 210, 103, 168, 216, 113, 226, 114, 76, 1, 140, 91, 36, 252, 245, 98, 223, 169, 25, 6, 197, 225, 113, 240, 95, 34, 18, 7, 3, 100, 241, 146, 132, 111, 186, 5, 176, 78, 3, 224, 217, 6, 84, 67, 106, 179, 177, 103, 157, 226, 251, 63, 152, 144, 17, 110, 118, 195, 79, 38 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "SecurityKey", "TypeAccreditation", "UserId" },
                values: new object[] { 1L, "123456", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3401), 1L, "medical@sistemas.com", true, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3402), new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3402), null, "Medical MOCK ", 1L, "", (byte)0, null });

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
                values: new object[] { 2L, false, new DateTime(2024, 3, 31, 21, 16, 40, 585, DateTimeKind.Utc).AddTicks(5502), "doctor@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 21, 16, 40, 585, DateTimeKind.Utc).AddTicks(5503), "doctor", 1L, new DateTime(2024, 3, 31, 21, 16, 40, 585, DateTimeKind.Utc).AddTicks(5503), "User Medical", new byte[] { 78, 108, 210, 202, 246, 159, 52, 254, 49, 204, 168, 112, 103, 252, 182, 100, 162, 143, 55, 221, 187, 186, 69, 76, 244, 217, 145, 10, 38, 249, 108, 9, 165, 149, 124, 71, 25, 131, 109, 234, 237, 213, 19, 152, 213, 61, 153, 111, 111, 14, 148, 117, 95, 128, 178, 16, 127, 169, 20, 181, 1, 58, 106, 230 }, new byte[] { 247, 220, 66, 45, 56, 47, 231, 172, 191, 83, 49, 242, 196, 54, 5, 39, 175, 126, 236, 128, 230, 43, 83, 250, 39, 43, 159, 151, 25, 10, 71, 29, 164, 37, 81, 96, 206, 118, 158, 158, 239, 164, 11, 244, 135, 157, 153, 83, 244, 29, 102, 3, 78, 146, 219, 52, 100, 104, 249, 158, 168, 195, 162, 24, 146, 69, 59, 169, 19, 23, 58, 204, 107, 231, 152, 193, 21, 168, 67, 229, 132, 83, 96, 153, 74, 132, 104, 163, 225, 206, 198, 140, 109, 253, 65, 213, 59, 32, 208, 14, 141, 165, 6, 251, 191, 112, 63, 248, 208, 88, 98, 20, 124, 73, 191, 73, 17, 105, 84, 244, 47, 91, 237, 129, 74, 3, 209, 219 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3760), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3761), (byte)0, 1L, new DateTime(2024, 3, 31, 21, 16, 40, 583, DateTimeKind.Utc).AddTicks(3761), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" });

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
