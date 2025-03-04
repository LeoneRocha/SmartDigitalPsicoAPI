using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class EmailTemplateConfiguration : EntityBaseConfiguration<EmailTemplate>
    {
        public EmailTemplateConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.ToTable("EmailTemplate", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.Language).HasMaxLength(10);
            builder.Property(c => c.TagApi).HasMaxLength(255);
            builder.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(e => e.Body)
                .HasMaxLength(EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(ETypeDataBase))
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();

            // Indexes (using Fluent API)
            builder.HasIndex(c => c.Language).HasDatabaseName("IX_EmailTemplate_Language");
            builder.HasIndex(c => c.TagApi).HasDatabaseName("IX_EmailTemplate_TagApi");
            builder.HasIndex(c => new { c.Language, c.TagApi, c.Enable }).HasDatabaseName("IX_EmailTemplate_Language_TagApi_Enable");

            // Seed data
            builder.HasData(EmailTemplateMockData.GetMocks());
        }
    }
}
