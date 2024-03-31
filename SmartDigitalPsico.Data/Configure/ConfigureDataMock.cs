using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;
using System.Globalization;

namespace SmartDigitalPsico.Data.Configure
{
    internal static class ConfigureDataMock
    {
        static string valorbr = new CultureInfo("pt-BR").Name;
        internal static void GenerateMock(ModelBuilder modelBuilder, ETypeDataBase eTypeDataBase)
        {

            #region ApplicationConfigSetting
            addMockApplicationConfigSetting(modelBuilder);
            #endregion

            #region ApplicationLanguage
            addMockApplicationLanguage(modelBuilder);
            #endregion

            #region Gender
            List<Gender> genders = addMockGender(modelBuilder);
            #endregion

            #region Office
            List<Office> offices = addMockOffice(modelBuilder);
            #endregion

            #region Specialty
            List<Specialty> specialtySAdd = addMockSpecialty(modelBuilder);
            #endregion Specialty

            #region RoleGroup

            addMockRoleGroup(modelBuilder);

            #endregion RoleGroup

            #region User

            addMockUser(modelBuilder);
            #endregion

            #region Medical

            addMockMedical(modelBuilder, specialtySAdd, genders);

            #endregion Medical 

        }

        private static void addMockApplicationLanguage(ModelBuilder modelBuilder)
        {
            List<ApplicationLanguage> addRegisters = new List<ApplicationLanguage>();
            addRegisters.Add(gerateNewLanguage(1, "Default", valorbr, "Default_ptbr", "Padrão"));
            modelBuilder.Entity<ApplicationLanguage>().HasData(addRegisters);
        }

        private static ApplicationLanguage gerateNewLanguage(long id, string description, string valueLanguage, string languageKey, string languageValue)
        {
            return new ApplicationLanguage
            {
                Id = id,
                Description = description,
                Language = valueLanguage,
                LanguageKey = languageKey,
                LanguageValue = languageValue,
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                Enable = true,
            };
        }

        private static void addMockApplicationConfigSetting(ModelBuilder modelBuilder)
        {
            List<ApplicationConfigSetting> addRegisters = new List<ApplicationConfigSetting>();
            addRegisters.Add(new ApplicationConfigSetting
            {
                Id = 1,
                Description = "Default",
                Language = valorbr,
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                TypeLocationCache = ETypeLocationCache.Memory,
                TypeLocationSaveFiles = ETypeLocationSaveFiles.DataBase,
                TypeLocationQueeMessaging = ETypeLocationQueeMessaging.MongoDB,
                EndPointUrl_Cache = string.Empty,
                EndPointUrl_StorageFiles = string.Empty,
                Enable = true,
            });
            modelBuilder.Entity<ApplicationConfigSetting>().HasData(addRegisters);
        }

        private static void addMockMedical(ModelBuilder modelBuilder, List<Specialty> specialtySAdd, List<Gender> genders)
        {
            var medicalSpecialtyS = new List<Specialty>();
            medicalSpecialtyS.Add(specialtySAdd.First());

            var newAddMedical = new Medical
            {
                Id = 1,
                Name = "Medical MOCK ",
                Email = "medical@sistemas.com",
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                Accreditation = "123456",
                TypeAccreditation = ETypeAccreditation.CRM,
                OfficeId = 1,
                CreatedUserId = 1,
            };
            modelBuilder.Entity<Medical>().HasMany(p => p.Specialties).WithMany(p => p.Medicals).UsingEntity(j => j.HasData(new
            { SpecialtiesId = (long)1, MedicalsId = (long)1 }));

            modelBuilder.Entity<Medical>().HasData(newAddMedical);

            var newAddUserMedical = new User
            {
                Id = 2,
                Name = "User Medical",
                Login = "doctor",
                Admin = false,
                Email = "doctor@sistemas.com",
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                Role = "Medical",
                MedicalId = 1,
                Language = getCulture(),
                TimeZone = getTimeZone()

            };
            SecurityHelper.CreatePasswordHash("doctor123", out byte[] passwordHashM, out byte[] passwordSaltM);
            newAddUserMedical.PasswordHash = passwordHashM;
            newAddUserMedical.PasswordSalt = passwordSaltM;

            modelBuilder.Entity<User>().HasData(newAddUserMedical);

            modelBuilder.Entity<User>().HasMany(p => p.RoleGroups).WithMany(p => p.Users).UsingEntity(j => j.HasData(
                new { RoleGroupsId = (long)1, UsersId = (long)1 },
                new { RoleGroupsId = (long)2, UsersId = (long)2 }));

            #region Patient

            addMockPatient(modelBuilder, genders);

            #endregion Patient


        }

        private static void addMockPatient(ModelBuilder modelBuilder, List<Gender> genders)
        {
            var newAddPatient = new Patient
            {
                Id = 1,
                Name = "Tiago Thales Mendes",
                Email = "tiago.thales.mendes@andrade.com",
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                CreatedUserId = 2,
                AddressCep = "45675-970",
                AddressCity = "Aurelino Leal",
                AddressNeighborhood = "Centro",
                AddressState = "Bahia",
                AddressStreet = "Avenida Presidente Médici 264",
                Cpf = "947.846.605-42",
                DateOfBirth = new DateTime(1960, 03, 11),
                Education = "Superior",
                EmergencyContactName = "Milena Isabelly Vanessa",
                EmergencyContactPhoneNumber = "(73) 98540-4268",
                MedicalId = 1,
                PhoneNumber = "(73) 2877-3408",
                Profession = "Professor",
                Rg = "13.809.283-7",
                GenderId = (long)1,
            };
            modelBuilder.Entity<Patient>().HasData(newAddPatient);
        }

