using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Context.Mock;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por LeavesConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class LeavesConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<Leaves>
    {
        /// <summary>
        /// Método LeavesConfiguration: executa a operação LeavesConfiguration.
        /// </summary>
        public LeavesConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<Leaves> builder)
        {
            builder.ToTable("Leaves", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.MedicalId).IsRequired(false);
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired(false);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Language).HasMaxLength(10).IsRequired();
            builder.Property(e => e.IsRecurring).IsRequired();

            // Indexes (using Fluent API)
            builder.HasIndex(e => e.MedicalId).HasDatabaseName("IX_Leaves_MedicalId");
            builder.HasIndex(e => new { e.StartDate, e.EndDate }).HasDatabaseName("IX_Leaves_StartDate_EndDate");

            builder.HasData(LeavesMockData.GetMock());
        }
    }
}
