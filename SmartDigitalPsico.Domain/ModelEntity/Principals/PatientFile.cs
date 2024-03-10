using SmartDigitalPsico.Domain.Contracts.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Principals
{
    [Table("PatientFile", Schema = "dbo")]
    public class PatientFile : FileBase, IEntityBaseLogUser
    {
        #region Relationship 

        public Patient Patient { get; set; } = new Patient();

        [ForeignKey("PatientId")]
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }

        [ForeignKey("CreatedUserId")]
        public long? CreatedUserId { get; set; }

        [ForeignKey("ModifyUserId")]
        public long? ModifyUserId { get; set; }
        #endregion Relationship

    }
}