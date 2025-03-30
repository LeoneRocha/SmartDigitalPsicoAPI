using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class ScheduleBatch : EntityBase, IEntityBaseLogUser, IEntityMedicalBase
    {
        #region Relationship  
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }
        public Patient? Patient { get; set; }
        public long? PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Relationship

        #region Columns 
        public ScheduleItem[] ScheduleData { get; set; } = []; // string containing multiple schedule entries 
        public string UniqueToken { get; set; } = string.Empty; // Token para identificação do lote (ex: TokenRecurrence)
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; } 
        #endregion Columns 
    } 
} 