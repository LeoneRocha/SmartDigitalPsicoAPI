using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class ApplicationConfigSettingRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ApplicationConfigSetting>, IApplicationConfigSettingRepository
    {
        /// <summary>
        /// Método ApplicationConfigSettingRepository: executa a operação ApplicationConfigSettingRepository.
        /// </summary>
        public ApplicationConfigSettingRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

    }
}
