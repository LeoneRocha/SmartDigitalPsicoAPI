using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Configure
{
    internal static class ConfigureRelationsHelper
    {
        internal static void Configure(ModelBuilder modelBuilder)
        {  
            addConfigureMedical(modelBuilder); 

            addConfigurePatientChilds(modelBuilder); 
        }
        private static void addConfigurePatientChilds(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<PatientInfoTag>()
          .HasKey(t => new { t.PatientId, t.InfoTagId });

            modelBuilder.Entity<PatientInfoTag>()
                .HasOne(pt => pt.Patient)
                .WithMany(p => p.PatientInfoTags)
                .HasForeignKey(pt => pt.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PatientInfoTag>()
                .HasOne(pt => pt.InfoTag)
                .WithMany(t => t.PatientInfoTags)
                .HasForeignKey(pt => pt.InfoTagId)
                .OnDelete(DeleteBehavior.NoAction);


        }
        private static void addConfigureMedical(ModelBuilder modelBuilder)
        {
            #region Medical
            // configures one-to-many relationship
            modelBuilder.Entity<Medical>()
                     .HasOne(p => p.Office)
                     .WithMany(b => b.Medicals)
                     .HasForeignKey("OfficeId")
                     .IsRequired();

            
            //configures one-to-one relationship
            modelBuilder.Entity<Medical>()
            .HasOne(b => b.User)
            .WithOne(i => i.Medical)
            .HasForeignKey<User>(b => b.MedicalId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

         

            modelBuilder.Entity<Medical>()
                     .HasOne(p => p.CreatedUser)
                     .WithMany(b => b.MedicalsCreateds)
                     .HasForeignKey(t => t.CreatedUserId)
                     .OnDelete(DeleteBehavior.NoAction)
                     .IsRequired(false);

            modelBuilder.Entity<Medical>()
                     .HasOne(p => p.ModifyUser)
                     .WithMany(b => b.MedicalModifies)
                     .HasForeignKey(t => t.ModifyUserId)
                     .OnDelete(DeleteBehavior.NoAction)
                     .IsRequired(false);
             

            #endregion Medical
        }
    }
}
