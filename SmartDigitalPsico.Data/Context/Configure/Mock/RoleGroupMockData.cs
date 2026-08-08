using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por RoleGroupMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class RoleGroupMockData  
    { 
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static RoleGroup[] GetMock()
        {
            return [
                new RoleGroup { Id = 1, Enable = true, RolePolicyClaimCode = "Admin", Description = "Administrador", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
                new RoleGroup { Id = 2, Enable = true, RolePolicyClaimCode = "Medical", Description = "Medico", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
                new RoleGroup { Id = 3, Enable = true, RolePolicyClaimCode = "Staff", Description = "Recepcionista", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
                new RoleGroup { Id = 4, Enable = true, RolePolicyClaimCode = "Patient", Description = "Paciente", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
                new RoleGroup { Id = 5, Enable = true, RolePolicyClaimCode = "Read", Description = "Leitura", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
                new RoleGroup { Id = 6, Enable = true, RolePolicyClaimCode = "Write", Description = "Escrita", Language = CultureConstants.LanguagePTBR, CreatedDate = MockSeedDates.SeedUtc },
            ];
        }
    }
}
