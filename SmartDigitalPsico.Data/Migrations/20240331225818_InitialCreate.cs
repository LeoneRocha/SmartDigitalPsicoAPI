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
                values: new object[] { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(179), "Default", true, "", "", "pt-BR", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(181), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(180), (byte)1, (byte)0, (byte)0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(366), "Registro atualizado", true, "pt-BR", "RegisterUpdated", "Registro atualizado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(367), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(366), "SharedResource" },
                    { 2L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(368), "Default", true, "pt-BR", "Default_ptbr", "Padrão", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(369), "ApplicationLanguage" },
                    { 3L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(371), "Registro encontrado", true, "pt-BR", "RegisterIsFound", "Registro encontrado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(371), "SharedResource" },
                    { 4L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(373), "Registro não encontrado", true, "pt-BR", "RegisterIsNotFound", "Registro não encontrado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(373), "SharedResource" },
                    { 5L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(375), "Registro existe", true, "pt-BR", "RegisterExist", "Registro existe", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(375), "SharedResource" },
                    { 6L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(376), "Registro deletado", true, "pt-BR", "RegisterDeleted", "Registro deletado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(377), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(377), "SharedResource" },
                    { 7L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(378), "Registro localizado", true, "pt-BR", "RegisterFind", "Registro localizado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(379), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(379), "SharedResource" },
                    { 8L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(380), "Registros contabilizados", true, "pt-BR", "RegisterCounted", "Registros contabilizados", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(381), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(381), "SharedResource" },
                    { 9L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(382), "Registro criado", true, "pt-BR", "RegisterCreated", "Registro criado", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(383), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(383), "SharedResource" },
                    { 10L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(384), "A descrição não pode ser vazia", true, "pt-BR", "ErrorValidator_Description_Null", "A descrição não pode ser vazia", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(385), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(385), "SharedResource" },
                    { 11L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(386), "O idoma não pode ser vazio", true, "pt-BR", "ErrorValidator_Language_Null", "O idoma não pode ser vazio", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(387), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(387), "SharedResource" },
                    { 12L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(388), "O idoma não pode ultrapassar {MaxLength}", true, "pt-BR", "ErrorValidator_Language_MaximumLength", "O idoma não pode ultrapassar {MaxLength}", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(389), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(389), "SharedResource" },
                    { 13L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(390), "Válido", true, "pt-BR", "LangValid", "Válido", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(391), "SharedResource" },
                    { 14L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(392), "Ocorreram erros!", true, "pt-BR", "LangErrors", "Ocorreram erros!", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(393), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(393), "SharedResource" },
                    { 15L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(394), "O medico deve ser informado.", true, "pt-BR", "ErrorValidator_MedicalId_Null", "O medico deve ser informado.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(395), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(395), "SharedResource" },
                    { 16L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(396), "O medico informado não existe.", true, "pt-BR", "ErrorValidator_MedicalId_NotFound", "O medico informado não existe.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(397), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(396), "SharedResource" },
                    { 17L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(398), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_Medical_Changed", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(399), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(398), "SharedResource" },
                    { 18L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(400), "O nome não pode ser vazio", true, "pt-BR", "ErrorValidator_Name_Null", "O nome não pode ser vazio", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(400), "SharedResource" },
                    { 19L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(402), "O Login não pode ser vazio.", true, "pt-BR", "ErrorValidator_Login_Null", "O Login não pode ser vazio.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(403), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(402), "SharedResource" },
                    { 20L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(404), "Login deve ser unico.", true, "pt-BR", "ErrorValidator_Login_Unique", "Login deve ser unico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(405), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(404), "SharedResource" },
                    { 21L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(406), "O Email não pode ser vazio", true, "pt-BR", "ErrorValidator_Email_Null", "O Email não pode ser vazio", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(406), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(406), "SharedResource" },
                    { 22L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(408), "O Email é invalido.", true, "pt-BR", "ErrorValidator_Email_Invalid", "O Email é invalido.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(408), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(408), "SharedResource" },
                    { 23L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(410), "O Email deve ser unico.", true, "pt-BR", "ErrorValidator_Email_Unique", "O Email deve ser unico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(410), "SharedResource" },
                    { 24L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(412), "O Credenciamento não pode ser vazio.", true, "pt-BR", "ErrorValidator_Accreditation_Null", "O Credenciamento não pode ser vazio.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(412), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(412), "SharedResource" },
                    { 25L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(414), "O Credenciamento deve ser unico.", true, "pt-BR", "ErrorValidator_Accreditation_Unique", "O Credenciamento deve ser unico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(414), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(414), "SharedResource" },
                    { 26L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(416), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalCreated_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(416), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(416), "SharedResource" },
                    { 27L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(418), "O medico infomado deve ser o mesmo logado. Medicos", true, "pt-BR", "ErrorValidator_MedicalModify_Invalid", "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(418), "SharedResource" },
                    { 28L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(419), "O Paciente deve ser informado.", true, "pt-BR", "ErrorValidator_Patient_Null", "O Paciente deve ser informado.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(420), "SharedResource" },
                    { 29L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(421), "O Paciente informado não existe.", true, "pt-BR", "ErrorValidator_Patient_NotFound", "O Paciente informado não existe.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(422), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(422), "SharedResource" },
                    { 30L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(423), "O Paciente não pode ser alterado.", true, "pt-BR", "ErrorValidator_Patient_Changed", "O Paciente não pode ser alterado.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(424), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(424), "SharedResource" },
                    { 31L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(425), "Informações do paciente não podem ser adicionadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Created", "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(425), "SharedResource" },
                    { 32L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(427), "Informações do paciente não podem ser modificadas ", true, "pt-BR", "ErrorValidator_Patient_Medical_Modify", "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(427), "SharedResource" },
                    { 33L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(429), "O Usuário que está criando deve ser informado.", true, "pt-BR", "ErrorValidator_CreatedUserId_Null", "O Usuário que está criando deve ser informado.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(429), "SharedResource" },
                    { 34L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(431), "A anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_Annotation_Null", "A anotação não pode ser vazia.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(432), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(431), "SharedResource" },
                    { 35L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(433), "A data da anotação não pode ser vazia.", true, "pt-BR", "ErrorValidator_AnnotationDate_Null", "A data da anotação não pode ser vazia.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(433), "SharedResource" },
                    { 36L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(435), "Data de nascimento invalido", true, "pt-BR", "ErrorValidator_DateOfBirth_Invalid", "Data de nascimento invalido", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(435), "SharedResource" },
                    { 37L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(437), "O Rg não pode ser vazio.", true, "pt-BR", "ErrorValidator_RG_Null", "O Rg não pode ser vazio.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(437), "SharedResource" },
                    { 38L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(438), "O CPF não pode ser vazio.", true, "pt-BR", "ErrorValidator_CPF_Null", "O CPF não pode ser vazio.", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(439), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(439), "SharedResource" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(547), "Masculino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(548), "Feminino", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Office",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(949), "Psicólogo", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(951), "Psicóloga", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(952), "Clínico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RoleGroup",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "RolePolicyClaimCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1149), "Administrador", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1150), "Medico", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical" },
                    { 3L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1151), "Recepcionista", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff" },
                    { 4L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1152), "Paciente", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient" },
                    { 5L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1153), "Leitura", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read" },
                    { 6L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1154), "Escrita", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Write" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Specialty",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1250), "Psicologia Clínica", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1251), "Psicologia Social", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1252), "Psicologia educacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1253), "Psicologia Esportiva ", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1254), "Psicologia organizacional", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1255), "Psicologia hospitalar", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1256), "Psicologia do trânsito", true, "pt-BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "Id", "Admin", "CreatedDate", "Email", "Enable", "Language", "LastAccessDate", "Login", "MedicalId", "ModifyDate", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "Refresh_token_expiry_time", "Role", "TimeZone" },
                values: new object[] { 1L, true, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1348), "admin@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1348), "admin", null, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1349), "User MOCK ", new byte[] { 62, 181, 110, 188, 232, 252, 178, 131, 57, 37, 33, 59, 189, 125, 170, 205, 255, 38, 164, 165, 49, 103, 117, 13, 148, 250, 147, 99, 137, 98, 106, 96, 194, 239, 11, 149, 22, 143, 204, 181, 135, 51, 11, 15, 211, 109, 178, 196, 66, 69, 51, 72, 132, 88, 202, 179, 21, 132, 81, 245, 103, 92, 22, 195 }, new byte[] { 82, 6, 137, 15, 69, 78, 181, 66, 188, 13, 70, 25, 214, 36, 75, 176, 147, 17, 51, 37, 197, 129, 132, 64, 224, 5, 206, 178, 238, 146, 186, 207, 112, 238, 174, 114, 212, 254, 82, 12, 47, 251, 37, 225, 215, 130, 191, 10, 233, 46, 252, 82, 111, 157, 0, 107, 241, 42, 85, 17, 28, 141, 161, 187, 234, 194, 223, 197, 122, 2, 188, 106, 216, 124, 8, 29, 153, 157, 37, 160, 48, 71, 111, 233, 183, 187, 50, 58, 2, 99, 144, 200, 84, 53, 40, 73, 22, 95, 70, 241, 210, 34, 161, 30, 166, 61, 37, 41, 99, 22, 42, 221, 16, 57, 3, 162, 100, 216, 158, 143, 115, 24, 74, 172, 188, 180, 100, 32 }, "", null, "Admin", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Medical",
                columns: new[] { "Id", "Accreditation", "CreatedDate", "CreatedUserId", "Email", "Enable", "LastAccessDate", "ModifyDate", "ModifyUserId", "Name", "OfficeId", "SecurityKey", "TypeAccreditation", "UserId" },
                values: new object[] { 1L, "123456", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(642), 1L, "medical@sistemas.com", true, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(643), null, "Medical MOCK ", 1L, "", (byte)0, null });

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
                values: new object[] { 2L, false, new DateTime(2024, 3, 31, 22, 58, 18, 168, DateTimeKind.Utc).AddTicks(3403), "doctor@sistemas.com", true, "pt-BR", new DateTime(2024, 3, 31, 22, 58, 18, 168, DateTimeKind.Utc).AddTicks(3403), "doctor", 1L, new DateTime(2024, 3, 31, 22, 58, 18, 168, DateTimeKind.Utc).AddTicks(3404), "User Medical", new byte[] { 102, 206, 225, 84, 236, 234, 40, 19, 24, 140, 7, 21, 73, 78, 89, 4, 14, 101, 1, 114, 139, 175, 22, 201, 96, 240, 220, 135, 27, 244, 218, 190, 109, 87, 129, 141, 130, 170, 77, 114, 17, 49, 240, 252, 91, 41, 79, 187, 212, 47, 238, 33, 17, 83, 186, 231, 110, 14, 245, 43, 182, 210, 13, 66 }, new byte[] { 49, 54, 18, 229, 32, 133, 134, 216, 134, 229, 118, 176, 234, 92, 201, 26, 212, 139, 241, 166, 185, 122, 62, 180, 101, 18, 203, 103, 31, 27, 250, 3, 151, 20, 225, 126, 134, 137, 212, 136, 94, 161, 14, 8, 159, 109, 144, 11, 191, 173, 218, 214, 91, 194, 234, 34, 243, 225, 68, 30, 56, 208, 125, 45, 219, 5, 248, 42, 244, 195, 41, 136, 246, 49, 81, 73, 71, 63, 142, 180, 199, 219, 177, 152, 71, 204, 104, 51, 167, 231, 43, 134, 49, 234, 198, 150, 88, 117, 114, 185, 189, 157, 213, 251, 145, 185, 172, 88, 144, 177, 164, 132, 99, 163, 100, 5, 194, 234, 25, 210, 142, 173, 31, 138, 157, 247, 9, 123 }, "", null, "Medical", "E. South America Standard Time" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[] { 1L, "45675-970", "Aurelino Leal", "Centro", "Bahia", "Avenida Presidente Médici 264", "947.846.605-42", new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1046), 2L, new DateTime(1960, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superior", "tiago.thales.mendes@andrade.com", "Milena Isabelly Vanessa", "(73) 98540-4268", true, 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1047), (byte)0, 1L, new DateTime(2024, 3, 31, 22, 58, 18, 166, DateTimeKind.Utc).AddTicks(1047), null, "Tiago Thales Mendes", "(73) 2877-3408", "Professor", "13.809.283-7" });

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