        private static void addMockUser(ModelBuilder modelBuilder)
        {
            var newAddUser = new User
            {
                Id = 1,
                Name = "User MOCK ",
                Login = "admin",
                Admin = true,
                Email = "admin@sistemas.com",
                CreatedDate = CultureDateTimeHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = CultureDateTimeHelper.GetDateTimeNow(),
                ModifyDate = CultureDateTimeHelper.GetDateTimeNow(),
                Role = "Admin",
                Language = getCulture(),
                TimeZone = getTimeZone()

            };
            SecurityHelper.CreatePasswordHash("mock123adm", out byte[] passwordHash, out byte[] passwordSalt);
            newAddUser.PasswordHash = passwordHash;
            newAddUser.PasswordSalt = passwordSalt;

            newAddUser.RoleGroups = new List<RoleGroup>();

            modelBuilder.Entity<User>().HasData(newAddUser);
        }

        private static string? getTimeZone()
        {
            return CultureDateTimeHelper.GetTimeZonesIds().Where(c =>
             c.Name.ToUpper().Contains("o Paulo".ToUpper()) || c.Id.ToUpper().Contains("o Paulo".ToUpper())
             || c.Name.ToUpper().Contains("Brasília".ToUpper()) || c.Id.ToUpper().Contains("Brasília".ToUpper())
             ).FirstOrDefault()?.Id;
        }

        private static string? getCulture()
        {
            return CultureDateTimeHelper.GetCultures().Where(c => c.Id.ToUpper().Contains("pt-br".ToUpper())).FirstOrDefault()?.Id;
        }

        private static void addMockRoleGroup(ModelBuilder modelBuilder)
        {
            List<RoleGroup> rolesAdd = new List<RoleGroup>();
            rolesAdd.Add(new RoleGroup { Id = 1, Enable = true, RolePolicyClaimCode = "Admin", Description = "Administrador", Language = valorbr , CreatedDate= CultureDateTimeHelper.GetDateTimeNow() });
            rolesAdd.Add(new RoleGroup { Id = 2, Enable = true, RolePolicyClaimCode = "Medical", Description = "Medico", Language = valorbr, CreatedDate = CultureDateTimeHelper.GetDateTimeNow() });
            rolesAdd.Add(new RoleGroup { Id = 3, Enable = true, RolePolicyClaimCode = "Staff", Description = "Recepcionista", Language = valorbr, CreatedDate = CultureDateTimeHelper.GetDateTimeNow() });
            rolesAdd.Add(new RoleGroup { Id = 4, Enable = true, RolePolicyClaimCode = "Patient", Description = "Paciente", Language = valorbr, CreatedDate = CultureDateTimeHelper.GetDateTimeNow() });
            rolesAdd.Add(new RoleGroup { Id = 5, Enable = true, RolePolicyClaimCode = "Read", Description = "Leitura", Language = valorbr, CreatedDate = CultureDateTimeHelper.GetDateTimeNow() });
            rolesAdd.Add(new RoleGroup { Id = 6, Enable = true, RolePolicyClaimCode = "Write", Description = "Escrita", Language = valorbr, CreatedDate = CultureDateTimeHelper.GetDateTimeNow() });

            modelBuilder.Entity<RoleGroup>().HasData(rolesAdd);
        }

        private static List<Specialty> addMockSpecialty(ModelBuilder modelBuilder)
        {
            var specialtySAdd = new List<Specialty>();

            specialtySAdd.Add(new Specialty { Id = 1, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia Clínica", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 2, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia Social", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 3, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia educacional", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 4, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia Esportiva ", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 5, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia organizacional", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 6, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia hospitalar", Language = valorbr });
            specialtySAdd.Add(new Specialty { Id = 7, Enable = true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Psicologia do trânsito", Language = valorbr });
                                                                    
            modelBuilder.Entity<Specialty>().HasData(specialtySAdd);

            return specialtySAdd;
        }

        private static List<Office> addMockOffice(ModelBuilder modelBuilder)
        {
            List<Office> officeAdd = new List<Office>();
            officeAdd.Add(new Office { Id = 1, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Enable = true, Description = "Psicólogo", Language = valorbr });
            officeAdd.Add(new Office { Id = 2, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Enable = true, Description = "Psicóloga", Language = valorbr });
            officeAdd.Add(new Office { Id = 3, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Enable = true, Description = "Clínico", Language = valorbr });
                                           
            modelBuilder.Entity<Office>().HasData(officeAdd);

            return officeAdd;
        }

        private static List<Gender> addMockGender(ModelBuilder modelBuilder)
        {
            List<Gender> listAdd = new List<Gender>() {
                new Gender { Id = 1,Enable= true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Masculino", Language = valorbr },
                new Gender { Id = 2,Enable= true, CreatedDate= CultureDateTimeHelper.GetDateTimeNow() , Description = "Feminino", Language = valorbr }
            };
            modelBuilder.Entity<Gender>().HasData(listAdd);

            return listAdd;
        }
    }
}
