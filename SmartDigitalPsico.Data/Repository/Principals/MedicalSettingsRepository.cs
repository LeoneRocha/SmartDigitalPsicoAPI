using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por MedicalSettingsRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MedicalSettingsRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<MedicalSettings>, IMedicalSettingsRepository
    {
        /// <summary>
        /// Método MedicalSettingsRepository: executa a operação MedicalSettingsRepository.
        /// </summary>
        public MedicalSettingsRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }
    }
}
