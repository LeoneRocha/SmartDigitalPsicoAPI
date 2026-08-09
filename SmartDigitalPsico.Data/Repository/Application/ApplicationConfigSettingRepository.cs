using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class ApplicationConfigSettingRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ApplicationConfigSetting>, IApplicationConfigSettingRepository
    {
        /// <summary>
        /// Método ApplicationConfigSettingRepository: executa a operação ApplicationConfigSettingRepository.
        /// </summary>
        public ApplicationConfigSettingRepository(IEntityDataContext context) : base(context) { }

    }
}
