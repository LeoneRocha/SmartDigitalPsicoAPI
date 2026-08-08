using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por UserMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class UserMockData
    {
        // Hashes estáticos (não use SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash em HasData — salt aleatório a cada build).
        // Senhas: admin = mock123adm | doctor = doctor123
        private static readonly byte[] AdminPasswordHash =
        [
            38, 73, 50, 57, 196, 95, 53, 230, 241, 187, 156, 189, 61, 131, 79, 115, 130, 38, 60, 76, 3, 254, 123, 140, 182, 115, 170, 255, 41, 131, 114, 79, 66, 148, 243, 126, 20, 181, 114, 31, 81, 71, 160, 186, 246, 254, 179, 41, 119, 89, 126, 206, 6, 145, 194, 223, 33, 29, 156, 202, 233, 60, 75, 163
        ];

        private static readonly byte[] AdminPasswordSalt =
        [
            155, 128, 202, 223, 140, 136, 152, 176, 172, 135, 52, 36, 227, 139, 133, 10, 140, 129, 162, 171, 97, 123, 95, 198, 85, 180, 231, 50, 120, 109, 169, 94, 148, 110, 210, 167, 135, 88, 203, 165, 28, 136, 131, 8, 240, 130, 216, 117, 229, 107, 203, 116, 68, 63, 203, 75, 88, 175, 81, 128, 21, 77, 223, 87, 4, 206, 195, 91, 209, 208, 62, 157, 165, 246, 165, 132, 253, 140, 92, 122, 151, 64, 206, 61, 94, 153, 189, 85, 208, 254, 12, 235, 141, 161, 253, 177, 243, 102, 163, 39, 103, 43, 156, 4, 178, 184, 29, 181, 93, 44, 217, 23, 41, 196, 1, 104, 53, 228, 1, 236, 112, 75, 115, 111, 159, 108, 242, 62
        ];

        private static readonly byte[] DoctorPasswordHash =
        [
            196, 152, 217, 45, 134, 235, 199, 46, 25, 217, 35, 35, 45, 205, 86, 45, 251, 246, 85, 44, 127, 50, 232, 140, 228, 34, 113, 77, 107, 188, 184, 33, 111, 46, 62, 153, 204, 2, 102, 143, 105, 129, 60, 25, 59, 124, 159, 81, 43, 212, 245, 249, 175, 33, 19, 139, 77, 123, 6, 95, 104, 200, 99, 108
        ];

        private static readonly byte[] DoctorPasswordSalt =
        [
            246, 238, 15, 28, 37, 91, 12, 134, 68, 76, 211, 137, 236, 155, 62, 170, 53, 25, 7, 48, 14, 21, 29, 241, 231, 17, 16, 205, 194, 82, 161, 166, 63, 222, 65, 90, 70, 23, 148, 17, 51, 220, 65, 87, 110, 251, 11, 146, 227, 107, 44, 102, 172, 244, 159, 66, 216, 255, 223, 38, 59, 139, 143, 56, 137, 25, 80, 162, 104, 226, 45, 220, 38, 170, 149, 140, 8, 228, 199, 37, 45, 199, 34, 6, 122, 203, 112, 242, 206, 124, 61, 61, 147, 158, 68, 101, 241, 100, 165, 226, 41, 134, 36, 2, 41, 86, 230, 75, 18, 152, 8, 61, 121, 148, 211, 89, 232, 248, 185, 5, 204, 225, 203, 119, 123, 86, 40, 201
        ];

        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static User[] GetMock()
        {
            return
            [
                new User
                {
                    Id = 1,
                    Name = "User MOCK ",
                    Login = "admin",
                    Admin = true,
                    Email = "admin@sistemas.com",
                    CreatedDate = MockSeedDates.SeedUtc,
                    Enable = true,
                    LastAccessDate = MockSeedDates.SeedUtc,
                    ModifyDate = MockSeedDates.SeedUtc,
                    Role = "Admin",
                    Language = CultureConstants.LanguagePTBR,
                    TimeZone = CultureConstants.TimeZoneBrazilWindows,
                    PasswordHash = AdminPasswordHash,
                    PasswordSalt = AdminPasswordSalt,
                },
                new User
                {
                    Id = 2,
                    Name = "Dr. Gabriel Monteiro",
                    Login = "doctor",
                    Admin = false,
                    Email = "doctor@sistemas.com",
                    CreatedDate = MockSeedDates.SeedUtc,
                    Enable = true,
                    LastAccessDate = MockSeedDates.SeedUtc,
                    ModifyDate = MockSeedDates.SeedUtc,
                    Role = "Medical",
                    MedicalId = 1,
                    Language = CultureConstants.LanguagePTBR,
                    TimeZone = CultureConstants.TimeZoneBrazilWindows,
                    PasswordHash = DoctorPasswordHash,
                    PasswordSalt = DoctorPasswordSalt,
                }
            ];
        }
    }
}
