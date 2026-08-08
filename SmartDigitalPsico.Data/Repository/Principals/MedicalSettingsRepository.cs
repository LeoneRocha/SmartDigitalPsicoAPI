using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por MedicalSettingsRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MedicalSettingsRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<MedicalSettings>, IMedicalSettingsRepository
    {
        /// <summary>
        /// Método MedicalSettingsRepository: executa a operação MedicalSettingsRepository.
        /// </summary>
        public MedicalSettingsRepository(IEntityDataContext context) : base(context) { }
    }
}
