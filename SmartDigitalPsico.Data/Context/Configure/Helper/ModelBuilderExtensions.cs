using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using System.Reflection;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// Classe responsável por ModelBuilderExtensions.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Método AddConfigurationEntities: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddConfigurationEntities(this ModelBuilder modelBuilder, ETypeDataBase eDataBaseType, Assembly assembly, List<Type> manuallyConfiguredTypes)
        {
            Type[] configTypes = ListClassConfiguration(assembly, manuallyConfiguredTypes).OrderBy(t=> t.Name).ToArray();

            foreach (var configType in configTypes)
            {
                dynamic configInstance = Activator.CreateInstance(configType, eDataBaseType)!;
                modelBuilder.ApplyConfiguration(configInstance);
            }
        }

        private static Type[] ListClassConfiguration(Assembly assembly, List<Type> manuallyConfiguredTypes)
        {
            var listAdd = assembly.GetTypes().Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)) && !manuallyConfiguredTypes.Contains(t) && t.Name.EndsWith("Configuration")).ToArray();  
            return listAdd;
        }
    }
}
