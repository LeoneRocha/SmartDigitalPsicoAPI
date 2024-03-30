using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientMedicationInformation : EntityBase, IEntityBaseLogUser
    {
        #region Columns          
        public string Description { get; set; } = string.Empty;                
        public DateTime StartDate { get; set; }                
        public DateTime? EndDate { get; set; }        
        public string Dosage { get; set; } = string.Empty; 
        public string Posology { get; set; } = string.Empty; 
        public string MainDrug { get; set; } = string.Empty;
        #endregion Columns 

        #region Relationship 
        public Patient Patient { get; set; } = new Patient();         
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }          
        public long? CreatedUserId { get; set; }          
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}