using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;

/// <summary>
/// Casca ModelBuilderExtensions — discovery de *Configuration com ctor (ETypeDataBase).
/// SCH tem AddConfigurationEntities sem enum e com Activator parameterless.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.ModelBuilderExtensions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho marcado; corpo local (passa ETypeDataBase ao ctor das configs) — assinatura SCH distinta.")]
public static class ModelBuilderExtensions
{
    public static void AddConfigurationEntities(this ModelBuilder modelBuilder, ETypeDataBase eDataBaseType, Assembly assembly, List<Type> manuallyConfiguredTypes)
    {
        Type[] configTypes = ListClassConfiguration(assembly, manuallyConfiguredTypes).OrderBy(t => t.Name).ToArray();

        foreach (var configType in configTypes)
        {
            dynamic configInstance = Activator.CreateInstance(configType, eDataBaseType)!;
            modelBuilder.ApplyConfiguration(configInstance);
        }
    }

    private static Type[] ListClassConfiguration(Assembly assembly, List<Type> manuallyConfiguredTypes)
    {
        return assembly.GetTypes()
            .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                && !manuallyConfiguredTypes.Contains(t)
                && t.Name.EndsWith("Configuration"))
            .ToArray();
    }
}
