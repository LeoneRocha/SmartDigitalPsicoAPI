using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using System.Reflection;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por ConfigurationEntitiesHelper.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class ConfigurationEntitiesHelper
    {
        /// <summary>
        /// Método AddConfigurationEntitiesManually: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddConfigurationEntitiesManually(ModelBuilder modelBuilder, ETypeDataBase eDataBaseType)
        {
            modelBuilder.ApplyConfiguration(new ApplicationCacheLogConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new ApplicationConfigSettingConfiguration(eDataBaseType));
        }
        /// <summary>
        /// Método AddConfigurationEntities: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddConfigurationEntities(ModelBuilder modelBuilder, ETypeDataBase eDataBaseType)
        {
            List<Type> manuallyConfiguredTypes = new List<Type>
            {
                typeof(ApplicationCacheLogConfiguration),
                typeof(ApplicationConfigSettingConfiguration)
            };
            modelBuilder.AddConfigurationEntities(eDataBaseType, Assembly.GetExecutingAssembly(), manuallyConfiguredTypes);
        }
    }
}
