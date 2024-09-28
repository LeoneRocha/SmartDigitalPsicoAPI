using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class ApplicationCacheLogConfiguration : EntityBaseConfiguration<ApplicationCacheLog>
    {
        public ApplicationCacheLogConfiguration(ETypeDataBase eTypeDataBase) :base(eTypeDataBase) { }
         
        public override void Configure(EntityTypeBuilder<ApplicationCacheLog> builder)
        {
            builder.ToTable("ApplicationCacheLog", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.DateTimeSlidingExpiration);
            builder.Property(c => c.CacheId).HasMaxLength(255);
            builder.Property(c => c.CacheKey).HasMaxLength(255);
        }
    }
}
