using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Context.Mock;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por MedicalSpecialtyConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class MedicalSpecialtyConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<MedicalSpecialty>
    {
        /// <summary>
        /// Método MedicalSpecialtyConfiguration: executa a operação MedicalSpecialtyConfiguration.
        /// </summary>
        public MedicalSpecialtyConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<MedicalSpecialty> builder)
        {
            builder.ToTable("MedicalSpecialty", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => new { e.MedicalId, e.SpecialtyId });
            // Properties
            builder.Property(e => e.MedicalId);
            builder.Property(e => e.SpecialtyId);

            // Relationship
            builder.HasOne(e => e.Medical).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.MedicalId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Specialty).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.SpecialtyId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(MedicalSpecialtyMockData.GetMock());
        }
    }
}
