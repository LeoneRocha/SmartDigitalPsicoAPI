﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public class UserMockData : EntityBaseConfiguration<User>
    {
        public UserMockData(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
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