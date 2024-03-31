using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Data.ConfigureMock
{
    public class UserMockData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
             
            modelBuilder.HasMany(p => p.RoleGroups)
                .WithMany(p => p.Users)
                .UsingEntity(j => j.HasData(
                    new { RoleGroupsId = (long)1, UsersId = (long)1 }, 
                    new { RoleGroupsId = (long)2, UsersId = (long)2 }
                    ));
        }
        public static User[] GetMock()
        {
            var newAddUser = new User
            {
                Id = 1,
                Name = "User MOCK ",
                Login = "admin",
                Admin = true,
                Email = "admin@sistemas.com",
                CreatedDate = DataHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                Role = "Admin",
                Language = CultureDateTimeHelper.GetCultureBrazil(),
                TimeZone = CultureDateTimeHelper.GetTimeZoneBrazil()
            };
            SecurityHelper.CreatePasswordHash("mock123adm", out byte[] passwordHash, out byte[] passwordSalt);
            newAddUser.PasswordHash = passwordHash;
            newAddUser.PasswordSalt = passwordSalt;
            newAddUser.RoleGroups = new List<RoleGroup>();

            var newAddUserMedical = new User
            {
                Id = 2,
                Name = "User Medical",
                Login = "doctor",
                Admin = false,
                Email = "doctor@sistemas.com",
                CreatedDate = DataHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                Role = "Medical",
                MedicalId = 1,
                Language = CultureDateTimeHelper.GetCultureBrazil(),
                TimeZone = CultureDateTimeHelper.GetTimeZoneBrazil()
            };
            SecurityHelper.CreatePasswordHash("doctor123", out byte[] passwordHashM, out byte[] passwordSaltM);
            newAddUserMedical.PasswordHash = passwordHashM;
            newAddUserMedical.PasswordSalt = passwordSaltM;

            return [
                newAddUser,
                newAddUserMedical
            ];
        }
    }
}