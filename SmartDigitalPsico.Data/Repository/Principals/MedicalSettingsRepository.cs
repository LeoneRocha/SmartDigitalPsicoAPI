using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.EntityModels;

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
