using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientRecord : EntityBase, IEntityBaseLogUser
    {
        #region Columns 
        public string Description { get; set; } = string.Empty;         
        public string Annotation { get; set; } = string.Empty;               
        public DateTime AnnotationDate { get; set; }
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