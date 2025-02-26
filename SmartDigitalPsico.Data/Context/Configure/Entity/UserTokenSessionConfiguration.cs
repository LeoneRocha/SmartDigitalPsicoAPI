using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class UserTokenSessionConfiguration : EntityBaseConfiguration<UserTokenSession>
    {
        public UserTokenSessionConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<UserTokenSession> builder)
        {
            builder.ToTable("UserTokenSession", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
           
            builder.Property(e => e.AccessToken)
                 .HasMaxLength(4000)
                 .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                 .IsRequired();

            builder.Property(e => e.RefreshToken)
             .HasMaxLength(4000)
             .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
             .IsRequired();
             
            builder.Property(e => e.RefreshTokenExpiryTime)
                .HasColumnName("Refresh_token_expiry_time")
                .IsRequired();

            builder.Property(e => e.LastAccessDate).IsRequired();
            builder.Property(e => e.CreatedDate).IsRequired();
            builder.Property(e => e.ModifyDate).IsRequired();

            builder.Property(e => e.ExpiresAt).IsRequired();

            // Relationship 
            builder.HasOne(ts => ts.User)
                  .WithOne(u => u.TokenSession)
                  .HasForeignKey<UserTokenSession>(ts => ts.UserId);              
        }
    }
}