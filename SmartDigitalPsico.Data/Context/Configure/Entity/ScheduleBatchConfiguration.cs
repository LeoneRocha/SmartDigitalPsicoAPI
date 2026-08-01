using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class ScheduleBatchConfiguration : EntityBaseConfiguration<ScheduleBatch>
    {
        public ScheduleBatchConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        public override void Configure(EntityTypeBuilder<ScheduleBatch> builder)
        {
            builder.ToTable("ScheduleBatch", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
             
            builder.Property(e => e.UniqueToken)
                .HasMaxLength(40)
                .HasColumnType("varchar(40)");

            builder.Property(e => e.StartPeriod);
            builder.Property(e => e.EndPeriod);
             
            // Configuração do DataHistory para serialização/desserialização automática
            builder.Property(e => e.ScheduleData)
                .IsRequired()
                .HasMaxLength(EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(ETypeDataBase.Mysql))
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase.Mysql))
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<ScheduleItem[]>(v)!,
                    CollectionValueComparerHelper.ForJsonArray<ScheduleItem>());
              
            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);

            // Index
            builder.HasIndex(p => new { p.MedicalId, p.PatientId, p.StartPeriod, p.EndPeriod })
                .HasDatabaseName("IX_ScheduleBatch_MedicalId_PatientId_Period")
                .IsUnique(false);

            builder.HasIndex(p => p.UniqueToken)
                .HasDatabaseName("IX_ScheduleBatch_UniqueToken")
                .IsUnique(true);
        }
    }
}
