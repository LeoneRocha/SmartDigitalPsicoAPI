using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Configure
{
    internal static class ConfigureProprietiesEntity
    {
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().Property(b => b.Profession).IsRequired(false); 

            addConfigure_ApplicationLanguage(modelBuilder);
        }

        private static void addConfigure_ApplicationLanguage(ModelBuilder modelBuilder)
        {
            //Composite index
            modelBuilder.Entity<ApplicationLanguage>()
                .HasIndex(p => new { p.ResourceKey, p.Language, p.LanguageKey })
                .HasDatabaseName("Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique")
                .IsUnique();


            modelBuilder.Entity<ApplicationLanguage>()
             .HasIndex(p => new { p.ResourceKey, p.Language, p.LanguageKey })
             .HasDatabaseName("Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique")
             .IsUnique();

            modelBuilder.Entity<ApplicationLanguage>()
                 .Property(x => x.Id)
                 .ValueGeneratedOnAdd();
        }
    }
}
