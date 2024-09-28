using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class ApplicationCacheLogConfiguration : IEntityTypeConfiguration<ApplicationCacheLog>
    {
        public void Configure(EntityTypeBuilder<ApplicationCacheLog> builder)
        {
            builder.ToTable("ApplicationCacheLog", "dbo");
            HelperCharSet.AddCharSet(builder);
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
