﻿using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class RoleGroupMockData  
    { 
        public static RoleGroup[] GetMock()
        {
            return [
                new RoleGroup { Id = 1, Enable = true, RolePolicyClaimCode = "Admin", Description = "Administrador", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
                new RoleGroup { Id = 2, Enable = true, RolePolicyClaimCode = "Medical", Description = "Medico", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
                new RoleGroup { Id = 3, Enable = true, RolePolicyClaimCode = "Staff", Description = "Recepcionista", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
                new RoleGroup { Id = 4, Enable = true, RolePolicyClaimCode = "Patient", Description = "Paciente", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
                new RoleGroup { Id = 5, Enable = true, RolePolicyClaimCode = "Read", Description = "Leitura", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
                new RoleGroup { Id = 6, Enable = true, RolePolicyClaimCode = "Write", Description = "Escrita", Language = CultureConstants.LanguagePTBR, CreatedDate = DateHelper.GetDateTimeNowFromUtc() },
            ];
        }
    }
}