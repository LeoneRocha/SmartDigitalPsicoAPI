using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Configure.Entity;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Enuns;
using System.Reflection;

namespace SmartDigitalPsico.Data.Context.Configure
{
    public static class ConfigurationEntitiesHelper
    {
        public static void AddConfigurationEntitiesManually(ModelBuilder modelBuilder, ETypeDataBase eDataBaseType)
        {
            modelBuilder.ApplyConfiguration(new ApplicationCacheLogConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new ApplicationConfigSettingConfiguration(eDataBaseType)); 
        }
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